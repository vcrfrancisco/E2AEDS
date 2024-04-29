using System;

class SomaDoisNumeros {
    public static void Main(){
        // declarar variáveis
        int num1, num2, soma;

        // input número 1
        Console.WriteLine("Digite um número");
        num1 = int.Parse(Console.ReadLine());

        // input número 2
        Console.WriteLine("Digite um número para somarmos ao primeiro");
        num2 = int.Parse(Console.ReadLine());

        // calcular a soma
        soma = num1 + num2;

        // mostrar o resultado
        Console.WriteLine("A soma dos números é igual a {0}", soma);
    }
}
