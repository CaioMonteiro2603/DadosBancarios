using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosBan
{
    internal class DadosBancarios
    {
        private string nome;
        private int idade;
        private string cpf;
        private int agenciaBancaria;
        private int contaBancaria;
        private decimal saldoBancario; 

        public DadosBancarios(string Nome, int Idade, string Cpf, int AgenciaBancaria, int ContaBancaria, decimal SaldoBancario)
        {
            this.nome = Nome;
            this.idade = Idade;
            this.cpf = Cpf;
            this.agenciaBancaria = AgenciaBancaria;
            this.contaBancaria = ContaBancaria;
            this.saldoBancario = SaldoBancario;
        }

        public void setNome(string Newnome)
        {
            this.nome = Newnome;
        }
        public string getNome()
        {
            return this.nome;
        }

        public void setIdade(int Newidade)
        {
            this.idade= Newidade;
        }
        public int getIdade()
        {
            return this.idade; 
        }

        public void setCpf(string NewCpf)
        {
            this.cpf= NewCpf;   
        }

        public string getCpf()
        {
            return this.cpf;
        }

        public void setAgenciaBancaria(int NewAgBancaria)
        {
            this.agenciaBancaria = NewAgBancaria; 
        }

        public int getAgenciaBancaria()
        {
            return this.agenciaBancaria;
        }

        public void setContaBancaria(int NewConta)
        {
            this.contaBancaria = NewConta;
        }

        public int getContaBancaria()
        {
            return this.contaBancaria;  
        }

        public void setSaldoBancario(decimal NewSaldo)
        {
            this.saldoBancario = NewSaldo;
        }
        public decimal getSaldoBancario()
        {
            return this.saldoBancario; 
        }

        public void SaqueBancario(decimal valor)
        {
            if(valor <= saldoBancario)
            {
                saldoBancario -= valor;
                Console.WriteLine("Saque realizado com sucesso, no valor de R$ " + valor +"!"); 
            } else
            {
                Console.WriteLine("Operação não realizada, consulte o banco para verificar o que houve!"); 
            }
        }

        public void DepositoBancario(decimal valor)
        {
            if(valor > 0)
            {
                saldoBancario += valor;
                Console.WriteLine("Depósito realizado com sucesso, no valor de R$ " + valor + "!"); 
            }
        }

        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo é: R$ " + saldoBancario+"!"); 
        }
    }
}
