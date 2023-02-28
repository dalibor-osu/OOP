namespace Lesson4;

public class StringStatistics
{
    private string _text;
    
    public StringStatistics(string text)
    {
        _text = text;
    }
    
    public int NumberOfWords()
    {
        int numberOfWords = 0;
        bool isWord = false;
        
        foreach (char character in _text)
        {
            if (char.IsLetter(character))
            {
                if (isWord)
                    continue;
                
                numberOfWords++;
                isWord = true;
            }
            else
            {
                isWord = false;
            }
        }
        
        return numberOfWords;
    }
    
    public int NumberOfRows() =>
        _text.Count(c => c =='\n');
    
    public int NumberOfSentences()
    {
        int numberOfSentences = 0;
        bool isSentence = false;

        for (int i = 0; i < _text.Length; i++)
        {
            if (_text[i] is not '.' or '!' or '?')
                continue;
            
            if (i + 2 >= _text.Length)
            {
                numberOfSentences++;
                break;
            }
            
            if (!char.IsLower(_text[i + 1]) || !char.IsLower(_text[i + 2]))
            {
                numberOfSentences++;
            }
        }
        
        return numberOfSentences;
    }
}