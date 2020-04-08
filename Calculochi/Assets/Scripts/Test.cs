using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private string input = "abcd";
    private string output = "";

    private char[] charArray;

    // Start is called before the first frame update
    void Start()
    {
        //feeding the reversed string to the empty output variable
        output = StringReverser(input);
        //printing the result in the console
        Debug.Log(output);

    }

    private string StringReverser(string s)
    {
        
        //makes charArray equal to a new char array that is as long as whatevwer string you imput
        charArray = new char[s.Length];
        //Int to set starting point 
        int forward = 0;

        //every round of the for loof i decrease, and forward increases
        //this makes sure that letter order is reversed.
        for (int i = s.Length - 1; i >= 0; i--)
        {
            charArray[forward++] = s[i];
        }

        //this lines returns a new string made of the sum of the char in charArray
        return new string(charArray) ;
    }

}
