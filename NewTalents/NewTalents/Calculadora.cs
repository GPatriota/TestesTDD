using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;
        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }
        
        public int somar(int valor1, int valor2)
        {
            int soma = valor1 + valor2;
            listaHistorico.Insert(0, "Resultado: " + soma + " - Data: " + data);
            return soma;
        }

        public int subtrair(int valor1, int valor2)
        {
            int subtracao = valor1 - valor2;
            listaHistorico.Insert(0, "Resultado: " + subtracao + " - Data: " + data);
            return subtracao;
        }

        public int multiplicar (int valor1, int valor2)
        {
            int multiplicacao = valor1 * valor2;
            listaHistorico.Insert(0, "Resultado: " + multiplicacao + " - Data: " + data);
            return multiplicacao;
        }

        public int dividir (int valor1, int valor2)
        {
            int divisao = valor1 / valor2;
            listaHistorico.Insert(0, "Resultado: " + divisao + " - Data: " + data);
            return divisao;
        }

        public List<string> historico()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}
