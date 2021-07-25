﻿using System;
using System.Collections.Generic;
using DIO.SERIES.Interfaces;

namespace DIO.SERIES
{
    public class SerieRepositorio : IRepositorio<Serie>
    {
        private List<Serie> listaSerie = new List<Serie>();
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] =  objeto;
            throw new NotImplementedException();
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RertonarPorId(int id)
        {
           return listaSerie[id];
        }

        internal void Exclui(object indiceSerie)
        {
            throw new NotImplementedException();
        }
    }
}