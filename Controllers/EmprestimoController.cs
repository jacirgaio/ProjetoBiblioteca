using Biblioteca.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Biblioteca.Controllers
{
    
    public class EmprestimoController : Controller
    {
        public IActionResult Cadastro()
        {   
            Autenticacao.CheckLogin(this);

            LivroService livroService = new LivroService();
            EmprestimoService emprestimoService = new EmprestimoService();

            CadEmprestimoViewModel cadModel = new CadEmprestimoViewModel();
            cadModel.Livros = livroService.ListarDisponiveis();
            return View(cadModel);
        }

        [HttpPost]
        public IActionResult Cadastro(CadEmprestimoViewModel viewModel)
        {
            EmprestimoService emprestimoService = new EmprestimoService();
            
            if(viewModel.Emprestimo.Id == 0)
            {
                emprestimoService.Inserir(viewModel.Emprestimo);
            }
            else
            {
                emprestimoService.Atualizar(viewModel.Emprestimo);
            }
            return RedirectToAction("Listagem");
        }

        public IActionResult Listagem(string tipoFiltro, string filtro, string itensPPagina, int numPagina, int PaginaAtual)
        {
            Autenticacao.CheckLogin(this);

            FiltrosEmprestimos objFiltro = null;
            if(!string.IsNullOrEmpty(filtro))
            {
                objFiltro = new FiltrosEmprestimos();
                objFiltro.Filtro = filtro;
                objFiltro.TipoFiltro = tipoFiltro;
            }
            /* essas duas linhas são para paginação*/
            ViewData["emprestimoPPagina"] = (string.IsNullOrEmpty(itensPPagina) ? 5 : int.Parse(itensPPagina));
            ViewData["PaginaAtual"] = (PaginaAtual !=0 ? PaginaAtual : 1);

            EmprestimoService emprestimoService = new EmprestimoService();
            return View(emprestimoService.ListarTodos(objFiltro));
        }

        public IActionResult Edicao(int id)
        {
            Autenticacao.CheckLogin(this);
            
            LivroService livroService = new LivroService();
            EmprestimoService em = new EmprestimoService();
            Emprestimo e = em.ObterPorId(id);

            CadEmprestimoViewModel cadModel = new CadEmprestimoViewModel();
            cadModel.Livros = livroService.ListarDisponiveis();
            cadModel.Emprestimo = e;
            
            return View(cadModel);
        }
    }
}