using System;
using System.Collections.Generic;
using System.Text;
using Cartesiano.Objetos;

namespace Cartesiano
{
    public class Leste : Intensidade,IDirecao
    {
        coordenada coordenada = new coordenada();
        public Leste()
        {
            Console.WriteLine("Sou do Leste");
        }

        public void Add(coordenada coordenada, Modelo modelo)
        {
            this.coordenada = coordenada;
            this.coordenada.CoordenadaX = this.Soma(modelo.Intensidade,coordenada.CoordenadaX);
        }

        public coordenada GetRetorno()
        {
            return this.coordenada;
        }

        

       
    }
}
