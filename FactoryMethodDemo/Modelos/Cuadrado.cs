using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDemo.Modelos
{
    public class Cuadrado : IFiguraGeometrica
    {
        private double _lado;

        public Cuadrado(double lado)
        {
            _lado = lado;
        }
        public double CalcularArea()
        {
            return _lado * _lado;
        }

        public double CalcularPerimetro()
        {
            return _lado * 4;
        }

        public double CalcularVolumen()
        {
            return 0;
        }
    }
}
