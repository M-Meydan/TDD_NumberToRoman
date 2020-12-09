using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TDD_NumberToRoman.Converters
{
    public class RomanToNumberConverter
    {
        IList<string> _charList;
        public RomanToNumberConverter(string romanNumber)
        {
            _charList = romanNumber.Select(x => x.ToString()).ToList();
        }

        public int Convert()
        {
            int? previousValue = null;
            string currentChar = string.Empty;
            bool runWhile = true;

            var resultStack = new Stack();

            for (int i = 0; i < _charList.Count; i++)
            {
                currentChar = _charList[i];

                while (runWhile)
                {
                    if (TryGetNumberValue(currentChar, out int numberValue)) //number is valid I => 1
                    {
                        var nextRomanChar = GetNextChar(i++); // increment to next get char
                        currentChar = string.Concat(currentChar, nextRomanChar);

                        if (nextRomanChar != null) // next char available
                        {
                            previousValue = numberValue;
                            continue;
                        }
                        else // no next char available
                        {
                            resultStack.Push(numberValue);
                            return GetResultNumber(resultStack);
                        }
                    }

                    if (previousValue.HasValue)
                    {
                        resultStack.Push(previousValue.Value);
                        i--; // back to previous char
                    }

                    break;
                }
            }

            return GetResultNumber(resultStack);
        }

        private string GetNextChar(int i)
        {
            var nextIdx = i + 1;
            return (nextIdx < _charList.Count) ? _charList[nextIdx] : null;
        }

        bool TryGetNumberValue(string strRomanValue, out int matchedNumber)
        {
            if (strRomanValue == null)
            {
                matchedNumber = 0;
                return false;
            }

            return (Mappings.RomanToNumber.TryGetValue(strRomanValue, out matchedNumber));
        }

        private int GetResultNumber(Stack resultStack)
        {
            int result = 0;

            foreach (int number in resultStack)
                result += number;

            return result;
        }

    }
}