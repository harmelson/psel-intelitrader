using System.Diagnostics;

namespace CharacterRanking
{
    class Program
    {
        static void Main()
        {
            GetFileString getFileString = new();

            CharacterCounter characterCounter = new(getFileString.InputText ?? string.Empty);

            _ = new Ranking(characterCounter.CharacterCount);            
        }
    }
}