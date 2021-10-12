using System;

namespace Tecnofit.Logic.Logica
{
    public class NumeroAleatorioOrdenado
    {
        public int [] SortearNumero()
        {
            int[] lista = new int[6];
            int i = 0;
            while (i < lista.Length)
            {
                int num = GerarNumeros(1, 61);
                var check = ExisteElementoNoArray(lista, num);
                if (!check)
                {
                    lista[i] = num;
                    i++;
                }
            }
            OrdenarArray(lista);
            return lista;
        }

        public bool ExisteElementoNoArray(int [] lista,int num)
        {
            bool check = Array.Exists(lista, x => x == num);

            return check;
        }
        public int  GerarNumeros(int inicio, int fim)
        {
            Random rnd = new Random();
            int resultNum = rnd.Next(inicio,fim);
            return resultNum;
        }

        public int[] OrdenarArray(int [] lista)
        {
            Array.Sort(lista);
            return lista;
        }

    }
}
