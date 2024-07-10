using ControleBar.Dominio.Compartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ControleBar.Dominio.ModuloProduto
{
    public class Produto : EntidadeBase
    {
        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public string Nome {  get; set; }

        public decimal Preco { get; set; }

        public override void AtualizarRegistro(EntidadeBase novoRegistro)
        {
            Produto novoProduto = (Produto)novoRegistro;

            Nome = novoProduto.Nome;
            Preco= novoProduto.Preco;
        }

        public override List<string> Validar()
        {
            List<string> erros = new List<string>();

            if (string.IsNullOrEmpty(Nome.Trim()))
                erros.Add("O nome do produto deve ser preenchido!");
            if (Preco <= 0)
                erros.Add("O preço deve ser maior que 0");

            return erros;
        }

        public override string ToString()
        {
            return $"{Nome}";
        }
    }
}
