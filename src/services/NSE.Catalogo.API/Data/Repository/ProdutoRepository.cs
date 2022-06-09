using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NSE.Catalogo.API.Models;
using NSE.Core.Data;

namespace NSE.Catalogo.API.Data.Repository
{
    public class ProdutoRepository: IProdutoRepository
    {
        private readonly CatalogoContext _context;
        private readonly CatalogoContextNovo _catalogoContextNovo;

        public ProdutoRepository(CatalogoContext context, CatalogoContextNovo catalogoContextNovo)
        {
            _context = context;
            _catalogoContextNovo = catalogoContextNovo;
        } 
        public IUnitOfWork UnitOfWork => _context;
        public async Task<Produto> ObterPorId(Guid id)
        {
            return await _context.Produtos.FindAsync(id);
        }
        public async  Task<IEnumerable<Produto>> ObterTodos()
        {
            var contexto =  await _context.Produtos.AsNoTracking().ToListAsync();
            var contextoNovo = await _catalogoContextNovo.Produtos.AsNoTracking().ToArrayAsync();

            return contexto;

        }
        
        public void Adicionar(Produto produto)
        {
            _context.Produtos.Add(produto);
        }

        public void Atualizar(Produto produto)
        {
            _context.Produtos.Update(produto);
        }
        public void Dispose()
        {
            _context?.Dispose();

        }

    }
}
