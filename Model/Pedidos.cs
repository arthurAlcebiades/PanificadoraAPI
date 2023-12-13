using System;

public class Pedidos
{
     public Clientes cliente { get; set; }
     public int IdCliente { get; set; }
     public Produtos produtos { get; set; }
     public string Descricao { get; set; }
     public int Quantidade { get; set; }
     public decimal valorTotal { get; set; }
     public DateTime dataPedido { get; set; }
     public List<Produtos> listaProdutos { get; set; }
}
