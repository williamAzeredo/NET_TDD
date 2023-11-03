﻿using System;
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
        public int somar(int val1, int val2)
        {
            int resultado = val1 + val2;
            listaHistorico.Insert(0, $"resultado: {resultado}");
            return resultado;
        }
        public int subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;
            listaHistorico.Insert(0, $"resultado: {resultado}");
            return resultado;
        }
        public int multiplicar(int val1, int val2)
        {
            int resultado = val1*val2;
            listaHistorico.Insert(0, $"resultado: {resultado}");
            return resultado;
        }
        public int dividir(int val1, int val2)
        {
            int resultado = val1/val2;
            listaHistorico.Insert(0, $"resultado: {resultado}");
            return resultado;
        }
        public List<string> historico() 
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count-3);
            return listaHistorico; 
        }
    }
}
