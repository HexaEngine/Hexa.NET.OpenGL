namespace Generator
{
    using System;

    public static class TextHelper
    {
        public static unsafe string CapitalizeCopy(this string input)
        {
            string result = new(input);

            fixed (char* pOut = result)
            {
                *pOut = char.ToUpper(*pOut);
            }

            return result;
        }
    }
}