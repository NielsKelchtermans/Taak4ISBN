using System;
using System.Linq;
using System.Collections.Generic;

namespace Taak4ISBN
{
    public class ISBN
    {
        //property Isbn
        private string iSBNummerValue;

        public string ISBNummer
        {
            get { return iSBNummerValue; }
            set
            {
                throw new NotImplementedException(); 
                /*if (value == null)
                {
                    throw new ArgumentNullException();
                }
                if (value.Length != 13)
                {
                    throw new ArgumentException();
                }
                for (int i = 1; i < value.Length; i++)
                {
                    var totaalOneven = int.Parse(value[0].ToString());
                    var totaalEven = 0;
                    if (i%2==0)
                    {
                        totaalOneven += int.Parse(value[i].ToString());
                    }
                }*/
            }
        }

        //override method
        public override string ToString()
        {
            throw new NotImplementedException();
        }

    }
}
