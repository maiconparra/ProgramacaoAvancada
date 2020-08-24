using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace AreaFormasGeometricas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<FormaGeometrica> formasGeometricas = new List<FormaGeometrica>();

            formasGeometricas.Add(new Triangulo(10.0, 10.0, 5));
            formasGeometricas.Add(new Quadradro(10.0, 5));
            formasGeometricas.Add(new Retangulo(10.0, 80.0, 5));

            foreach (FormaGeometrica formaGeometrica in formasGeometricas)
            {
                Console.WriteLine($"A area do {formaGeometrica.GetNome()} é igual a {formaGeometrica.GetArea()}" +
                    $"e o volume é igual a {formaGeometrica.GetVolume()}");
            }
        }
    }
}
