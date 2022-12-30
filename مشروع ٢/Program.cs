using System;
using System.Linq;

namespace Project_2
{
	public static class Program
	{
		public static void Main()
		{
   
   
        
           Console.Write("Enter num1: ");
           int num1 = int.Parse(Console.ReadLine());
           Console.Write("Enter num2: ");
           int num2 = int.Parse(Console.ReadLine());
           for(int M = num1;M <= num2 ;M++)
           {
           	 
           	  if(isperfect(M))
           	  {
           	  	Console.WriteLine(M);
           	  }
           	 
           }
			
  }	  
  static bool isperfect(int num)
  {
 	 int sum = 0;
 	   for(int M = 1 ; M < num ; M++)
 	   {
 	  	 if(num % M ==0)
 	  	 {
 	  		sum += M;
 	  	 }
 	   }
 	   return sum ==num;
  }
		   
   
   
   
   
   
   
   
		
	    }
	  
    }
   



    