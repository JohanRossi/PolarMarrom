using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolarMarrom.Classes
{
    internal class Pedido
    {
            public string Nome { get; set; }
            public string Cpf { get; set; }
            public string Status { get; set; }
            public DateTime Data { get; set; }
            public List<Item> Items { get; set; }

            public decimal ValorTotal
            {
                get
                {
                    return Items.Sum(x => x.ValorTotal);
                }
            }

            public Pedido()
            {
                Status = "Aberto";
                Data = DateTime.Now;
                Items = new List<Item>();
            }
    }
}
