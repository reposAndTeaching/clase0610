using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase0610
{
    class Fraccion
    {
        private int numerador;
        private int denominador;

        public Fraccion(int numerador, int denominador)
        {
            this.numerador = numerador;
            this.denominador = denominador;
        }

        public int Numerador { get => numerador; set => numerador = value; }
        public int Denominador { get => denominador; set => denominador = value; }

        public double ValorDeLaFracción()
        {
            double valor;
            //DivideByZeroException
            try
            {
                valor = numerador / denominador;

            }
            catch (DivideByZeroException ex)
            {
                Console.Write("No es posible hacer la división, ya que el denominador tiene un valor de 0: ");
                Console.WriteLine(ex.Message);
                valor = 0;
            }catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Se generó un error de ArgumentOutOfRangeException");
                valor = 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Se generó una excepción desconcocida: " + ex.Message);
                valor = 0;
            }
            finally
            {
                Console.WriteLine("Éste es un bloque finally");
            }

            return valor;

        }
    }
}
