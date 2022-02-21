using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1e2_EstruturaDados
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            Funcionario valor = new Funcionario();
            Pilha minhaPilha = new Pilha(); // cria uma instância da classe pilha!
          
            do
            {
                try
                {
                    Console.Write("\n\n Escolha: 1-> empilha 2->desempilha " +
                    " 3->topo 4-> tamanho   5->Listar  6-> Somar salários  7-> Listar os dados 8-> Somar salarios 9-> sair 10 -> Remover a base : ");
                    opcao = Convert.ToInt32(Console.ReadLine());
                    if (opcao == 1)
                    {
                        Funcionario novo = new Funcionario();
                        Console.Write(">>Digite o valor que deseja empilhar em nome: ");
                        valor.nome = Console.ReadLine();
                        Console.Write(">>Digite o valor que deseja empilhar em salario: ");
                        valor.salario = Convert.ToDouble(Console.ReadLine());
                        minhaPilha.Empilha(valor);
                    }
                    else if (opcao == 2)
                    {
                        valor = minhaPilha.Desempilha();
                        Console.WriteLine(">>Desempilhado: {0} \n\n", valor);
                    }
                    else if (opcao == 3)
                    {
                        valor = minhaPilha.RetornaTopo();
                        Console.WriteLine(">>Valor no topo: {0} \n\n", valor);
                    }
                    else if (opcao == 4)
                    {
                        Console.WriteLine(">>Tamanho da pilha: {0}", minhaPilha.Tamanho());
                    }
                    else if (opcao == 9)
                    {
                        Console.WriteLine("Tchau!!!");
                        // sai do programa
                    }
                    else if (opcao == 7) 
                    {
                        int qtd = 0;
                        Funcionario[] dados = new Funcionario[minhaPilha.Tamanho()];
                            
                        for(int n = 0; n < (minhaPilha.Tamanho() + 1); n++) { 
                            dados[n] = new Funcionario();
                            valor = minhaPilha.Desempilha();
                            dados[n] = valor;
                            qtd++;
                            }
                        
                        for(int aux = 0; aux < qtd; aux++) 
                        {
                            Console.WriteLine("Dados: ");
                            Console.WriteLine("Nome: " + dados[aux].nome);
                            Console.WriteLine("Salario: " + dados[aux].salario + "\n");
                        }
                        for(int empilha = 0; empilha < qtd; empilha++) 
                        {
                            minhaPilha.Empilha(dados[empilha]);
                        }
                       
                    }
                    else if (opcao == 8) 
                    {
                        Funcionario[] dados = new Funcionario[minhaPilha.Tamanho()];

                        int qtd = 0;
                        double soma = 0;
                        for(int n = 0; n < (minhaPilha.Tamanho() + 1); n++) { 
                            dados[n] = new Funcionario();
                            valor = minhaPilha.Desempilha();
                            dados[n] = valor;
                            soma = valor.salario + soma;
                            qtd++;
                            }
                        
                       Console.WriteLine("A soma é : "+ soma);
                        for(int empilha = 0; empilha < qtd; empilha++) 
                        {
                            minhaPilha.Empilha(dados[empilha]);
                        }
                    }

                    else if (opcao == 10)
                    {
                        RemoveBase(minhaPilha);
                    }
                     

                }
                catch (Exception erro)
                {
                    Console.WriteLine("ERRO: " + erro.Message);
                }
            }
            while (opcao != 9);




            }

             static void RemoveBase(Pilha minhaPilha) 
             { 
             int qtd = 0;
             Funcionario[] dados = new Funcionario[minhaPilha.Tamanho()];
             Funcionario valor = new Funcionario();

                if (minhaPilha.Tamanho() == 0)
                    throw new Exception("A pilha está vazia!!!");
                else
                {
                    for(int n = 0; n < (minhaPilha.Tamanho() + 1); n++)
                    { 
                            dados[n] = new Funcionario();
                            valor = minhaPilha.Desempilha();
                            dados[n] = valor;
                            qtd++;
                    }
                    for(int empilha = 1; empilha < qtd; empilha++) 
                    {
                        minhaPilha.Empilha(dados[empilha]);
                    }  
                } 

             }
    }
}
