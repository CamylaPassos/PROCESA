using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROCESA
{
    public class Cartorio
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cod { get; set; }
        [MaxLength(30), Required]
        public string Cidade { get; set; }
        [MaxLength(60), Required]
        public string Contato { get; set; }
        [MaxLength(70), Required]
        public string Telefone { get; set; }
        [MaxLength(100), Required]
        public string Observacao { get; set; }
       
    }
}
