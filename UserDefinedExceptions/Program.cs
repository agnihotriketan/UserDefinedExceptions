using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDefinedExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Temperature temp = new Temperature();
            try
            {
                temp.showTemp();
            }
            catch (TempIsZeroException e)
            {
                Console.WriteLine("Exception Occured \n TempIsZeroException: {0}", e.Message);
            }
            try
            {

                var temp2 = new Temperature(10);
                temp2.showTemp();
            }
            catch (Exception)
            { 
                throw;
            }
            Console.ReadKey();
        }
    }

    public class TempIsZeroException : Exception
    {
        public TempIsZeroException(string message)
            : base(message)
        {
        }
    }

    public class Temperature
    {
        int temperature = 0;
        public Temperature()
        {

        }
        public Temperature(int temp)
        {
            temperature = temp;
        }
        public void showTemp()
        {
            if (temperature == 0)
            {
                throw (new TempIsZeroException("Zero Temperature found"));
            }
            else
            {
                Console.WriteLine("No Exception, We got temperature value as : {0}", temperature);
            }
        }
    }
}
