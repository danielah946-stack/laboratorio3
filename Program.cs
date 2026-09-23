//Funcion de imprimir notas
static void ImprimirNotas(int[] notas)
{
    for(int i=0; i<notas.Length; i++)
    {
        Console.WriteLine(notas[i]);
    }
}


int[] notas = { 15, 18, 12, 17, 20};

//Imprimir las notas
ImprimirNotas(notas);

//Calcular el promedio de las notas
int suma=0;
for(int  i=0; i<notas.Length; i++)
{
    suma+= notas[i];
}
double promedio = (double)suma / notas.Length;
Console.WriteLine($"El promedio es:{promedio}");
