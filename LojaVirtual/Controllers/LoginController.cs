﻿using LojaVirtual.Models.Acesso;
using LojaVirtual.Repositories;
using Microsoft.AspNetCore.Mvc;
using LojaVirtual.Authorizations;
using LojaVirtual.Sessions;
using System;
using LojaVirtual.Validations;
using Microsoft.Extensions.Logging;
using Serilog;

namespace LojaVirtual.Controllers
{
    public class LoginController : Controller
    {
        private readonly Sessao _sessao;
        private readonly UsuarioR _reposUsuario;

        public LoginController(Sessao sessao, UsuarioR reposUsuario)
        {
            _sessao = sessao;
            _reposUsuario = reposUsuario;
        }

        //Páginas
        [AnonimoAutorizacao]
        public IActionResult Entrar()
        {
            try
            {
                return View();
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro);
                throw new Exception(Global.Mensagem.FalhaRedirecionamento);
            }
        }

        //Operações
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult ValidaAcesso(Usuario usuario)
        {
            try
            {
                var usuarioBanco = _reposUsuario.ValidaAcesso(usuario);

                if (usuarioBanco != null)
                {
                    _sessao.Salvar(usuarioBanco, "Acesso");
                    Sessao.IdPerfil = usuarioBanco.Perfil;

                    return Json(new { });
                }

                return BadRequest(Global.Mensagem.FalhaValidarUsuario);
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro);
                return BadRequest(Global.Mensagem.FalhaBanco);
            }
        }

        [AcessoAutorizacao]
        public IActionResult Sair()
        {
            try
            {
                _sessao.Remover("Acesso");
                return View("Entrar");
            }
            catch (Exception erro)
            {
                Console.WriteLine(erro);
                throw new Exception(Global.Mensagem.FalhaRedirecionamento);
            }
        }
    }
}