using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;

namespace AreaFormasGeometricas
{
    public abstract class FormaGeometrica
    {
        public FormaGeometrica(string _nome, double _profundidade)
        {
            this.Nome = _nome;
            this.Profundidade = _profundidade;
        }

        public string Nome { get; set; }
        public double Profundidade { get; set; }
        public abstract double GetArea();
        //public abstract double getVolume();
        public double GetVolume()
        {
            double areaFormaGeometrica = GetArea();
            double volume = areaFormaGeometrica * Profundidade;

            return volume;
        }
        public string GetNome()
        {
            return Nome;
        }
    }

    public class Triangulo : FormaGeometrica
    {
        public Triangulo(double _base, double _altura, double _profundidade) : base("Triangulo", _profundidade)
        {            
            this.Base = _base;
            this.Altura = _altura;
        }
        public double Base { get; private set; }
        public double Altura { get; private set; }        

        public override double GetArea()
        {
            double areaTrinagulo = (this.Base * Altura) / 2;
            return areaTrinagulo;
        }                
    }

    public class Quadradro : FormaGeometrica
    {
        public Quadradro(double _lado, double _profundidade) : base("Quadrado", _profundidade)
        {
            this.Lado = _lado;
        }
        public double Lado { get; private set; }

        public override double GetArea()
        {
            double areaQuadrado = this.Lado * this.Lado;
            return areaQuadrado;
        }    
    }

    public class Retangulo : FormaGeometrica
    {
        public Retangulo(double _base, double _altura, double _profundidade) : base("Retangulo", _profundidade)
        {
            this.Base = _base;
            this.Altura = _altura;
        }
        public double Base { get; private set; }
        public double Altura { get; private set; }

        public override double GetArea()
        {
            double areaRetangulo = this.Base * this.Altura;
            return areaRetangulo;
        }
    }
}
