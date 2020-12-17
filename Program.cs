using System;
using System.Collections.Generic;
using Listas_de_objetos.Classes;

namespace Listas_de_objetos
{
    class Program
    {
        static void Main(string[] args)
        {

            // Criamos a lista
            List<Produto> produtos = new List<Produto>();

            // Adicionamos produtos através de instâncias com construtores
            produtos.Add(new Produto(1, "Apple Watch", 3522.56f));
            produtos.Add(new Produto(2, "Xiaomi Watch", 1522.45f));
            produtos.Add(new Produto(3, "Zenfone ASUS", 2522.45));
            produtos.Add(new Produto(4, "Samsung", 2522,87));
            produtos.Add(new Produto(5, "Motorola G8",2522.87f));

            // Ou através de instancias básicas e suas atribuições
            Produto iphone = new Produto();
            iphone.Codigo = 6;
            iphone.Nome = "Iphone XII";
            iphone.Preco = 8952.45f;

            produtos.Add(iphone);

            // Podemos mostrar os produtos com foreach
            foreach(Produto p in produtos){
                Console.WriteLine($" {p.Nome} - R${p.Preco}");
            }

            // Podeoms remover itens através de seu índice de array;
            // Linha removida na posição 3 do  array: Produto(4, "Samsung", 2522.87f);
            produtos.RemoveAt(3);

            // Tambem podemos remover um produto da lista usando expressão labda eo método removeAll:
            // Linha removida: Produto(1, "Apple watch", 3522.56f)
            produtos.RemoveAt(x => x.Nome == "Apple Watch");

            Console.WriteLine("\nLista alterada: ");
            // Chegamos se foi realmente removido
            foreach(Produto p in produtos){
                Console.WriteLine($"{p.Nome} - R$ {p.Preco}");
            }



            
        }
    }
}
