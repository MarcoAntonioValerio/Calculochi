using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class scp_ButtonsMethods : MonoBehaviour
{
    private scp_GameManager main;
    private scp_UiManager ui;

    private int howManyOperationsAmIDoing = 0;
    private int arrayPosition = 0;

    #region ADDITION BUTTON VARIABLES
    private bool iAmAdding = false;
    //This variable keeps track of how many times I have clicked the plus button
    private int howManyPlusPressed;
    #endregion

    #region SUBTRACTION BUTTON VARIABLES
    private bool iAmSubtracting = false;
    private int howManyMinusPressed;
    #endregion



    void Start()
    {
        main = GetComponent<scp_GameManager>();
        ui = GetComponent<scp_UiManager>();
    }

    private void Update()
    {
        Debug.Log("Array position is equal to " + arrayPosition.ToString());
        Debug.Log("The typed amount is " + main.typedAmount);
    }

   

    public void AdditionButton()
    {
        howManyOperationsAmIDoing++;

        if (howManyOperationsAmIDoing > 1)
        {
            main.total += main.typedAmount;
            ui.screenText.text = main.total.ToString();
        }

        if (howManyPlusPressed > 0)
        {

            main.typedAmount = 0f;
           
            howManyPlusPressed++;
            ui.screenText.text = main.total.ToString();
        }
        else
        {
            main.total = main.typedAmount;
            main.typedAmount = 0f;
            howManyPlusPressed++;
            ui.screenText.text = main.total.ToString();
        }

        

        iAmAdding = true;

    }

    public void SubtractionButton()
    {

        if (howManyOperationsAmIDoing > 1)
        {
            main.total -= main.typedAmount;
            ui.screenText.text = main.total.ToString("N0");
        }

        if (howManyMinusPressed > 0)
        {

            main.typedAmount = 0f;
            main.typedAmountArray.RemoveAll(i => i > 0);
            howManyMinusPressed++;
            ui.screenText.text = main.total.ToString("N0");
        }
        else
        {
            main.total = main.typedAmount;
            main.typedAmount = 0f;
            howManyMinusPressed++;
            ui.screenText.text = main.total.ToString("N0");
        }


        iAmSubtracting = true;

    }

    public void EqualButton()
    {
        howManyOperationsAmIDoing = 0;   
        if (iAmAdding == true)
        {
            main.total += main.typedAmount;
            iAmAdding = false;
            ui.screenText.text = main.total.ToString();
        }
        else if (iAmSubtracting == true)
        {
            main.total -= main.typedAmount;
            iAmSubtracting = false;
            ui.screenText.text = main.total.ToString();
        }
        Debug.Log("EqualFiring!");
        
    }    

    public void AcButton()
    {
        if (main.typedAmount != 0f)
        {
            
            main.typedAmount = 0f;
            howManyPlusPressed = 0;
            howManyMinusPressed = 0;
            
        }
        else
        {
            main.total = 0f;
            ui.screenText.text = main.total.ToString();
            howManyPlusPressed = 0;
            howManyMinusPressed = 0;
        }
        
    }


    //This method adds the value of the buttone to the list I have created.
    public void NumberButton(int value)
    {
        //NOT WORKING FULLY, IT STOPS AT 100 MILIONS
        //Trying to solve it.

        //This line adds the value of the button to the array
        main.typedAmountArray.Add(value);

        //this variable will be used in the foreach loop
        float total = 0;

        //The if statements prevents the foreach loop to run if the list is longer than 9 digits.  
        if (main.typedAmountArray.Count < 9)
        {
            //This foreach loop converts the typedAmountArray into a normal float
            //and does that by making that total equal to 10 times what number total is now
            //plus the number in the list the foreach loop is checking now.It will 
            //go through them all.
            foreach (int entry in main.typedAmountArray)
            {
                total = (10 * total) + entry;
                
                
            }
        }
        else return;
        
        main.typedAmount = total;
        ui.screenText.text = main.typedAmount.ToString("N0");
        
        
    }
}
