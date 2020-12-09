using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace TDD_NumberToRoman.Converters
{
    public class NumberToRomanConverter
    {
        int _number;

        int _ones => _number % 10;
        int _tens => ((_number % 100) - _ones);
        int _hundreds => ((_number % 1000) - (_tens + _ones));
        int _thousands => ((_number % 10000) - (_hundreds + _tens + _ones));

        int _tenThousands => ((_number % 100000) - (_thousands + _hundreds + _tens + _ones));

        public NumberToRomanConverter(int number) { _number = number; }

        public string Convert()
        {
            var stack = new Stack();

            // e.g number 11
            // mod by hundred gives:11 , divide by 10 gives:1, multiply by 10 to make it base 10
            if (_ones > 0) stack.Push(Mappings.NumberToRoman[_ones]);
            if (_tens > 0) stack.Push(Mappings.NumberToRoman[_tens]);
            if (_hundreds > 0) stack.Push(Mappings.NumberToRoman[_hundreds]);
            if (_thousands > 0) stack.Push(string.Concat(Enumerable.Repeat(Mappings.NumberToRoman[1000], _thousands / 1000)));
            if (_tenThousands > 0) stack.Push(string.Concat(Enumerable.Repeat(Mappings.NumberToRoman[1000], _tenThousands / 1000)));

            var result = string.Concat(stack.ToArray());
            return result;
        }
    }
}

#region looping base 10 example
            //long x = 99999;
            //long i = 10;

            //while (x > i / 10)
            //{
            //    Debug.WriteLine(x % i - x % (i / 10));
            //    i *= 10;
            //}
            #endregion