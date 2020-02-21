using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodDemo.Modelos;

namespace FactoryMethodDemo.Creador
{
    public class ConstructorCirculo : Constructor
    {
        private double _radio;

        public ConstructorCirculo(double radio)
        {
            _radio = radio;
        }
        public override IFiguraGeometrica CrearFiguraGeometrica()
        {
            return new Circulo(_radio);
        }
    }
}
