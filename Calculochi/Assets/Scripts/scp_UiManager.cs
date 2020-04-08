using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scp_UiManager : MonoBehaviour
{
    public Text screenText;
    private scp_GameManager main;

    // Start is called before the first frame update
    void Start()
    {
        Initialisation();
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void Initialisation()
    {
        main = GetComponent<scp_GameManager>();

        screenText = GameObject.Find("ScreenText").GetComponent<Text>();
        screenText.text = main.total.ToString();
    }
}
