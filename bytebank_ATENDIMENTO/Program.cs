﻿using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Util;

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

void TestaMediana(Array array)
{
    if (array == null || array.Length == 0)
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
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874));
    listaDeContas.Adicionar(new ContaCorrente(884));
    listaDeContas.Adicionar(new ContaCorrente(894));
    ContaCorrente contaMarcelo = new ContaCorrente(944);
    listaDeContas.Adicionar(contaMarcelo);
    listaDeContas.Adicionar(new ContaCorrente(904));
    listaDeContas.Adicionar(new ContaCorrente(914));
    listaDeContas.Adicionar(new ContaCorrente(924));
    listaDeContas.Adicionar(new ContaCorrente(934));

    listaDeContas.ExibeLista();

    listaDeContas.Remover(contaMarcelo);
    listaDeContas.ExibeLista();

    Console.WriteLine(listaDeContas.ContaComMaiorSaldo());

    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas[i];
        Console.WriteLine($"Indice [{i}]: {conta.Conta}/{conta.Numero_agencia}");

    }
}

List<string> nomesDosEscolhidos = new List<string>()
{
    "Bruce Wayne",
    "Carlos Vilagran",
    "Richard Grayson",
    "Bob Kane",
    "Will Farrel",
    "Lois Lane",
    "General Welling",
    "Perla Letícia",
    "Uxas",
    "Diana Prince",
    "Elisabeth Romanova",
    "Anakin Wayne"
};

bool VerificaSeNomeExiste(List<string> lista, string nome)
{
    return lista.Contains(nome);
}


Console.WriteLine(VerificaSeNomeExiste(nomesDosEscolhidos, "Anakin Wayne"));
Console.WriteLine(VerificaSeNomeExiste(nomesDosEscolhidos, "Jorge Miguel"));