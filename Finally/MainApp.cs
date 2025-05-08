using System;
using static System.Console;

namespace Finally
{
    class MainApp
    {
        static int Divide(int dividend, int divisor)
        {
            try
            {
                WriteLine("Divide() Start");
                return dividend / divisor;                
            }
            catch (DivideByZeroException e)
            {
                WriteLine("Divide() 예외 발생");
                throw e;
            }
            finally
            {
                WriteLine("Divide() End");
            }            
        }        

        static void Main(string[] args)
        {
            try
            {
                Write("피연산자 입력: ");
                String temp = ReadLine();
                int dividend = Convert.ToInt32(temp);

                Write("제수 입력: ");
                temp = ReadLine();
                int divisor = Convert.ToInt32(temp);

                WriteLine($"{dividend} / {divisor} = {Divide(dividend, divisor)}");
            }
            catch (FormatException e)
            {
                WriteLine($"Error: {e}");
            }

            catch (DivideByZeroException e)
            {
                WriteLine($"error: {e.Message}");
            }
            finally
            {
                WriteLine("Program End");
            }
        }
    }
}
