using System;

namespace UCL_Projekt_1
{
    /// <summary>
    /// Konvertere romertal
    /// </summary>
    internal class RomertalKonvertering
    {
        /// <summary>
        /// Kovertere en string til et romertal
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static int RomerTalConverter(string number)
        {
            number = number.ToUpper();
            int result = 0;

            foreach (char Bogstav in number)
            {
                result += ConvertBogstavToTal(Bogstav);
            }

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

    /// <summary>
    /// Kovertere til romertal
    /// </summary>
    internal class TilRomerTal
    {
        /// <summary>
        /// Kovertere tal til romertal
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string TilRomer(int number)
        {
            string s = "";

            if ((number < 0) || (number > 3999))
            {
                s = s + "Ugyldigt imput";
            }
            while(number > 0)
            {
                if (number >= 1000)
                { 
                    s = s + "M";
                    number -= 1000;
                }
                else if (number >= 900)
                { 
                    s = s + "CM";
                    number -= 900;
                }
                else if (number >= 500)
                { 
                    s = s + "D";
                    number -= 500; 
                }
                else if (number >= 400)
                { 
                    s = s + "CD";
                    number -= 400; 
                }
                else if (number >= 100)
                { 
                    s = s + "C";
                    number -= 100; 
                }
                else if (number >= 90)
                { 
                    s = s + "XC";
                    number -= 90;
                }
                else if (number >= 50)
                { 
                    s = s + "L";
                    number -= 50;
                }
                else if (number >= 40)
                { 
                    s = s + "XL";
                    number -= 40;
                }
                else if (number >= 10)
                { 
                    s = s + "X";
                    number -= 10;
                }
                else if (number >= 9)
                { 
                    s = s + "IX";
                    number -= 9;
                }
                else if (number >= 5)
                { 
                    s = s + "V";
                    number -= 5;
                }
                else if (number >= 4)
                { 
                    s = s + "IV";
                    number -= 4;
                }
                else if (number >= 0)
                { 
                    s = s + "I";
                    number -= 1;
                }
            }
            return s;

            
        }
    }

}

