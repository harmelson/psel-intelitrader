namespace CharacterRanking
{
    public class Ranking
    {
        private List<KeyValuePair<char, int>> CharacterCount { get; set; } = new List<KeyValuePair<char, int>>();
        public List<string> OrderedRanking { get; set; } = new List<string>();

        public Ranking(Dictionary<char,int> characterCount)
        {
            CharacterCount = characterCount.ToList();

            OrderRanking(CharacterCount, 0, CharacterCount.Count - 1);

            PrintRanking();
        }

        private void PrintRanking()
        {
            Console.WriteLine("Ranking:");
            for (int i = 0; i < CharacterCount.Count; i++)
            {
                OrderedRanking.Add($"{i + 1}º - {CharacterCount[i].Key}: {CharacterCount[i].Value}");
                Console.WriteLine(OrderedRanking[i]);
            };
        }

        private void OrderRanking(List<KeyValuePair<char, int>> characterList, int firstIndex, int lastIndex)
        {
            if(firstIndex < lastIndex)
            {
                int p = Partition(characterList, firstIndex, lastIndex);
                OrderRanking(characterList, firstIndex, p - 1);
                OrderRanking(characterList, p + 1, lastIndex);
            }
        }

        static int Partition(List<KeyValuePair<char, int>> characterList, int firstIndex, int lastIndex)
        {
            KeyValuePair<char, int> pivot = characterList[lastIndex];
            int delimiter = firstIndex - 1;

            for (int i = firstIndex; i < lastIndex; i++)
            {
                if(characterList[i].Value >= pivot.Value)
                {
                    delimiter++;
                    Swap(characterList, i, delimiter);
                }
            }

            Swap(characterList, delimiter + 1, lastIndex);

            return delimiter + 1;
        }

        static void Swap(List<KeyValuePair<char, int>> characterList, int i, int j)
        {
            (characterList[j], characterList[i]) = (characterList[i], characterList[j]);
        }
    }
}