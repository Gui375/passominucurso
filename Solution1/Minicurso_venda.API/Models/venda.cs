namespace Minicurso_venda.API.Models
{
    public class venda
    {
        public int id_pedido;
        public DateTime data_venda;
        public string Nome_cliente { get; set; }

        public status_venda status_venda{ get;set; }

        
    }
}
