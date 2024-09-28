
using System;

public class ReversePattern
{
    public void Name()
    {
        string str = "GhANSHYAM"; //ORIGINAL STRING
        string reversedString = ""; // AA REVERSE STRING NE STORE KARVA MATE USE THAY 6

        for (int i = str.Length - 1; i >= 0; i--)//FOR LOOP STRING NE ULTA KARVA MATE
        {
            reversedString += str[i];//JE CHACHTER CHE ENE UNDHA ADD KARVA MATE
        }

        Console.WriteLine("Reversed String: " + reversedString); //RESLUT PRINT KARVA MATE
    }
}