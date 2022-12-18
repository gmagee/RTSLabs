using System;
using System.Collections;
					
public class Program
{
	public static void Main()
	{
		
		Console.WriteLine(stringRotation("HelloWorld", 4) + "\n");
		
		int[] myNumList = {10, 5, 30, 40, 22, 6, 4, 0, 3, 9, -2};
		
		var myHash = new Hashtable();
		myHash = aboveBelow(myNumList, 9);
		
		foreach(DictionaryEntry de in myHash)
		Console.Write("{0}: {1} ", de.Key, de.Value + " ");		
		
}

	public static Hashtable aboveBelow(int[] numArray ,int compareint ){
		
		//accepts two arguments:  An unsorted collection of integers (the list) and an integer (the comparison value)

		//returns a Hashtable with the keys "above" and "below" with the corresponding count of integers from the list that are above or below the comparison value
	
		int above = 0;
		int below = 0;
		
		foreach (int i in numArray){
			if(i > compareint){
				above++;
			}else if (i < compareint){
				below++;
			}			
		}		
		
		Hashtable compare = new Hashtable();
		compare.Add("Above", above); 
		compare.Add("Below", below);
	
		return compare;
	}
	
	public static String stringRotation(string myString , int rotationAmount){	
		
		//accepts two arguments:  a string (the original string) and a positive integer (the rotation amount)
		//returns a new string, rotating the characters in the original string to the right by the rotation amount and have the overflow appear at the beginning

		string output = string.Concat(myString.Substring(rotationAmount, myString.Length - rotationAmount),  myString.Substring(0, rotationAmount));
		
		return output;
		
	}	
	
}

	


	
	
