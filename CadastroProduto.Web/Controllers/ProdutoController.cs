using CadastroProduto.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CadastroProduto.Web.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Produto> produtoList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Produto").Result;
            produtoList = response.Content.ReadAsAsync<IEnumerable<Produto>>().Result;

            return View(produtoList);
        }
    }
}
