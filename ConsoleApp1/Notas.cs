using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relacionamentos
{
    class Notas
    {
        public float Nota01 { get; set; }

        public float Nota02 { get; set; }

        private string status;
        public string Status { get; }

        public Notas(float n1, float n2)
        {
            this.Nota01 = n1;
            this.Nota02 = n2;
            this.status = "Cursando";
        }

        public void DefinirStatus()
        {
            float media = (Nota01 + Nota02) / 2;

            if (media >= 7)
            {
                status = "AP";
            }
            else
            {
                status = "VCP";
            }
        }
    }
}
