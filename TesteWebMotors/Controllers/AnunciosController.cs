using Common;
using DataAccessObject.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TesteWebMotors.Controllers
{
    public class AnunciosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Incluir()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditarAnuncio(int id)
        {
            ViewBag.anuncio = Data.ObterAnuncioEspecifico(id);
            return View("Atualizar");
        }

        [HttpPost]
        public IActionResult IncluirDados()
        {
            Anuncio anuncio = new Anuncio
            {
                marca = Request.Form["marca"].ToString(),
                modelo = Request.Form["modelo"].ToString(),
                versao = Request.Form["versao"].ToString(),
                ano = Convert.ToInt32(Request.Form["ano"].ToString()),
                quilometragem = Convert.ToInt32(Request.Form["quilometragem"].ToString()),
                observacao = Request.Form["observacao"].ToString()
            };

            if (Data.InserirAnuncio(anuncio))
                return RedirectToAction("Incluir", "Anuncios");
            else
                return StatusCode(500, new { erro = "Houve uma falha ao inserir o anúncio." });
        }

        public IActionResult Listar()
        {
            var anuncios = Data.ObterTodosAnuncios();
            ViewBag.anuncios = anuncios;
            return View();
        }

        public IActionResult RemoverAnuncio(int id)
        {
            Data.DeletarAnuncio(id);
            return RedirectToAction("Listar", "Anuncios");
        }

        [HttpPost]
        public IActionResult AtualizarAnuncio()
        {
            Anuncio anuncio = new Anuncio
            {
                ID = Convert.ToInt32(Request.Form["id"].ToString()),
                marca = Request.Form["marca"].ToString(),
                modelo = Request.Form["modelo"].ToString(),
                versao = Request.Form["versao"].ToString(),
                ano = Convert.ToInt32(Request.Form["ano"].ToString()),
                quilometragem = Convert.ToInt32(Request.Form["quilometragem"].ToString()),
                observacao = Request.Form["observacao"].ToString()
            };

            if (Data.AtualizarAnuncio(anuncio))
                return RedirectToAction("Listar", "Anuncios");
            else
                return StatusCode(500, new { erro = "Houve uma falha ao atualizar o anúncio." });
        }
    }
}
