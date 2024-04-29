//First IN Last Out -> FILO



using System;

class Pilhazinha
{
    private int[] elementos;
    private int contador;

    public Pilhazinha(int capacidade){
        elementos = new int[capacidade];
        contador = 0;
    }

    public void inserir(int elemento){
        if (contador < elementos.Length){
            elementos[contador] = elemento;
            contador ++;
        }else{
            Console.WriteLine("A pilha está cheia, não podemos inserir um novo elemento");
        }
    }

    public int remover(){
        if (contador == 0){
            throw new ArgumentOutOfRangeException("Não e possível remover um elemento, a pilha está vazia");
        }
            int elemento_removido = elementos[contador - 1];
            contador--;
            return elemento_removido;
    }
    public static void Main()
    {
        //MÉTODOS: construtores
        int[] fila = new int[10];

        //CONSTRUÇÃO 1 DA FILA:
    }
}

