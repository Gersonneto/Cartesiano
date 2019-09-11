using System;
using System.Collections.Generic;
using System.Text;
using Cartesiano.Objetos;

namespace Cartesiano
{
    public class Oeste : Intensidade,IDirecao
    {
        coordenada coordenada = new coordenada();
        public Oeste()
        {
            Console.WriteLine("Estou no Oeste");
        }

        public void Add(coordenada coordenada, Modelo modelo)
        {
            this.coordenada = coordenada;
            this.coordenada.CoordenadaX = this.Subtrair(modelo.Intensidade,coordenada.CoordenadaX);
        }

        public coordenada GetRetorno()
        {
            return this.coordenada;
        }

        
    }
}
