using Cartesiano.Enumerador;
using Cartesiano.Model;
using Cartesiano.Objetos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cartesiano
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartesianoController
    {
        public coordenada ObterCoordenada(Coordenada Coor)
        {

            coordenada coordenada = new coordenada
            {
                CoordenadaX = int.Parse(Coor.coordenadaInicial.Split(',')[0]),
                CoordenadaY = int.Parse(Coor.coordenadaInicial.Split(',')[1]),
                Criterios = Coor.movimentacoesCoordenadas
            };

            return coordenada;

        }

        public string RealizarMovimentacoes(coordenada coordenada)
        {
            List<Modelo> lista = new List<Modelo>();
            Modelo modelo;
            String[] vetorCoordenadas = coordenada.Criterios.Split(';');

            foreach (string modelos in vetorCoordenadas)
            {
                string[] dadosModelo = modelos.Split(',');

                modelo = new Modelo
                {
                    Direacao = char.Parse(dadosModelo[0].ToUpper()),
                    Intensidade = int.Parse(dadosModelo[1])
                };
                lista.Add(modelo);

            }

            foreach (Modelo mode in lista)
            {

                EnumDirecao retorno = (EnumDirecao)Enum.ToObject(typeof(EnumDirecao), mode.Direacao);
                Type type = Type.GetType("Cartesiano." + retorno.ToString());
                IDirecao objeto = (IDirecao)Activator.CreateInstance(type);
                objeto.Add(coordenada, mode);
                coordenada = objeto.GetRetorno();


            }
            return coordenada.CoordenadaX.ToString() +"," + coordenada.CoordenadaY.ToString();
        }
        [HttpPost]
        public string Executa([FromBody]Coordenada coordenada)
        {

            return RealizarMovimentacoes(ObterCoordenada(coordenada));
        }

    }
}
