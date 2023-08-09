using System.Text;

namespace CharacterRanking
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
                Console.WriteLine("Digite o caminho do arquivo de texto:");
                InputFilePath = Console.ReadLine() ?? string.Empty;

                string inputText = File.ReadAllText(InputFilePath, Encoding.UTF8);

                InputText = inputText;
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