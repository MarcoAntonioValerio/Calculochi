using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scp_GameManager : MonoBehaviour
{
    //                  TODO
    //1-CALCULATOR TYPED AMOUNT NEEDS TO FIT IN AN ARRAY.
    //2-NEED TO FIND A WAY TO DYNAMICALLY INCREASE THE SIXE TO UP TO 9.
    //3-TYPED NUMBERS WILL NEED TO FILL THE ARRAY IN SEQUENTIAL POSITIONS.
    //4-RESET THE ARRAY TO STARTING LENGHT, AND VALUE WHEN ANY OTHER BUTTON
    //  THAT IS NOT A NUMBER BUTTON IS PRESSED.
    //5-MIGHT NEED TO BREAK IT DOWN IN MULTIPLE LISTS.


    private scp_ButtonsMethods utilities;

    public float total = 0f;
    public float typedAmount;
    public float amount_B;

    
    public List<int> typedAmountArray;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<scp_ButtonsMethods>();  
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    
}
