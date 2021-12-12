using System;
using System.Collections.Generic;
using System.Linq;

public class Anagram
{
    public string _baseword;
    List<string> trueMatches = new List<string>();
    
    public Anagram(string baseWord)
    {
        _baseword = baseWord.ToLower();
    }

    public string BaseWord
    {
        get { return _baseword.ToLower(); }
    }
    

    public string[] FindAnagrams(string[] potentialMatches)
    {
        int cont = 0;

            foreach(var word in potentialMatches)
            {   
                cont = 0;
                
                if(word.Length == BaseWord.Length)
                {

                    for(int i = 0; i < word.Length; i++)
                    {
                        for(int j = 0; j < BaseWord.Length; j++)
                        {
                            if(word.ToLower()[i] == BaseWord[j])
                            {
                                cont++;
                                i++;
                                j++;                                                                                                                      

                                if(cont==BaseWord.Length) 
                                {
                                    trueMatches.Add(word);
                                    cont = 0;
                                }                      
                            } 
                        } 
                    }
                } 
            }

       return trueMatches.ToArray();
    }

    public void print()
    {
        trueMatches.ForEach(item => Console.WriteLine(item));
    }
}