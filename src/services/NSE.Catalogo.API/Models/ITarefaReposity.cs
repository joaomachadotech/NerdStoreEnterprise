using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using NSE.Core.Data;

namespace NSE.Catalogo.API.Models
{
    public interface ITarefasReposity : IRepository<Tarefas>
    {
        Task<IEnumerable<Tarefas>> ObterTodos();
        Task<Tarefas> ObterPorId(Guid id);
        void Adicionar(Produto produto);
        void Atualizar(Produto produto);
    }
}