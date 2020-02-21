using FactoryMethodDemo.Modelos;

namespace FactoryMethodDemo.Creador
{
    public class ConstructorCubo : Constructor
    {
        private double _lado;

        public ConstructorCubo(double lado)
        {
            _lado = lado;
        }
        public override IFiguraGeometrica CrearFiguraGeometrica()
        {
            return new Cubo(_lado);
        }
    }
}