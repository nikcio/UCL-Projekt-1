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

}

