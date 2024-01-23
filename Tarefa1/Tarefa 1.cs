int[] arrayOriginal = { 7, 5, 3, 9, 6, 4, 1 };
int[] arrayModificado = new int[arrayOriginal.Length];
int soma = 0;

for (int i = 0; i < arrayOriginal.Length; i++)
{
    if (arrayOriginal[i] == 9)
    {
        arrayModificado[i] = 5;
    }
    else if (arrayOriginal[i] == 4)
    {
        continue;
    }
    else
    {
        arrayModificado[i] = arrayOriginal[i];
    }
    soma += arrayModificado[i];
}
arrayModificado = arrayModificado.Where(x => x != 0).ToArray();

Console.WriteLine("Lista Original: " + string.Join(", ", arrayOriginal));
Console.WriteLine("Lista Modificada: " + string.Join(", ", arrayModificado));
Console.WriteLine("Soma da nova lista: " + soma);