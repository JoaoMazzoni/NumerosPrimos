int numero;
float resultado;
int contador = 0;

while (true)
{

    do
    {

        contador = 0;
        Console.Write("Digite um número: ");
        numero = int.Parse(Console.ReadLine());
        if(numero <= 1)
        {
           Console.WriteLine("O número precisa ser maior do que 1");
           Console.WriteLine("---------------------------------------\n\n");
        }

    } while (numero <= 1);
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
        Console.WriteLine("\nO número {0} é primo", numero);
    }

    else
    {
        Console.WriteLine("\nO número {0} não é primo!", numero);
    }

    Console.WriteLine("\n\n|Pressione qualquer tecla|");
    Console.ReadKey();
    Console.Clear();
}
