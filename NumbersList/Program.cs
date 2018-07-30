using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NumbersList
{
   public class Program
    {
        static void Main(string[] args)
        {
            var listNumbers = new List<int>{};
            
            Console.WriteLine("Enter a number");
            
            while (listNumbers.Count < 5)
            {
                var readNumbers = int.Parse(Console.ReadLine());
                listNumbers.Add(readNumbers);
                if(listNumbers.Count < 5){Console.WriteLine("Enter another number");}
            }
           
            Console.WriteLine("Enter a minimum value");
            var minValue = int.Parse(Console.ReadLine());

            var listMinimumOutput = listNumbers.FindAll(s => s > minValue);
            var minimumResults = string.Join(",", listMinimumOutput);        
            var formattedNumbers = string.Join(",", listNumbers);

            Console.WriteLine("All numbers in a list: "+formattedNumbers);
            Console.WriteLine("Results: "+ minimumResults);

            Console.ReadLine();        


        }
    }
}
