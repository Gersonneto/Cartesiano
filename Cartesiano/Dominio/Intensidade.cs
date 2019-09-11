using System;
using System.Collections.Generic;
using System.Text;

namespace Cartesiano
{
  public abstract  class Intensidade
    {
        public Intensidade()
        {
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public virtual int Soma(int intensidade,int coordenada)
        {
            return coordenada + intensidade;
        }


        public virtual int Subtrair(int intensidade ,int coordenada)
        {
            return coordenada - intensidade ;
        }
       

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
