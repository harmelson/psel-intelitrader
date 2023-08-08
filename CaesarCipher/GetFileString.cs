using System.Text;
using System.IO;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CaesarCipher
{
    public class GetFileString
    {
        private string? InputFilePath { get; set; }
        public string? InputText { get; set; }

        public GetFileString()
        {
            GetText();
        }

        private void GetText()
        {
            try
            {
                Console.WriteLine("Digite o caminho do arquivo:");
                InputFilePath = Console.ReadLine() ?? string.Empty;

                string inputText = File.ReadAllText(InputFilePath, Encoding.UTF8);

                inputText = inputText.Normalize();
                InputText = inputText.ToUpper();
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Arquivo não encontrado.");
                GetText();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Caminho inválido.");
                GetText();
            }
            catch (Exception)
            {
                Console.WriteLine("Erro ao ler o arquivo de entrada.");
                GetText();
            }
        }

    }
}