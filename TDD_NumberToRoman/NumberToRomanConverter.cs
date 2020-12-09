using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TDD_NumberToRoman.Converters;

namespace TDD_NumberToRoman
{
    public class NumberConverter
    {
        int _number;
        int _ones => _number % 10;
        int _tens => ((_number % 100) - _ones);
        int _hundreds => ((_number % 1000) - (_tens + _ones));
        int _thousands => ((_number % 10000) - (_hundreds + _tens + _ones));

        int _tenThousands => ((_number % 100000) - (_thousands + _hundreds + _tens + _ones));

        Dictionary<int, string> RomanNumbers = new Dictionary<int, string>{
         /*Ones*/        {1,"I"},{2,"II"},{3,"III"},{4,"IV"},{5,"V"},{6,"VI"},{7,"VII"},{8,"VIII"},{9,"IX"},
         /*Tens*/        {10,"X"},{20,"XX"},{30,"XXX"},{40,"XL"},{50,"L"},{60,"LX"},{70,"LXX"},{80,"LXXX"},{90,"XC"},
         /*Hundreds*/    {100,"C"},{200,"CC"},{300,"CCC"},{400,"CD"},{500,"D"},{600,"DC"},{700,"DCC"},{800,"DCC"},{900,"CM"},
         /*Thousands*/   {1000,"M" }
        };

        public NumberConverter(int number) { 
            _number = number;
            _numberMappings = new NumberMappings({ 1, "I" });
        }

        public string ToRoman()
        {
            var stack = new Stack();

            #region looping base 10 example
            //long x = 99999;
            //long i = 10;

            //while (x > i / 10)
            //{
            //    Debug.WriteLine(x % i - x % (i / 10));
            //    i *= 10;
            //}
            #endregion

            // e.g number 11
            // mod by hundred gives:11 , divide by 10 gives:1, multiply by 10 to make it base 10
            if (_ones > 0) stack.Push(RomanNumbers[_ones]);
            if (_tens > 0) stack.Push(RomanNumbers[_tens]);
            if (_hundreds > 0) stack.Push(RomanNumbers[_hundreds]);
            if (_thousands > 0) stack.Push(string.Concat(Enumerable.Repeat(RomanNumbers[1000], _thousands / 1000)));
            if (_tenThousands > 0) stack.Push(string.Concat(Enumerable.Repeat(RomanNumbers[1000], _tenThousands / 1000)));

            var result = string.Concat(stack.ToArray()); 
            return result;
        }
    }
}