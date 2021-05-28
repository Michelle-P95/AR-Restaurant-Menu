using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Speisekarte : MonoBehaviour
{

    public GameObject vb_Pizza;
    public GameObject vb_Hotdog;
    public GameObject vb_Burger;
    public GameObject vb_Pommes;

    // will das sehen  
    bool pizza = false;
    bool hotdog = false;
    bool burger = false;
    bool pommes = false;


    // Start is called before the first frame update
    void Start()
    {
        vb_Pizza = GameObject.Find("VirtualButton_Pizza");
        vb_Hotdog = GameObject.Find("VirtualButton_Hotdog");
        vb_Burger = GameObject.Find("VirtualButton_Burger");
        vb_Pommes = GameObject.Find("VirtualButton_Pommes");

        vb_Pizza.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed_Pizza);
        vb_Pizza.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        vb_Hotdog.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed_Hotdog);
        vb_Hotdog.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        vb_Burger.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed_Burger);
        vb_Burger.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        vb_Pommes.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed_Pommes);
        vb_Pommes.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    }

    // Update is called once per frame
    void Update()
    {

        // Hier muss VirtualButton durchgehend mit Finger bedeckt bleiben
        if (pizza)
        {
            Debug.Log("Pizza ist aktiv");
        }

        if (hotdog)
        {
            Debug.Log("Hotdog ist aktiv");
        }

        if (burger)
        {
            Debug.Log("Burger ist aktiv");
        }

        if (pommes)
        {
            Debug.Log("Pommes ist aktiv");
        }
    }

    // Methoden wenn VirtualButton mit finger getriggert wird

    public void OnButtonPressed_Pizza(VirtualButtonBehaviour vb)
    {
        Debug.Log("Pizza - Button pressed");
        pizza = true;
    }

    public void OnButtonPressed_Hotdog(VirtualButtonBehaviour vb)
    { 
        Debug.Log("Hotdog - Button pressed");
        hotdog = true;
    }

    public void OnButtonPressed_Burger(VirtualButtonBehaviour vb)
    {
        Debug.Log("Burger - Button pressed");
        burger = true;
    }

    public void OnButtonPressed_Pommes(VirtualButtonBehaviour vb)
    {
        Debug.Log("Pommes - Button pressed");
        pommes = true;
    }

    // Methode wenn ein beliebiger VirtualButton dann nicht mehr bedeckt ist

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button released");

        pizza = false;
        hotdog = false;
        burger = false;
        pommes = false;
    }
}