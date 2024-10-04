using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ecommerce.Produto.Domain.Entities
{
    [Table("tb_prod_brinquedo")]
    public class BrinquedoEntity
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;

        public int preco { get; set; }
        public int idadeMinima { get; set; }
        

    }
}
