using Ecommerce.Produto.Domain.Entities;

namespace Ecommerce.Produto.Domain.Interfaces
{
    public interface IBrinquedoRepository
    {
        IEnumerable<BrinquedoEntity> ObterTodos();  
        BrinquedoEntity? ObterPorId(int id);  
        BrinquedoEntity? SalverDados(BrinquedoEntity entity);  
        BrinquedoEntity? EditarDados(BrinquedoEntity entity);  
        BrinquedoEntity? DeletarDados(int id);  
    }
}