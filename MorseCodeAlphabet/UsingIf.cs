#pragma warning disable S3776

namespace MorseCodeAlphabet
{
    public static class UsingIf
    {
        public static string GetMorseCode(char c)
        {
            if (char.ToUpperInvariant(c) == 'A')
            {
                return ".-";
            }
            else if (char.ToUpperInvariant(c) == 'B')
            {
                return "-...";
            }
            else if (char.ToUpperInvariant(c) == 'C')
            {
                return "-.-.";
            }
            else if (char.ToUpperInvariant(c) == 'D')
            {
                return "-..";
            }
            else if (char.ToUpperInvariant(c) == 'E')
            {
                return ".";
            }
            else if (char.ToUpperInvariant(c) == 'F')
            {
                return "..-.";
            }
            else if (char.ToUpperInvariant(c) == 'G')
            {
                return "--.";
            }
            else if (char.ToUpperInvariant(c) == 'H')
            {
                return "....";
            }
            else if (char.ToUpperInvariant(c) == 'I')
            {
                return "..";
            }
            else if (char.ToUpperInvariant(c) == 'J')
            {
                return ".---";
            }
            else if (char.ToUpperInvariant(c) == 'K')
            {
                return "-.-";
            }
            else if (char.ToUpperInvariant(c) == 'L')
            {
                return ".-..";
            }
            else if (char.ToUpperInvariant(c) == 'M')
            {
                return "--";
            }
            else if (char.ToUpperInvariant(c) == 'N')
            {
                return "-.";
            }
            else if (char.ToUpperInvariant(c) == 'O')
            {
                return "---";
            }
            else if (char.ToUpperInvariant(c) == 'P')
            {
                return ".--.";
            }
            else if (char.ToUpperInvariant(c) == 'Q')
            {
                return "--.-";
            }
            else if (char.ToUpperInvariant(c) == 'R')
            {
                return ".-.";
            }
            else if (char.ToUpperInvariant(c) == 'S')
            {
                return "...";
            }
            else if (char.ToUpperInvariant(c) == 'T')
            {
                return "-";
            }
            else if (char.ToUpperInvariant(c) == 'U')
            {
                return "..-";
            }
            else if (char.ToUpperInvariant(c) == 'V')
            {
                return "...-";
            }
            else if (char.ToUpperInvariant(c) == 'W')
            {
                return ".--";
            }
            else if (char.ToUpperInvariant(c) == 'X')
            {
                return "-..-";
            }
            else if (char.ToUpperInvariant(c) == 'Y')
            {
                return "-.--";
            }
            else if (char.ToUpperInvariant(c) == 'Z')
            {
                return "--..";
            }

            return string.Empty;
        }
    }
}
