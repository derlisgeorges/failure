namespace Listas_de_objetos.Classes
{
    public class Produto
    {
        private int v1;
        private string v2;
        private float v3;

        public Produto(int v1, string v2, float v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        public Produto(int v1, string v2, double v)
        {
            this.v1 = v1;
            this.v2 = v2;
        }

        public Produto(int v1, string v2, float v3, int v)
        {
        }public int Codigo {get; set;}

        public int Codigo { get; internal set; }

        public string Nome {get; set;}

        public float Preco {get; set;}

        public Produto(){

        }

        public Produto(int _codigo, string _nome, float_preco)
        {
            this.Codigo = _codigo;
            this.Nome = _nome;
            this. = _preco;
        }
    }
}