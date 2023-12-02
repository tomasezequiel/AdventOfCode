using System;
using System.Collections.Generic;
using System.Text;

public class Program
{
    public static void Main()
    { 
        string filePath = "input.txt";

        try{
            using (StreamReader sr = new StreamReader(filePath)) {
                string line;
                int sum = 0;

                while ((line = sr.ReadLine()) != null){
                    sum =+ sum + GetFirstAndLastNumber(line);
                }
                Console.WriteLine(sum);
            }
        }catch (Exception e){
            Console.WriteLine("An error as occurred!");
        }

    }

    public static int GetFirstAndLastNumber(string phrase){
        var phraseArray = phrase.ToCharArray();
        StringBuilder sb = new StringBuilder();

        for(int i = 0; i < phraseArray.Length; i++){
            if(Char.IsDigit(phraseArray[i])){
                sb.Append(phraseArray[i]);
                break;
            }
        }

        Array.Reverse(phraseArray);

        for(int i = 0; i < phraseArray.Length; i++){
            if(Char.IsDigit(phraseArray[i])){
                sb.Append(phraseArray[i]);
                break;
            }
        }

        var final = int.Parse(sb.ToString());

        return final;
    }
}