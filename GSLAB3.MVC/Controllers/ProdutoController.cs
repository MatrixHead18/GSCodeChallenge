using GSLAB3.MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace GSLAB3.MVC.Controllers
{
    public class ProdutoController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<mvcProduto> produtoList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Produto").Result;
            produtoList = response.Content.ReadAsAsync<IEnumerable<mvcProduto>>().Result;
            return View(produtoList);
        }

        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new mvcProduto());
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("Produto/" + id.ToString()).Result;
                return View(response.Content.ReadAsAsync<mvcProduto>().Result);
            }

        }
        [HttpPost]
        public ActionResult AddOrEdit(mvcProduto prod)
        {
            if (prod.IdProduto == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("Produto", prod).Result;
                TempData["SuccessMessage"] = "Salvo com Sucesso !";
            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("Produto/" + prod.IdProduto, prod).Result;
                TempData["SuccessMessage"] = "Alterado com Sucesso !";
            }

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("Produto/" + id.ToString()).Result;
            TempData["SuccessMessage"] = "Deletado com Sucesso !";
            return RedirectToAction("Index");
        }
    }
}
