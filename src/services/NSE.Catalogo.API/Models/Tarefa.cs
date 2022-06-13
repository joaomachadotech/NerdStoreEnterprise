using System;
using NSE.Core.DomainObjects;

namespace NSE.Catalogo.API.Models
{
    public class Tarefas : Entity,IAggregateRoot
    {
        public string TarefaId { get; set; }

        public string UsuarioId { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }
        public string Prova { get; set; }

        public string Imagem { get; set; }

        public string UploadImagem { get; set; }

        public DateTime DataCadastro { get; set; }

        public bool Ativo { get; set; }
    }
}
