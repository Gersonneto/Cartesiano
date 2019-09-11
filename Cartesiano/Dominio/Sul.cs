using System;
using System.Collections.Generic;
using System.Text;
using Cartesiano.Objetos;

namespace Cartesiano
{
    public class Sul : Intensidade,IDirecao
    {
        coordenada coordenada = new coordenada();
        public Sul()
        {
            Console.WriteLine("Estou no sul");
        }
       

        public coordenada GetRetorno()
        {
            return this.coordenada;
        }

        public void Add(coordenada coordenada, Modelo modelo)
        {
                this.coordenada = coordenada;
                this.coordenada.CoordenadaY = this.Subtrair(modelo.Intensidade, coordenada.CoordenadaY);
           
        }
    }
}
