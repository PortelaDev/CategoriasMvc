using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;

namespace CategoriasMvc.Models;

public class CategoriaViewModel
{
    public int CategoriaId { get; set; }

    [Required(ErrorMessage = "O nome da categoria e Obrigatorio")]
    public string? Nome { get; set; } = string.Empty;

    [Required]
    [Display(Name = "Imagem")]
    public string? ImagemUrl { get; set; } = string.Empty;
}
