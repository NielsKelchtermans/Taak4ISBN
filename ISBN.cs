using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Taak4ISBN
{
    public class ISBN
    {
        //property Isbn
        private string iSBNummerValue;
        private static readonly Regex regex = new Regex("^\\d{13}$");
        public string ISBNummer
        {
            get { return iSBNummerValue; }
            set
            {
                //throw new NotImplementedException(); 
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
               
                if (!regex.IsMatch(value))
                {
                    throw new ArgumentException();
                }

                var totaalOneven = int.Parse(value[0].ToString());
                var totaalEven = 0;

                for (int i = 1; i < value.Length-1; i++)
                {
                    
                    if (i%2==0)
                    {
                        totaalOneven += int.Parse(value[i].ToString());
                    }
                    else
                    {
                        totaalEven += int.Parse(value[i].ToString());
                    }
                }
                totaalEven *= 3;
                var totaalEvenOneven = totaalEven + totaalOneven;
                var tiental = totaalEvenOneven +1;
                
                while (!(tiental%10==0))
                {
                    tiental += 1;
                }
                var verschil = tiental - totaalEvenOneven;

                if (verschil==10)
                {
                    verschil = 0;
                }
                if (verschil==int.Parse(value[12].ToString()))
                {
                    iSBNummerValue = value;
                }
                else
                {
                    throw new ArgumentException();
                }

            }
        }

        //override method
        public override string ToString()
        {
            return ISBNummer;
        }

    }
}
