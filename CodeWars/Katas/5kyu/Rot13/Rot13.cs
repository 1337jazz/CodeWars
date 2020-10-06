namespace CodeWars.Katas._5kyu.Rot13
{
    /// <summary>
    /// ROT13 is a simple letter substitution cipher that replaces a letter with the letter 13
    /// letters after it in the alphabet. ROT13 is an example of the Caesar cipher.
    /// Create a function that takes a string and returns the string ciphered with Rot13.
    /// If there are numbers or special characters included in the string, they should be
    /// returned as they are. Only letters from the latin/english alphabet should be shifted,
    /// like in the original Rot13 "implementation".
    /// </summary>
    internal class Rot13_
    {
        public static string Rot13(string message)
        {
            string result = string.Empty;

            foreach (char c in message)
            {
                var ascii = (int)c;
                if (ascii.IsAlpha())
                {
                    var plus13 = ascii;
                    for (int i = 0; i < 13; i++)
                        plus13 = (plus13 + 1).IsAlpha() ? plus13 + 1 : plus13 == 122 ? 97 : 65;

                    result += $"{(char)plus13}";
                }
                else
                    result += c;
            }

            return result;
        }
    }

    public static class Extensions
    {
        public static bool IsAlpha(this int value)
        {
            return (value >= 65 && value <= 90) || (value >= 97 && value <= 122) ? true : false;
        }
    }
}