using FactoryMethodDemo.Modelos;

namespace FactoryMethodDemo.Creador
{
    public abstract class Constructor
    {
        public abstract IFiguraGeometrica CrearFiguraGeometrica();
    }
}