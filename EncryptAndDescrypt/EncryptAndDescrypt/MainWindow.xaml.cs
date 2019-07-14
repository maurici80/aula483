using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EncryptAndDescrypt
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(tbxInformacaoParaEsconder.Text)
                && !string.IsNullOrEmpty(tbxSenhaParaPoderEsconder.Text))
            {
                tbxConteudoJaEscondido.Text = Ecrypt.Criptografar(tbxInformacaoParaEsconder)
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {


        }

        private static class Ecrypt
        {
            private const string initVector = "kjfkjwoeirjakdcm";
            private const int keysize = 256;

            public static object MemorySream { get; private set; }

            public static string Criptografar(string pTextoEsconder,string pSenha)
            {

                byte[] iniciandiVetorBytes = Encoding.UTF8.GetBytes(initVector);
                byte[] textoPlanoBytes = Encoding.UTF8.GetBytes(pTextoEsconder);

                PasswordDeriveBytes password = new PasswordDeriveBytes(pSenha, null);

                byte[] keyBytes = password.GetBytes(keysize / 8);

                RijndaelManaged symetrycKey = new RijndaelManaged();
                symetrycKey.Mode = CipherMode.CBC;
                ICryptoTransform encrypto = symetrycKey.CreateEncryptor(keyBytes, iniciandiVetorBytes);

                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, encrypto, CryptoStreamMode.Write);
                cryptoStream.Write(textoPlanoBytes, 0, textoPlanoBytes.Length);
                cryptoStream.FlushFinalBlock();

                byte[] textoEmMemoria = memoryStream.ToArray();
                memoryStream.Close();
                cryptoStream.Close();

                return Convert.ToBase64String(textoEmMemoria);

            }

            public static string DesCriptografar(string pTextoEscondido, string pSenha)
            {

                byte[] iniciandiVetorBytes = Encoding.UTF8.GetBytes(initVector);
                byte[] textoPlanoBytes = Convert.FromBase64String(pTextoEscondido)//Encoding.UTF8.GetBytes(pTextoEsconder);

                PasswordDeriveBytes password = new PasswordDeriveBytes(pSenha, null);

                byte[] keyBytes = password.GetBytes(keysize / 8);

                RijndaelManaged symetrycKey = new RijndaelManaged();
                symetrycKey.Mode = CipherMode.CBC;
                ICryptoTransform encrypto = symetrycKey.CreateEncryptor(keyBytes, iniciandiVetorBytes);

                MemoryStream memoryStream = new MemoryStream(textoPlanoBytes);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, encrypto, CryptoStreamMode.Read);
                byte[] texotDescriptografado = new byte[textoPlanoBytes.Length];
                int descryptCount = cryptoStream.Read(textoDescriptografado, 0, textoDescriptografado.Lenght);
                cryptoStream.Write(textoPlanoBytes, 0, textoPlanoBytes.Length);
                cryptoStream.FlushFinalBlock();

                byte[] textoEmMemoria = memoryStream.ToArray();
                memoryStream.Close();
                cryptoStream.Close();

                return Convert.ToBase64String(textoEmMemoria);





            }

        }
    }
}
