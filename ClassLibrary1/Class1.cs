using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Sums
    {
        public double add(double _magicNumber, double _amount)
    {
        addedNumber = _magicNumber + _amount;

        return addedNumber;
    }
        public double subtract(double _magicNumber,double _amount)
        {
            subtractedNumber = _magicNumber - _amount;
            return subtractedNumber;
        }
        public double multiply(double _magicNumber,double _amount)
        {
            multipliedNumber = _magicNumber * _amount;
            return multipliedNumber;
        }
        public double divide(double _magicNumber,double _amount)
        {
            dividedNumber = _magicNumber / _amount;

            return dividedNumber;
        }


        public double addedNumber { get; set; }

        public double subtractedNumber { get; set; }

        public double multipliedNumber { get; set; }
    
public  double dividedNumber { get; set; }

    }
}
