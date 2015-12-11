using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlEstoque.Models
{
    public class ListaProdutos
    {
        readonly DadosContexto _db = new DadosContexto();
        public  List<Produto> GetProdutos()
        {
            var listaProdutos = _db.Produto.ToList();

            //var produtos = new List<Produto>
            //{
            //    foreach (var item in collection)
            //    {
           
            //    new Book {BookId = 1, Title = "My Story", Author = "Saad"},
            //    new Book {BookId = 2, Title = "Historia Minha", Author = "Rômulo"},
            //    new Book {BookId = 1, Title = "Maracana a História", Author = "Eu"},
            //  }
            //};
            return listaProdutos;
        }
    }
}
