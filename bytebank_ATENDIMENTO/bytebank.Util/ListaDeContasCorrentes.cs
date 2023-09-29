using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    public class ListaDeContasCorrentes
    {
        private ContaCorrente[] _contas = null;
        private int _proxPosicao = 0;

        public ListaDeContasCorrentes(int tamanhoInicial = 5)
        {
            _contas = new ContaCorrente[tamanhoInicial];
        }

        public void Adicionar(ContaCorrente conta)
        {
            VerificaTamanho(_proxPosicao + 1);
            Console.WriteLine($"Adicionando conta na posição {_proxPosicao + 1}/{_contas.Length}");
            _contas[_proxPosicao] = conta;
            _proxPosicao++;
        }

        private void VerificaTamanho(int tamanhoNecessario)
        {
            if(_contas.Length >= tamanhoNecessario)
            {
                return;
            }

            Console.WriteLine($"Aumentando o tamanho da lista de contas para {tamanhoNecessario}");
            ContaCorrente[] novaListaDeContas = new ContaCorrente[tamanhoNecessario];

            for(int i = 0; i < _contas.Length; i++)
            {
                novaListaDeContas[i] = _contas[i];
            }
            _contas = novaListaDeContas;
        }

        public ContaCorrente ContaComMaiorSaldo ()
        {
            ContaCorrente contaComMaiorSaldo = null;
            double maiorSaldo = 0;
            for(int i = 0; i < _contas.Length; i++)
            {
                if (_contas[i].Saldo > maiorSaldo)
                {
                    contaComMaiorSaldo = _contas[i];
                }
            }

            return contaComMaiorSaldo;
        }
    }
}
