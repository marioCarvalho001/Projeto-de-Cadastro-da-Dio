using System;
using System.Collections.Generic;
using DIO.series.interfaces;


namespace DIO.series.Classes
{
    public class serieRepositorio : IRepositorio<serie>
    {
        public List<serie> listaSerie = new List<serie>();
		public void Atualiza(int id, serie objeto)
		{
			listaSerie[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaSerie[id].excluir();
		}

		public void Insere(serie objeto)
		{
			listaSerie.Add(objeto);
		}

		public List<serie> Lista()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

		public serie RetornaPorId(int id)
		{
			return listaSerie[id];
		}
    }
}