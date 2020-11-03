using System;
using System.Collections.Generic;

namespace RegistroPedidosMVC.Models
{
    public static class Dados
    {
        public static Pedido PedidoAtual;

        static Dados(){
            
            PedidoAtual = new Pedido();
        } 
    }
}