using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UCL_Projekt_1
{
    class Converter
    {
        public static int RomerTalConverter(string number)
        {
            number = number.ToUpper();
            var result = 0;

            foreach (var Bogstav in number)
            {
                result += ConvertBogstavToTal(Bogstav);
            }

            if (number.Contains("IV") || number.Contains("IX"))
                result -= 2;

            if (number.Contains("XL") || number.Contains("XC"))
                result -= 20;

            if (number.Contains("CD") || number.Contains("CM"))
                result -= 200;
            return result;
        }

        private static int ConvertBogstavToTal(char Romertal)
        {
            switch (Romertal)
            {
                case 'M':
                    {
                        return 1000;
                    }

                case 'D':
                    {
                        return 500;
                    }

                case 'C':
                    {
                        return 100;
                    }

                case 'L':
                    {
                        return 50;
                    }

                case 'X':
                    {
                        return 10;
                    }

                case 'V':
                    {
                        return 5;
                    }

                case 'I':
                    {
                        return 1;
                    }

                default:
                    {
                        throw new ArgumentException("Ugyldigt bogstav");
                    }
            }
        }
    }
    class TilRomerTal
    {
        string s = "";

        public string TilRomer(int number)
        {

            if ((number < 0) || (number > 3999))
            {
                s = s + "Ugyldigt imput";
            }
            if (number < 1) return s;
            if (number >= 1000) { s = s + "M"; TilRomer(number - 1000); }
            if (number >= 900) { s = s + "CM"; TilRomer(number - 900); }
            if (number >= 500) { s = s + "D"; TilRomer(number - 500); }
            if (number >= 400) { s = s + "CD"; TilRomer(number - 400); }
            if (number >= 100) { s = s + "C"; TilRomer(number - 100); }
            if (number >= 90) { s = s + "XC"; TilRomer(number - 90); }
            if (number >= 50) { s = s + "L"; TilRomer(number - 50); }
            if (number >= 40) { s = s + "XL"; TilRomer(number - 40); }
            if (number >= 10) { s = s + "X"; TilRomer(number - 10); }
            if (number >= 9) { s = s + "IX"; TilRomer(number - 9); }
            if (number >= 5) { s = s + "V"; TilRomer(number - 5); }
            if (number >= 4) { s = s + "IV"; TilRomer(number - 4); }
            if (number >= 1) { s = s + "I"; TilRomer(number - 1); }
            return s;
        }
    }

}

