﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RegistroPedidosMVC.Models;

namespace RegistroPedidosMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        

        public IActionResult Index() {
            
            return View();
        }

        [HttpPost]
        public IActionResult Index(ItemPedido pedido)
        {   
            Dados.PedidoAtual.Inserir(pedido);
            return View("Concluido");
        }

        public IActionResult Listar()
        {
            List<ItemPedido> pedidos = Dados.PedidoAtual.Listar();
            return View(pedidos);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
