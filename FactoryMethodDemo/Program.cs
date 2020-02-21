using System;
using System.Threading.Channels;
using FactoryMethodDemo.Creador;
using FactoryMethodDemo.Modelos;

namespace FactoryMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultado = Menu();

            if (resultado == -1)
            {
                Console.WriteLine("Error: Opcion no valida");
                return;
            }

            Constructor figura = null;

            Figuras respuesta = (Figuras) resultado;
            double valor = 0;

            switch (respuesta)
            {
                case Figuras.Cuadrado:
                    Console.WriteLine("Lado:");
                    valor = Convert.ToDouble(Console.ReadLine());
                    figura = new ConstructorCuadrados(valor);
                    break;
                case Figuras.Circulo:
                    Console.WriteLine("Radio:");
                    valor = Convert.ToDouble(Console.ReadLine());
                    figura = new ConstructorCirculo(valor);
                    break;
                case Figuras.Cubo:
                    Console.WriteLine("Lado:");
                    valor = Convert.ToDouble(Console.ReadLine());
                    figura = new ConstructorCubo(valor);
                    break;
            }

            //46465465

            var figuraconstruida = figura.CrearFiguraGeometrica();
            Console.WriteLine($"Perimetro: {figuraconstruida.CalcularPerimetro()}");
            Console.WriteLine($"Area: {figuraconstruida.CalcularArea()}");
            Console.WriteLine($"Volumen: {figuraconstruida.CalcularVolumen()}");

        }


        public static int Menu()
        {
            Console.Clear();
            Console.WriteLine("Selecciona una figura:");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Circulo");
            Console.WriteLine("3. Cubo");

            var x = Console.ReadLine();

            try
            {
                var numero = int.Parse(x);

                if (numero >= 1 && numero <= 3)
                    return numero;

                return -1;
            }
            catch
            {
                return -1;
            }
        }

    }
}
