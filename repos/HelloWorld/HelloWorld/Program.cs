using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arraylist
{
    //estrutura de dados pré-empacotadas no .net
    //CAPACITY -: capacitade. Começa como zero, aumentará para 4 caso ela seja extrapolada e, quando é extrapolada e é diferente de zero, DOBRA a capacidade
    //COUNT -> número de elementos no ArrayList
    //ARRAYLIST NÃO É FORTEMENTE TIPADO, É TIPO ARRAY DO NODEJS
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al1 = new ArrayList();
            ArrayList al2 = new ArrayList(10);

            //Console.WriteLine("AL1: capacity {0}, count {1}.\n", al1.Capacity, al1.Count) ;
            //Console.WriteLine("AL2: capacity {0}, count {1}.\n", al2.Capacity, al2.Count);

            al1.Add(1);
            al2.Add(2);
            /* Console.WriteLine("ADICIONAMOS OS TREM");
            Console.WriteLine("AL1: capacity {0}, count {1}.\n", al1.Capacity, al1.Count);
            Console.WriteLine("AL2: capacity {0}, count {1}.\n", al2.Capacity, al2.Count); */

            //FOREACH:
            al1.Add(2);
            al1.Add(3);
            al1.Add(4);
            /*
            int soma = 0;

            foreach (var number in al1)
            {
                //int numero = (int)number + 5; //NOTA: NÃO DÁ PRA MODIFICAR O ARRAYLIST DENTRO DO FOREACH
               // Console.WriteLine(numero);
                soma += (int)number;
            }
            float media = soma / al1.Count;

            int counter = 0;
            foreach(var number in al1)
            {
                if ((int)number > media)
                {
                    Console.WriteLine("o número {0} na posição {1} é acima da média!", number, number);
                }
                counter++;
            }
            */
            //INSERT:
            al1.Insert(1, 42); //insere algo na posição especificada
            //REMOVER ELEMENTOS
            al1.Remove(1); //ISSO AQUI É MT RUIM (remove a primeira aparição do elemento)
            al1.RemoveAt(al1.Count - 1);
            al1.RemoveRange(1, 2);

            //MAIS MÉTODOS:
            //al1.Clear();//VAI LIMPAR TUDO, MAS MANTÉM A CAPACITY
            bool tem_42 = al1.Contains(42); //RETORNA UM BOOLEANO de "isso existe no meu array?" -> é igual o some em js
            int lugar_primeiro_42 = al1.IndexOf(42); //VAI RETORNAR O INDEX DA PRIMEIRA APARIÇÃÕ DO ELEMENTO
            int lugar_ultimo_42 = al1.IndexOf(42); //VAI RETORNAR O INDEX DA ULTIMA APARIÇÃÕ DO ELEMENTO

            al1.Reverse(); //REVERTE A ORDEM, pode receber parâmetros pra inverter elementos específicos

            al1.Sort(); //ORGANIZA

            object[] trem = al1.ToArray(); //retorna o arraylist num object ARRAY
            al1.TrimToSize(); //ALTERA CAPACITY PRA SER IGUAL AO COUNT - 1 (esse é bom)

            al1.BinarySearch(43); //RETORNA POSIÇÃO DO ELEMENTO, E RETORNA -1 CASO ELEMENTO NÃO EXISTA

        }
    }
}
