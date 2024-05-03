using System;
using System.Collections;
using System.Collections.Generic;

class queue_stack
{
    public static void Main(string[] args)
    {
        //QUEUE: ENQUEUE E DEQUEUE
        //CLEAR: REMOVE TUDO
        //CONTAINS: CHECA SE HÁ UM TREM OU NÃO
        //PEEK: retorna o próximo objeto que será removido
        //queue.Count e stack.Count => retorna o número de elementos

        Console.WriteLine("=========================FILA=========================");
        Queue q = new Queue();
        q.Enqueue(1); q.Enqueue(2); q.Enqueue(3); q.Enqueue(4); q.Enqueue(5);
        Console.WriteLine("Nº Elementos na fila: {0}", q.Count);
        q.Dequeue();
        Console.WriteLine("A fila contém 1? {0}", q.Contains(1) ? "SIM!!!" : "não... ;-;");
        Console.WriteLine("A fila contém 5? {0}", q.Contains(5) ? "SIM!!!" : "não... ;-;");
        Console.WriteLine("Próximo elemento que vamos remover é o: {0}", q.Peek());
        q.Enqueue(6); q.Enqueue(7); q.Enqueue(8); q.Enqueue(9); q.Enqueue(10);
        Console.WriteLine("Agora vamos remover o: {0}", q.Dequeue());
        Console.WriteLine("E depois o: {0}", q.Dequeue());
        q.Clear();
        Console.WriteLine("Adeus, query, vc agora tem {0} elementos ;-;", q.Count);

        // STACK: PUSH E POP(insere e tira)
        Console.WriteLine("\n\n=========================PILHA=========================");
        Stack s = new Stack();
        s.Push(1); s.Push(2); s.Push(3); s.Push(4); s.Push(5);
        Console.WriteLine("Nº de Elementos na pilha: {0}", s.Count);
        s.Pop();
        Console.WriteLine("A pilha contém 1? {0}", s.Contains(1) ? "SIM!!!" : "não... ;-;");
        Console.WriteLine("A pilha contém 5? {0}", s.Contains(5) ? "SIM!!!" : "não... ;-;");
        Console.WriteLine("Próximo elemento que vamos remover é o: {0}", s.Peek());
        s.Push(6); s.Push(7); s.Push(8); s.Push(9); s.Push(10);
        Console.WriteLine("Agora vamos remover o: {0}", s.Pop());
        Console.WriteLine("E depois o: {0}", s.Pop());
        s.Clear();
        Console.WriteLine("Adeus, pilha, você agora tem {0} elementos ;-;", s.Count);
    }


}