using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodDemo.Modelos;

namespace FactoryMethodDemo.Creador
{
    public class ConstructorCuadrados : Constructor
    {
        private double _lado;

        public ConstructorCuadrados(double lado)
        {
            _lado = lado;
        }
        public override IFiguraGeometrica CrearFiguraGeometrica()
        {
            return new Cuadrado(_lado);
        }
    }
}
