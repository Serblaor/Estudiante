using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculoApp
{
    internal class Circulo
    {
        private double radio;

        public double Radio
        {
            get { return radio; }
            set { radio = value; }
        }

        public double Area
        {
            get { return Math.PI * radio * radio; }
        }

        public double Perimetro
        {
            get { return 2 * Math.PI * radio; }
        }
    }
}
