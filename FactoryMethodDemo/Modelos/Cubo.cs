using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDemo.Modelos
{
    public class Cubo : IFiguraGeometrica
    {
        private double _lado;

        public Cubo(double lado)
        {
            _lado = lado;
        }
        public double CalcularArea()
        {
            return 6*(_lado*_lado);
        }

        public double CalcularPerimetro()
        {
            return 12*_lado;
        }

        public double CalcularVolumen()
        {
            return _lado * _lado * _lado;
        }
    }
}
