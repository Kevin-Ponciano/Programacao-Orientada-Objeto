using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Introdução
{
    class Nota
    {
        private float Nota01, Nota02;

        private string status;

        public string Status { 
            get => status;
            set => status = value;
        }

        private float media;
        public float Media => media;

        public Nota(float n1, float n2)
        {
            this.Nota01 = n1;
            this.Nota02 = n2;
            status = "Cursado";
        }

        private float calcularMedia()
        {
            return (Nota01 + Nota02) / 2;
        }

        public void definirStatus()
        {
            media = calcularMedia();

            if(media >= 7)
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
