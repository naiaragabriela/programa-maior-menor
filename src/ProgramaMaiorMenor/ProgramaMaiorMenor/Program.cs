double numero,maior, menor;
int contador;

double[] numeros = new double[15];
contador = 0;

double NumeroDigitado()
{
    Console.WriteLine($"Digite o {contador +1}º número: ");
    return double.Parse(Console.ReadLine());
}

do
{

    numeros[contador] = NumeroDigitado();
    contador++;

} while (contador < 15);


contador = 0;

do
{
   
    Console.Write(numeros[contador] + ",");
    contador++;

}while (contador < 15);


void MaiorNumero()
{
    maior = numeros[0];
    menor = numeros[0];
    
    for (contador = 0; contador < 15; contador++)
    {
        if (numeros[contador]> maior)
        {
            maior = numeros[contador];
        }
    } Console.WriteLine($"O maior número digitado é: {maior}");

    contador = 0;
    while (contador < 15)
    {
        if (numeros[contador] < menor)
        {
            menor = numeros[contador];
        }
        contador++;
    } Console.WriteLine($"O menor número digitado é: {menor}");

}
MaiorNumero();