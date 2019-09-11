using System;
using System.Collections.Generic;
using System.Text;
using Cartesiano.Model;
using Cartesiano.Objetos;

namespace Cartesiano
{
    public class Norte : Intensidade,IDirecao
    {

        private coordenada coordenada;
        
        public Norte()
        {
            Console.WriteLine("Estou no norte");
        }

        public object retorno()
        {
            return this.coordenada;
        }

       
        public coordenada GetRetorno()
        {
            
            return coordenada;
        }

        public void Add(coordenada coordenada, Modelo modelo)
        {
            this.coordenada = coordenada;
            this.coordenada.CoordenadaY = this.Soma(modelo.Intensidade, coordenada.CoordenadaY);
        }
    }
}
