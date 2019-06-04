using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovoBanco.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }

        public Funcionario(double salario, string cpf)
        {
            Console.WriteLine("Criando FUNCIONARIO");

            CPF = cpf;
            Salario = salario;

            TotalDeFuncionarios++;
        }
        
        public Funcionario(string cpf) : this(1500, cpf) // o this no construtor indica qual construtor será executado antes
        {
            // Ahá! Nosso código está sem repetições e simplificado
        }

        public string Nome { get; set; }
        public string CPF { get; private set; }
        public double Salario { get; protected set; }
       

        public abstract double GetBonificacao();
        

        public abstract void AumentarSalario();
        
    }
    
   
}
