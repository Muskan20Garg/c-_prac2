using System;  
namespace abc
{
  public class Factorial
   {  
     public static void Main(string[] args)  
      {  
       int i,fact=1,number;      
       Console.Write("Enter any Number: ");      
       number= int.Parse(Console.ReadLine());     //reading the input from console.
       for(i=1;i<=number;i++){      
        fact=fact*i;      
       }      
       Console.Write("Factorial of " +number+" is: "+fact);    
     } 
 }

  }  