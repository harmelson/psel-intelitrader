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
            catch (DirectoryNotFoundException)
            {
                Console.WriteLine("Caminho inválido.");
                Converter();
            }
            catch (PathTooLongException)
            {
                Console.WriteLine("Caminho muito longo.");
                Converter();
            }
            catch (IOException)
            {
                Console.WriteLine("Erro ao escrever o arquivo.");
                Converter();
            }
            catch (UnauthorizedAccessException)
            {
                Console.WriteLine("Acesso negado.");
                Converter();
            }
            catch (NotSupportedException)
            {
                Console.WriteLine("Extensão não suportada.");
                Converter();
            }
            catch (Exception)
            {
                Console.WriteLine("Caminho inválido.");
                Converter();
            }
            finally
            {
                Console.WriteLine("Arquivo criptografado/descriptografado com sucesso.");
            }

        }
    }
}