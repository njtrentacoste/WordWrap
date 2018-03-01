using System.Text;
using System.Text.RegularExpressions;

namespace WordWrap
{
    public class WordWrapper
    {
        public string Wrap(string text, int length)
        {
            var wrapped = new StringBuilder();
            var regex = new Regex("\b");
            var words = regex.Replace(text, " ").Split(' ');
            var lineLength = 0;

            foreach (var word in words)
            {
                var wordLength = word.Length;

                if (wordLength <= length && (wordLength + lineLength) <= length)
                {
                    wrapped.Append(word + " ");
                    lineLength += (wordLength + 1);
                }
                else if (wordLength <= length)
                {
                    wrapped.AppendLine();
                    wrapped.Append(word + " ");
                    lineLength = (wordLength + 1);
                }
                else
                {
                    wrapped.AppendLine();
                    var tempWord = word;

                    do
                    {
                        var firstPart = tempWord.Length >= length ? tempWord.Substring(0, length - 1) : tempWord;
                        if (firstPart.Length < (length - 1))
                        {
                            wrapped.Append(firstPart + " ");
                            lineLength += firstPart.Length;
                        }
                        else
                        {
                            wrapped.Append(firstPart + "-");
                            wrapped.AppendLine();
                            lineLength = 0;
                        }
                        
                        tempWord = tempWord.Replace(firstPart, "");
                        wordLength -= firstPart.Length;
                    }
                    while (wordLength > 0);
                }
            }

            return wrapped.ToString();
        }
    }
}