using System.ComponentModel.DataAnnotations;

namespace CategoriasMvc.Models;

public class ProdutoViewModel
{
    public int ProdutoId { get; set; }

    [Required(ErrorMessage = "O nome do produto e obrigatorio")]
    public string? Nome { get; set; }

    [Required(ErrorMessage = "A Descricao do produto e obrigatoria")]
    public string? Descricao { get; set; }

    [Required(ErrorMessage = "Informe o preco do produto")]
    public decimal Preco { get; set; }

    [Required(ErrorMessage = "Informe o Caminho da imagem do produto")]
    [Display(Name = "Caminho da Imagem")]
    public string? ImagemUrl { get; set; }

    [Display(Name = "Categoria")]
    public int CategoriaId { get; set; }
}
