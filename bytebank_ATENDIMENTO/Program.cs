using bytebank.Modelos.Conta;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");


Array amostra = Array.CreateInstance(typeof(double), 6);
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);
amostra.SetValue(6.7, 5);


TestaMediana(amostra);
TestaMedia(amostra);
TestaArrayContaCorrentes();

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

double TestaMedia(Array array)
{
    if (array == null || array.Length == 0)
    {
        Console.WriteLine("Array para cálculo da média está vazio ou nulo.");
        return 0;
    }

    double somaItens = 0;
    foreach (double valor in array)
    {
        somaItens += valor;
    }

    double media = somaItens / array.Length;
    Console.WriteLine($"Com base na amostra, a média simples é: {media}.");
    return media;
}


void TestaArrayContaCorrentes()
{
    ContaCorrente[] listaDeContas = new ContaCorrente[]
    {
        new ContaCorrente(874),
        new ContaCorrente(874),
        new ContaCorrente(874)
    };

    foreach (ContaCorrente contaAtual in listaDeContas)
    {
        Console.WriteLine(contaAtual);
    }
}