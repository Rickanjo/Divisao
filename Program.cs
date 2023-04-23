// Leia um número inteiro e exiba "Negativo", "Zero" ou "Positivo", conforme o caso.

Console.WriteLine("--- Continha de divisão ---\n");

Console.Write("Digite o numerador.......: ");
int numerador = int.Parse(Console.ReadLine()!);

Console.Write("Digite o denominador.....: ");
int denominador = int.Parse(Console.ReadLine()!);

if (denominador == 0) {
    Console.WriteLine("Não é possível dividir por zero.");
} else {
     double resultado = (double)numerador / denominador;
    Console.WriteLine($"Resultado da divisão: {resultado}");
}


