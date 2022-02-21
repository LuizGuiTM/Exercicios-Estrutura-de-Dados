using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1e2_EstruturaDados
{
    public class Pilha
    {
        private const int CAPACIDADE = 5; //define o tamanho maximo desta uma pilha.
        private Funcionario[] dados = new Funcionario[CAPACIDADE]; // vetor para guardar os dados da pilha.
        private int topo = -1; // variável que irá indicar a posição no vetor do topo da pilha.
                               // este método informa o tamanho da pilha
        
        public int Tamanho()
        {
            return topo + 1; // lembre-se que o vetor inicia da posição zero...
        }

        
        // este método empilha um valor string na pilha
        public void Empilha(Funcionario p_valor)
        {
            if (Tamanho() != CAPACIDADE)
            {
                topo++;
                dados[topo] = p_valor;
            }
            else
                throw new Exception("A pilha está cheia!!!");
        }
        // este método desempilha um valor da pilha
        public  Funcionario Desempilha()
        {
            if (Tamanho() == 0)
                throw new Exception("A pilha está vazia!!!");
            else
            {
                Funcionario retorno = dados[topo];
                dados[topo] = null;
                topo--;
                return retorno;
            }
        }
        // este método devolve o valor que está no topo
        public Funcionario RetornaTopo()
        {
            if (Tamanho() == 0)
                throw new Exception("A pilha está vazia!!!");
            else
                return dados[topo];
        }
    }
}
