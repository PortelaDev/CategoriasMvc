using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CategoriasMvc.Models;

namespace CategoriasMvc.Services;

public interface ICategoriaServices
{
    Task<IEnumerable<CategoriaViewModel>> GetCategorias();
    Task<CategoriaViewModel> GetCategoriaPorId(int id);
    Task<CategoriaViewModel> CriaCategoria(CategoriaViewModel categoriaVM);
    Task<bool> AtualizaCategoria(int id, CategoriaViewModel categoriaVM);
    Task<bool> DeletaCategoria(int id);

}
