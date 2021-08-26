using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacionamentos
{
    class Item
    {
        public string Tipo { get; set; }

        public int Qtd { get; set; }

        public Item()
        {
            this.Qtd = 0;
            this.Tipo = "a definir";
        }
    }
}
