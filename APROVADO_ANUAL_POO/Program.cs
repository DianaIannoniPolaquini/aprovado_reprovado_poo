using System;
using System.Globalization;

namespace APROVADO_ANUAL_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Alunos alunos = new Alunos();

           
            
            Console.Write("Nome do aluno: ");
            alunos.NomeAluno = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            alunos.Nota1 = double.Parse(Console.ReadLine());
            alunos.Nota2 = double.Parse(Console.ReadLine());
            alunos.Nota3 = double.Parse(Console.ReadLine());

       
            Console.WriteLine($"Nota final = {alunos.NotaFinal().ToString("F2",CultureInfo.InvariantCulture)}");


            if (alunos.NotaFinal() >= 60)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine($"Faltaram {alunos.PontosFaltantes()} pontos.");
            }


        }
    }
}
