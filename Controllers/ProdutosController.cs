using CategoriasMvc.Models;
using CategoriasMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace CategoriasMvc.Controllers;

public class ProdutosController : Controller
{
    private readonly IProdutoService _produtoService;
    private readonly ICategoriaServices _categoriaService;
    private string token = string.Empty;

    public ProdutosController(IProdutoService produtoService, ICategoriaServices categoriaService)
    {
        _produtoService = produtoService;
        _categoriaService = categoriaService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<ProdutoViewModel>>> Index()
    {
        //extrair o token do cookie
        var result = await _produtoService.GetProdutos(ObtemTokenJwt());

        if (result is null)
            return View("Error");

        return View(result);
    }

    private string ObtemTokenJwt()
    {
        if (HttpContext.Request.Cookies.ContainsKey("X-Access-Token"))
        {

            token = HttpContext.Request.Cookies["X-Access-Token"].ToString();
        }

        return token;
    }
}
