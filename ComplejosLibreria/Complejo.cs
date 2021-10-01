using System;

namespace ComplejosLibreria
{
    public class Complejo
    {
        private float real;
        private float imaginaria;

        public Complejo(float real, float imaginaria)
        {
            this.real = real;
            this.imaginaria = imaginaria;
        }

        public static Complejo operator +(Complejo c1, Complejo c2  )
        {
            Complejo c3 = new Complejo(c1.real +c2.real , c1.imaginaria + c2.imaginaria);
            return c3;
        }

        public static Complejo operator ~(Complejo c1 )
        {
            c1.imaginaria = -c1.imaginaria;
            return c1;
        }


        public override string ToString()
        {
            return  real.ToString() + " + " +imaginaria.ToString() + "i";
        }


    }
}
