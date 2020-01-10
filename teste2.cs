using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularInvestimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Investimento");

            double valorInvestido = 10150.76;

            double rendimento = 1.03;


            //string.Format({ 0:n2}, valorInvestido);

            for (int contadorAno = 1; contadorAno <= 3; contadorAno++)
            {
                if (contadorAno == 1)
                {
                    Console.WriteLine("===========================================================");
                    Console.WriteLine("Periodo de " + contadorAno + " ano");
                    Console.WriteLine("===========================================================");
                }
                else
                { 
                    Console.WriteLine("===========================================================");
                    Console.WriteLine('\n' + "Periodo de " + contadorAno + " anos");
                    Console.WriteLine("===========================================================");
                }
                for (int contadorMes = 1; contadorMes <= 12; contadorMes++)
                {

                    valorInvestido *= rendimento;
                    Console.WriteLine('\n'+ "  Mes de referencia " + contadorMes + "     Valor é  " + "{0:C}", valorInvestido);

					if (contadorMes >= 3)
					{
						if (contadorMes % 2 == 0 && contadorAno <= 3 && contadorMes < 12)
						{
							valorInvestido += 500;
							Console.WriteLine("  Feito aporte de R$ 500,00 reais no mes " + contadorMes +
								"      Valor Atual é " + "{0:C}", valorInvestido + '\n');

						}
						else
							Console.WriteLine("  Sem aporte no mes " + contadorMes + '\n');

					}
				}

                               
            }
            Console.ReadLine();
        }
    }
}
