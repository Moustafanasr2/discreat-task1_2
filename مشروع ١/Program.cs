using System;
using System.Linq;

namespace Project_1
{
	public static class Program
	{
		public static void Main()
		{
        
        Console.Write("Enter num1: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter num2: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("From  " + num1 + " To " + num2 );
        for(int M = num1;M <= num2 ; M++ )
        {
         int c = 0;
           for(int j = 2; j <= M / 2 ; j++)
              if(M % j ==0)
              {
              	
              	 c++;
              	 break;
              	
              	
              }
           if(c == 0 && M != 1)
           {
           	Console.WriteLine(M);
           }
        	
        	
        }
        
        
         
		}
	}
}