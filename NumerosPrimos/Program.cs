int numero;
float resultado;
int contador = 0;

while (true)
{
    contador = 0;
    Console.Write("Digite um número: ");
    numero = int.Parse(Console.ReadLine());

    for (int i = 1; i <= numero; i++)
    {
        resultado = numero % i;


        if (resultado == 0)
        {
            contador++;
        }

    }

    if (contador == 2)
    {
        Console.WriteLine("O número {0} é primo", numero);
    }

    else
    {
        Console.WriteLine("\nO número {0} não é primo!", numero);
    }

    Console.WriteLine("\n|Pressione qualquer tecla|");
    Console.ReadKey();
    Console.Clear();
}
