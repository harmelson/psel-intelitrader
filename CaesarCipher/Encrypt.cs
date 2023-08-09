using System.Text;

namespace CaesarCipher
{
    public class Encrypt
    {
        private string FileString { get; set; }
        private int Key { get; set; }
        private EEncryptDecrypt EncryptDecrypt { get; set; }
        public string? EncryptedString { get; set; }


        
        public Encrypt(string fileString)
        {
            FileString = fileString;

            EncryptMenu();
        }

        private void EncryptMenu()
        {
            GetCrypterDecryptorInput();
            GetKey();
            CrypterDecryptor();
        }

        private void GetCrypterDecryptorInput()
        {
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.WriteLine("1 - Criptografar \n2 - Descriptografar");
            string input = Console.ReadLine() ?? string.Empty;
            var crypterDecryptorInput = int.TryParse(input, out int crypterDecryptor);
            
            if(!crypterDecryptorInput || (crypterDecryptor != 1 && crypterDecryptor != 2)) GetCrypterDecryptorInput();
            if(crypterDecryptor == 1) EncryptDecrypt = EEncryptDecrypt.Encrypt;
            if(crypterDecryptor == 2) EncryptDecrypt = EEncryptDecrypt.Decrypt;
        }

        private void CrypterDecryptor()
        {
            StringBuilder encrypitedStringBuilder = new StringBuilder();
            foreach (var character in FileString)
            {
                if(char.IsLetter(character))
                {
                    int isEncryptOrDecrypt = EncryptDecrypt == EEncryptDecrypt.Encrypt ? Key : -Key;

                     char isUpperCase = char.IsUpper(character) ? 'A' : 'a';
                    int charIndex = character - isUpperCase;
                    
                    char newChar = (char)((charIndex + isEncryptOrDecrypt + 26) % 26 + isUpperCase);

                    encrypitedStringBuilder.Append(newChar);
                }
                else
                {
                    encrypitedStringBuilder.Append((char)(character));
                }
            }
            EncryptedString = encrypitedStringBuilder.ToString();
        }

        private void GetKey()
        {
            Console.WriteLine("Digite um número inteiro entre 1 e 26: ");
            string keyInput = Console.ReadLine() ?? string.Empty;

            bool isKeyInputInt = int.TryParse(keyInput, out int convertedKey);

            if(!isKeyInputInt || convertedKey <= 0 || convertedKey > 26)
            {
                GetKey();
            }

            Key = convertedKey;
        }
    }

    enum EEncryptDecrypt
    {
        Encrypt = 1,
        Decrypt = 2
    }
}