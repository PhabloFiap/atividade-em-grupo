using Ecommerce.Produto.Domain.Entities;

namespace Ecommerce.Produto.Domain.Interfaces
{
    public interface IBrinquedoApplicationService
    {
        IEnumerable<BrinquedoEntity> ObterTodasBrinquedos();
        BrinquedoEntity? ObterBrinquedosPorId(int id);
        BrinquedoEntity? SalverDadosBrinquedo(BrinquedoEntity entity);
        BrinquedoEntity? EditarDadosBrinquedo(BrinquedoEntity entity);
        BrinquedoEntity? DeletarDadosBrinquedo(int id);
    }
}