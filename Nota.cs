using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaPonderadaV4
{
    internal class Nota
    {
        public decimal valorNota;

        public int numeroEntrevistados;

        public List<decimal> Notas;

        public Nota()
        {
            this.Notas = new List<decimal>();
        }

        public Nota(decimal valorNota, int numeroEntrevistados)
            : this()
        {
            this.valorNota = valorNota;
            this.numeroEntrevistados = numeroEntrevistados;

        }


    }

    internal class Entrevistado
    {
        public List<int> Entrevistados;

        public Entrevistado()
        {
            this.Entrevistados = new List<int>();
        }
    }
}
