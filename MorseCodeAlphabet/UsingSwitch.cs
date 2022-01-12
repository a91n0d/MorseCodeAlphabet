namespace MorseCodeAlphabet
{
    public static class UsingSwitch
    {
        public static byte GetMorseCode(char c)
        {
            switch (char.ToLowerInvariant(c))
            {
                case 'a':
                    return 0b0011_0001;
                case 'b':
                    return 0b1111_1110;
                case 'c':
                    return 0b1111_1010;
                case 'd':
                    return 0b0111_0110;
                case 'e':
                    return 0b0001_0001;
                case 'f':
                    return 0b1111_1011;
                case 'g':
                    return 0b0111_0100;
                case 'h':
                    return 0b1111_1111;
                case 'i':
                    return 0b0011_0011;
                case 'j':
                    return 0b1111_0001;
                case 'k':
                    return 0b0111_0010;
                case 'l':
                    return 0b1111_1101;
                case 'm':
                    return 0b0011_0000;
                case 'n':
                    return 0b0011_0010;
                case 'o':
                    return 0b0111_0000;
                case 'p':
                    return 0b1111_1001;
                case 'q':
                    return 0b1111_0100;
                case 'r':
                    return 0b0111_0101;
                case 's':
                    return 0b0111_0111;
                case 't':
                    return 0b0001_0000;
                case 'u':
                    return 0b0111_0011;
                case 'v':
                    return 0b1111_0111;
                case 'w':
                    return 0b0111_0001;
                case 'x':
                    return 0b1111_0110;
                case 'y':
                    return 0b1111_0010;
                case 'z':
                    return 0b1111_1100;

                default:
                    return 0b0000_0000;
            }
        }
    }
}
