using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tecnofit.Logic.Logica
{
    public class Palindromo
    {
        //Palindromo recursivo
        public void IsPalindromo(string n)
        {
            
            int aux, x = 0;
            aux = inverteString(n,n.Length - 1, x);
            if(aux == 1)
                Console.WriteLine("VERDADEIRO");
            else
                Console.WriteLine("FALSO");
        }

        public int inverteString(string str, int y , int aux)
        {
            if(y <= aux)
            {
                return 1;
            }else
            {
                if (str[y] != str[aux]) return 0;
                return inverteString(str, y - 1, aux + 1);
            }
        }

        public bool IsPalindromoReverse(string str)
        {
            string strPalin = str.Substring(0, str.Length / 2);
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string strInverse = temp.Substring(0, temp.Length / 2);

            return strPalin.Equals(strInverse);
        }
    }
}
