namespace CaesarCipher
{
    public class ConvertToFile
    {
        string StringToConvert { get; set; }
        string? OutPath { get; set; }

        public ConvertToFile(string stringToConvert)
        {
            StringToConvert = stringToConvert;
            Converter();
        }

        private void Converter()
        {
            try
            {
                Console.WriteLine("Digite o caminho de saída: ");
                OutPath = Console.ReadLine() ?? string.Empty;
                File.WriteAllText(OutPath, StringToConvert);
            }
            catch (System.Exception)
            {
                Converter();
            }
        }
    }
}