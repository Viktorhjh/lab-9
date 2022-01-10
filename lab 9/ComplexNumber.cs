using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{
    public class ComplexNumber
    {
        double complexNumber;
        double number;

        public ComplexNumber(double n, double complexN)
        {
            number = n;
            complexNumber = complexN;
        }

        public double getNumber()
        {
            return number;
        }

        public double getComplexNumber()
        {
            return complexNumber;
        }

        public static ComplexNumber operator + (ComplexNumber n1, ComplexNumber n2)
        {
            ComplexNumber sum = new ComplexNumber(n1.number + n2.number, n1.complexNumber + n2.complexNumber);
            return sum;
        }

        public static ComplexNumber operator -(ComplexNumber n1, ComplexNumber n2)
        {
            ComplexNumber sum = new ComplexNumber(n1.number - n2.number, n1.complexNumber - n2.complexNumber);
            return sum;
        }

        public static ComplexNumber operator *(ComplexNumber n1, ComplexNumber n2)
        {
            ComplexNumber sum = new ComplexNumber(n1.number*n2.number - n1.complexNumber*n2.complexNumber,
                n1.complexNumber*n2.number + n2.complexNumber*n1.number);
            return sum;
        }

        public static ComplexNumber operator /(ComplexNumber n1, ComplexNumber n2)
        {
            ComplexNumber sum = new ComplexNumber(
                (n1.number * -1 * n2.number - n1.complexNumber * n2.complexNumber)
                /(-1*(n2.number * n2.number + n2.complexNumber * n2.complexNumber)),
                (n2.number * n1.complexNumber - n1.number * n2.complexNumber)
                /((n2.number * n2.number + n2.complexNumber * n2.complexNumber))
                );            
            return sum;
        }

        public static bool operator ==(ComplexNumber n1, ComplexNumber n2)
        {
            if (n1.number == n2.number && n1.complexNumber == n2.complexNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator !=(ComplexNumber n1, ComplexNumber n2)
        {
            if (n1.number == n2.number && n1.complexNumber == n2.complexNumber)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool operator >(ComplexNumber n1, ComplexNumber n2)
        {
            if (n1 != n2 && n1.number >= n2.number && n1.complexNumber >= n2.complexNumber)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator <(ComplexNumber n1, ComplexNumber n2)
        {
            if (n1.number >= n2.number && n1.complexNumber >= n2.complexNumber)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public static implicit operator ComplexNumber(double res)
        {
            return new ComplexNumber(res, 0);
        }

        public static implicit operator double(ComplexNumber res)
        {
            return res.number;
        }

    }
}