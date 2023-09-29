Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");


Array amostra = Array.CreateInstance(typeof(double), 6);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);
amostra.SetValue(6.7, 5);

TestaMediana(amostra);
void TestaMediana (Array array)
{
    if(array == null || array.Length == 0)
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
        return;
    }

    double[] valoresOrdenados = (double[])array.Clone();
    Array.Sort(valoresOrdenados);

    int tamanhoArray = valoresOrdenados.Length;
    int meioArray = tamanhoArray / 2;

    double mediana = (tamanhoArray % 2 != 0) ? 
        valoresOrdenados[meioArray] : 
        (valoresOrdenados[meioArray] + valoresOrdenados[meioArray - 1]) / 2;

    Console.WriteLine($"Com base na amostra, a mediana é: {mediana}.");

}
