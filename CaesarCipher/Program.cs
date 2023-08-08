namespace CaesarCipher
{
    class Program
    {
        static void Main()
        {
            GetFileString getFileString = new();
            Encrypt encripted = new Encrypt(getFileString.InputText ?? string.Empty);

            _ = new ConvertToFile(encripted.EncryptedString ?? string.Empty);
        }
    }
}