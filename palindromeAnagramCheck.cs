/*
 This program will check 2 strings to see if they are palindromes, anagrams of eachother, or are none of the above.
*/
using System;
using System.Text;
 
public class Test
{
	public static void Main()
	{
		//status flags for the strings
		bool palindrome1;
		bool palindrome2;
		bool anagram;
 
		//get the strings to evaluate
		//not in requirements, but we should probably do some checking here for 
		//null vaule strings or strings that are only special characters
		Console.WriteLine("Enter string 1:");
		string string1 = Console.ReadLine();
		Console.WriteLine("Enter string 2:");
		string string2 = Console.ReadLine();
 
		//standardize the strings 
		string workingString1 = standardize(string1);
		string workingString2 = standardize(string2);
 
		//collect the strings in reverse
		string revString1 = reverse(workingString1);
		string revString2 = reverse(workingString2);
 
		//get the strings sorted by characters
		string ordString1 = sorted(workingString1);
		string ordString2 = sorted(workingString2);
 
		//analysis to see if we've got any palindromes or anagrams
		palindrome1 = isItTheSame(workingString1, revString1);
		palindrome2 = isItTheSame(workingString2, revString2);
		anagram = isItTheSame(ordString1, ordString2);
 
		//output the results
		resultsOutput(palindrome1, palindrome2, anagram, string1, string2);
 
	}
 
	public static string standardize (string stringToFix)
	{
		StringBuilder sb = new StringBuilder();
   		foreach (char c in stringToFix)
   		{
      		if ((c >= '0' && c <= '9') || (c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
      		{
         		sb.Append(c);
      		}
   		}
   		return sb.ToString().ToUpper();
	}
 
	public static string reverse (string forwardString)
	{
		char[] revChars = forwardString.ToCharArray();
    	Array.Reverse(revChars);
    	return new string(revChars);
	}
 
	public static string sorted (string normalString)
	{
		char[] sortChar = normalString.ToCharArray();
    	Array.Sort(sortChar);
    	return new string(sortChar);
	}
 
	public static bool isItTheSame(string stringFirst, string stringSecond)
	{
		if (stringFirst == stringSecond)
		{
			return true;	
		}	
		else
		{
			return false;
		}
	}
 
	public static void resultsOutput (bool pal1, bool pal2, bool ana, string st1, string st2)
	{
		if (pal1 && pal2 && ana)
		{
			Console.WriteLine(st1 + " and " + st2 + " are both palindromes and anagrams of eachother.\n");
		}
		else if (pal1 && ana)
		{
			Console.WriteLine(st1 + " is a palindrome and an anagram of " + st2 + ".\n");
		}
		else if (pal2 && ana)
		{
			Console.WriteLine(st2  + " is a palindrome and an anagram of " + st1 + ".\n");
		}
		else if (ana)
		{
			Console.WriteLine(st1 + " is an anagram of " + st2 + ".\n");
		}
		else if (pal1 && pal2)
		{
			Console.WriteLine(st1 + " and " + st2 + " are both palindromes.\n");
		}
		else if (pal1)
		{
			Console.WriteLine(st1 + " is a palindrome.\n");
		}
		else if (pal2)
		{
			Console.WriteLine(st2 + " is a palindrome.\n");
		}
		else
		{
			Console.WriteLine(st1 + " and " + st2 + " are neither palindromes nor anagrams of each other.\n");
		}
	}
 
}
