using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Core
    {



        public List<double> Numbers = new List<double>();

        public double Current { get; set; }
        public double Result { get; set; }
        public double y { get; set; }
        public double z { get; set; }
        public int Action { get; set; }


        public void Add()
        {
            Numbers.Add(Current);
            Action = 1;

        }
        public void substract()
        {
            Numbers.Add(Current);
            Action = 2;
        }
        public void divide()
        {
            Numbers.Add(Current);

            Action = 3;
        }

        public void multiply()
        {
            Numbers.Add(Current);
            Action = 4;
        }
        public double equals()
        {

            Numbers.Add(Current);
            y = Numbers[Numbers.Count - 1];
            z = Numbers[Numbers.Count - 2];
            switch (Action)
            {
                case 1:
                    Result = y + z;
                    break;
                case 2:
                    Result = z - y;
                    break;
                case 3:
                    Result = z / y;
                    break;
                case 4:
                    Result = z * y;
                    break;
            }
            return Result;


        }

    }
}
