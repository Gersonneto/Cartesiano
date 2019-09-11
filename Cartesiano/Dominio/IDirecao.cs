using Cartesiano.Objetos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cartesiano
{
   public interface IDirecao
    {
         Objetos.coordenada GetRetorno();
        void Add(coordenada coordenada, Modelo modelo);
    }
}
