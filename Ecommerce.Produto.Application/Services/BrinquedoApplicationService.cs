using Ecommerce.Produto.Domain.Entities;
using Ecommerce.Produto.Domain.Interfaces;

namespace Ecommerce.Produto.Application.Services
{
    public class BrinquedoApplicationService : IBrinquedoApplicationService
    {
        private readonly IBrinquedoRepository _brinquedoRepository;

        public BrinquedoApplicationService(IBrinquedoRepository brinquedoRepository)
        {
            _brinquedoRepository = brinquedoRepository;
        }

        public BrinquedoEntity? DeletarDadosBrinquedo(int id)
        {
            return _brinquedoRepository.DeletarDados(id);
        }

        public BrinquedoEntity? EditarDadosBrinquedo(BrinquedoEntity entity)
        {
            return _brinquedoRepository.EditarDados(entity);
        }

        public BrinquedoEntity? ObterBrinquedosPorId(int id)
        {
            return _brinquedoRepository.ObterPorId(id);
        }

        public IEnumerable<BrinquedoEntity> ObterTodasBrinquedos()
        {
            return _brinquedoRepository.ObterTodos();
        }

        public BrinquedoEntity? SalverDadosBrinquedo(BrinquedoEntity entity)
        {
            return _brinquedoRepository.SalverDados(entity);
        }
    }
}
