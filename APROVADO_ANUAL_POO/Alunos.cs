using System;
using System.Collections.Generic;
using System.Text;

namespace APROVADO_ANUAL_POO
{
    internal class Alunos
    {
        public string NomeAluno;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public double PontosFaltantes()
        {
            return (60 - NotaFinal());
        }

    }
}
