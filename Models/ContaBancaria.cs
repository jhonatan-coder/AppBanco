using System.Diagnostics;
using AppBanco.Models;
using Microsoft.EntityFrameworkCore;
using AppBanco.Data;
namespace AppBanco.Models
{
    public class ContaBancaria : HistoricoTransacao
    {
        public decimal Depositar(Usuario usuario, decimal valor)
        {
            if (usuario == null)
            {
                throw new ArgumentNullException(nameof(usuario));
            }

            if (valor <= 0)
            {
                throw new ArgumentException("O valor deve ser maior que zero.");
            }
            usuario.Saldo += valor;
            RegistrarMovimentecao(TipoTransacao.Deposito, valor);
            return usuario.Saldo;
        }  

        public decimal Sacar(Usuario usuario, decimal valor)
        {
            if (usuario == null)
            {
                throw new ArgumentException(nameof(usuario));
            }
            if (valor > usuario.Saldo)
            {
                throw new InvalidOperationException("Saldo insuficiente para realizaar esta operação.");
            }
            usuario.Saldo -= valor;
            RegistrarMovimentecao(TipoTransacao.Saque, valor);
            return usuario.Saldo;
        }   

        public void Transferir(Usuario origem, Usuario destino, decimal valor)
        {
            if (origem == null)
            {
                throw new ArgumentNullException(nameof(origem));
            }

            if (destino == null)
            {
                throw new ArgumentNullException(nameof(destino));
            }

            if (valor <= 0)
            {
                throw new ArgumentException("O valor deve ser maior que zero.", nameof(valor));
            }

            if (origem.Saldo < valor)
            {
                throw new InvalidOperationException("Saldo insuficiente para realizar esta operação.");
            }
            origem.Saldo -= valor;
            destino.Saldo += valor; 
            RegistrarMovimentecao(TipoTransacao.Transferencia, valor);         
        }   
    }
}