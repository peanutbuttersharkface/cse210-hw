// C# program to censor a word
// with asterisks in a sentence
using System;
using System.Collections.Generic;
     
class Program
{
 
// Function takes two parameter
static String censor(String text,
                     String word)
{
 
    // Break down sentence by ' ' spaces
    // and store each individual word in
    // a different list
    String[] word_list = text.Split(' ');
 
    // A new string to store the result
    String result = "";
 
    // Creating the censor which is an asterisks
    // "*" text of the length of censor word
    String stars = "";
    for (int i = 0; i < word.Length; i++)
        stars += '_';
 
    // Iterating through our list
    // of extracted words
    int index = 0;
    foreach (String i in word_list)
    {
        if (i.CompareTo(word) == 0)
 
            // changing the censored word to
            // created asterisks censor
            word_list[index] = stars;
        index++;
    }
 
    // join the words
    foreach (String i in word_list)
        result += i + " ";
 
    return result;
}
 
// Driver code
public static void Main(String[] args)
{
    String extract = "GeeksforGeeks is a computer science "+
                     "portal for geeks. I am pursuing my " +
                     "major in computer science. ";
    String cen = "computer";
    Console.WriteLine(censor(extract, cen));
}
  
}