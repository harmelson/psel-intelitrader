namespace CharacterRanking
{
    public class CharacterCounter
    {
        private string InputText { get; set; }
        public Dictionary<char, int> CharacterCount { get; set; } = new Dictionary<char, int>();

        public CharacterCounter(string inputText)
        {
            InputText = inputText;

            CounterCharacters();
        }

        private void CounterCharacters()
        {
            for (int i = 0; i < InputText.Length; i++)
            {
                if(CharacterCount.ContainsKey(InputText[i]))
                {
                    CharacterCount[InputText[i]]++;
                }
                else
                {
                    CharacterCount.Add(InputText[i], 1);
                }
            }
        }
    }
}