// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int numeroAIterar = 2;
int contadorDivisible = 0;

while (numeroAIterar <= 100)
{
    for (int i = 1; i <= numeroAIterar; i++)
    {
        if(numeroAIterar%i == 0)
            contadorDivisible++;

        if(contadorDivisible > 2)
            break;
    }

    if (contadorDivisible == 2)
        Console.WriteLine($"El número {numeroAIterar} es primo");

    contadorDivisible = 0;
    numeroAIterar++;
}