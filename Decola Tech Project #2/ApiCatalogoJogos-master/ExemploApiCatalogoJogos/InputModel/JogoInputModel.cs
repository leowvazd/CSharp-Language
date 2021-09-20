using System.ComponentModel.DataAnnotations;

namespace ExemploApiCatalogoJogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome do jogo deve conter entre 3 e 100 caracteres")]
        public string Nome { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 1, ErrorMessage = "O nome da produtora deve conter entre 3 e 100 caracteres")]
        public string Produtora { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "O preço deve ser de no mínimo 1 real e no máximo 1000 reais")]
        public double Preco { get; set; }

        [Required]
        [Range(1, 3000, ErrorMessage = "O ano deve ser de no mínimo 1 e no máximo 3000")]
        public int Ano { get; set; }

        [Required]
        [Range(1, 10000, ErrorMessage = "O número de vendas deve ser de no mínimo 1 e no máximo 10000")]
        public int Vendas { get; set; }
    }
}
