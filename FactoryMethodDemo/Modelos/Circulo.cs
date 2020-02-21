using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDemo.Modelos
{
    public class Circulo : IFiguraGeometrica
    {
        private double _radio;
        private const double pi = 3.1416;

        public Circulo(double radio)
        {
            _radio = radio;
        }
        public double CalcularPerimetro()
        {
            return 2 * _radio * pi;
        }

        public double CalcularArea()
        {
            return _radio * _radio * pi;
        }

        public double CalcularVolumen()
        {
            return 0;
        }
    }
}
