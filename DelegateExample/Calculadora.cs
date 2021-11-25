using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExample
{
    //definindo o delegate
    public delegate int Calcular(int value1, int value2);

    //A classe que contém os métodos
    //que serão atribuidos aos objetos delegates
    public class Calculadora
    {
        //o método Somar que será atribuido ao objeto delegate
        //e possui a assinatura EXATA do delegate
        public int Somar(int value1, int value2)
        {
            return value1 + value2;
        }

        //o método Subtrair que será atribuido ao objeto delegate
        //e possui a assinatura EXATA do delegate
        public int Subtrair(int value1, int value2)
        {
            return value1 - value2;
        }

        //o método Multiplicar que será atribuido ao objeto delegate
        //e possui a assinatura EXATA do delegate
        public int Multiplicar(int value1, int value2)
        {
            return value1 * value2;
        }

        //o método Dividir que será atribuido ao objeto delegate
        //e possui a assinatura EXATA do delegate
        public int Dividir(int value1, int value2)
        {
            try
            {
                return value1 / value2;
            }
            catch (Exception)
            {

                return 0;
            }
             
        }
    }
}
