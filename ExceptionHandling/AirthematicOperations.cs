using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public  class AirthematicOperations
    {

        public void dividing()
        {
            try
            {
                int a, b, c;
                Console.WriteLine("Enter A value:");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b value:");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine("The result is:" + c);
                Console.WriteLine();
            }



            catch (DivideByZeroException)

            {
                Console.WriteLine("b must be non zero");

            }
            catch (FormatException)
            {
                Console.WriteLine("b must be a number");
            }
            finally
            {
                Console.WriteLine("this is final block");
            }

            try
            {


                int d, e, f;
                Console.WriteLine("Enter d value:");
                d = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter b value:");
                e = Convert.ToInt32(Console.ReadLine());
                f = d / e;
                Console.WriteLine("The result is:" + f);
                Console.ReadLine();
            }



            catch (FormatException)
            {
                Console.WriteLine("b must be a number");
            }
            finally
            {
                Console.WriteLine("this is final block");
            }
        }
    }


    }

