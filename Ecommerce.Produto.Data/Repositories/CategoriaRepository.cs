using Ecommerce.Produto.Data.AppData;
using Ecommerce.Produto.Domain.Entities;
using Ecommerce.Produto.Domain.Interfaces;

namespace Ecommerce.Produto.Data.Repositories
{
    public class BrinquedoRepository : IBrinquedoRepository
    {
        private readonly ApplicationContext _context;

        public BrinquedoRepository(ApplicationContext context)
        {
            _context = context;
        }

        public BrinquedoEntity? DeletarDados(int id)
        {
            var brinquedo = _context.Brinquedo.Find(id);

            if(brinquedo is not null)
            {
                _context.Brinquedo.Remove(brinquedo);
                _context.SaveChanges();

                return brinquedo;
            }

            return null;
        }

        public BrinquedoEntity? EditarDados(BrinquedoEntity entity)
        {
            var brinquedo = _context.Brinquedo.Find(entity.Id);

            if (brinquedo is not null)
            {

                brinquedo.Nome = entity.Nome;
                brinquedo.Descricao = entity.Descricao;

                _context.Brinquedo.Update(brinquedo);
                _context.SaveChanges();

                return brinquedo;
            }

            return null;
        }

        public BrinquedoEntity? ObterPorId(int id)
        {
            var brinquedo = _context.Brinquedo.Find(id);

            if (brinquedo is not null)
            {
                return brinquedo;
            }

            return null;
        }

        public IEnumerable<BrinquedoEntity> ObterTodos()
        {
            var brinquedo = _context.Brinquedo.ToList();

            return brinquedo;
        }

        public BrinquedoEntity? SalverDados(BrinquedoEntity entity)
        {
            _context.Brinquedo.Add(entity);
            _context.SaveChanges();

            return entity;
        }
    }
}
