// Os 21 primeiros numeros primos (incluindo 0)
int[] array = { 0, 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71 };

// alvo não pode ser maior que 138
int alvo = 9;

if (alvo > 138)
{
    Console.WriteLine("Alvo não pode ser maior que 138");
    return;
}
foreach (int item in array)
{
    if (item < alvo)
    {
        int complemento = alvo - item;

        if (array.Contains(complemento))
        {
            Console.WriteLine("Alvo: " + alvo);
            Console.WriteLine("Índice 1: " + Array.IndexOf(array, item) + " - Valor: " + item);
            Console.WriteLine("Índice 2: " + Array.IndexOf(array, complemento) + " - Valor: " + complemento);
            break;
        }
    }
}
