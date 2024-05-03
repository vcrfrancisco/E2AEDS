using System;
using System.Collections;

class hashtableEmCs
{
    public static void Main()
    {
        //Pesquisa de forma EXTREMAMENTE EFICIENTE
        //Estrutura do tipo Dicionário/mapa baseada em pares chave/valor
        // existe uma função que retorna um valor e retorna uma chave ou posição do valor em um array OU tabela
        //CUSTO DE PESQUISA muito baixo

        //NO ENTANTO, O QUE ACONTECE QUANDO TENTAMOS INSERIR 1 ELEMENTO (valor) em uma chave OCUPADA??
        //Colisões primárias: -> dá acesso a um subconjunto de elementos
        //Solução: inserir em outra posição ou em uma estrutura externa
        Hashtable ht = new Hashtable();
        //MÉTODOS
        // Add: adiciona par chave/valor
        ht.Add(1, 10); ht.Add(2, 20); ht.Add(3, 30); ht.Add(4, 40); ht.Add(5, 50);
        Console.WriteLine("Número de elementos na tabela: {0}", ht.Count);
        Console.WriteLine("NÓS TEMOS A CHAVE 1? {0}", ht.ContainsKey(1) ? "SIM!!!!" : "não...");
        ht.Remove(1);
        Console.WriteLine("NÓS TEMOS UM VALOR 5? {0}", ht.ContainsValue(5) ? "SIM!!!!" : "não...");
        ht.Add(6, 60); ht.Add(7, 70); ht.Add(8, 80); ht.Add(9, 90); ht.Add(10, 100);
        Console.WriteLine("Estamos removendo o elemento com a chave 5. Adeus, {0}", ht[5]);
        ht.Remove(5);
        Console.WriteLine("Estamos removendo o elemento com a chave 8. Adeus, {0}", ht[8]);
        ht.Remove(80);

        ht.Clear();
        Console.WriteLine("Removemos tudo, deixando {0} chaves e {0} elementos... QUEM DIRIA HEIN", ht.Count);
        // Remove: remove um dado elemento da tabela
        // Clear: remove tudo
        // contains: retorna se a hasht contém elemento com dada CHAVE. se existe a chave MAS ela está vazia, retornará false
        // Contains Key: mesma coisa
        // ContainsValue: retorna se contém um objeto com dado valor

        //Count -> nº de elementos.
    }
}
