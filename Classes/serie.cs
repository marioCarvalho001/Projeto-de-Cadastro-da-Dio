using System;

namespace DIO.series
{
    public class serie : EntidadeBase
    {
            //Atributos
        private Genero Genero { get; set; }

        private string Titulo { get; set; }

        private string descricao { get; set; }

        private int Ano { get; set; }
        
        private bool excluido { get; set; } 

        //Métodos
        
        public serie (int id, Genero Genero, string titulo, string descricao, int ano)
        {
            this.id = id;
            this.Genero = Genero;
            this.Titulo = Titulo;
            this.Ano = ano;
            this.excluido = false;
        }

        internal void Excluir()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
            retorno += "Excluido: " + this.excluido;
			return retorno;
		}

         public string retornaTitulo()
		{
			return this.Titulo;
		}

		public int retornaId()
		{
			return this.id;
		}

        public bool retornaExcluido()
		{
			return this.excluido;
		}
        public void excluir() {
            this.excluido = true;

        }
    }
}
