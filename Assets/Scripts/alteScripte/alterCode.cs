//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using Vuforia;

//public class Speisekarte : MonoBehaviour
//{
//    // Virtuelle Button
//    //public GameObject vb_Pizza;
//    //public GameObject vb_Hotdog;
//    //public GameObject vb_Burger;
//    //public GameObject vb_Pommes;

//    public String gericht;
//    public GameObject gericht3Dmodel;
//    public GameObject virtualButton;

//    // 3D Modelle


//    //public GameObject Pizza;
//    //public GameObject Hotdog;
//    //public GameObject Burger;
//    //public GameObject Pommes;


//    // will das sehen      
//    //bool pizza = false;
//    //bool hotdog = false;
//    //bool burger = false;
//    //bool pommes = false;

//    // ------> ALLES in Klasse auskommentiert das nur gebraucht wird um verhalten zu programmieren wenn Virtual Button Durchgehend gedrueckt werden muss


//    // Start is called before the first frame update
//    void Start()
//    {
//        //vb_Pizza = GameObject.Find("VirtualButton_Pizza");
//        //vb_Hotdog = GameObject.Find("VirtualButton_Hotdog");
//        //vb_Burger = GameObject.Find("VirtualButton_Burger");
//        //vb_Pommes = GameObject.Find("VirtualButton_Pommes");
//        virtualButton = GameObject.Find("VirtualButton_" + gericht);

//        virtualButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
//        virtualButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

//        //vb_Pizza.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed_Pizza);
//        //vb_Pizza.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

//        //vb_Hotdog.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed_Hotdog);
//        //vb_Hotdog.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

//        //vb_Burger.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed_Burger);
//        //vb_Burger.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

//        //vb_Pommes.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed_Pommes);
//        //vb_Pommes.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

//        gericht3Dmodel.SetActive(false);
//        //Pizza.SetActive(false);
//        //Hotdog.SetActive(false);
//        //Burger.SetActive(false);
//        //Pommes.SetActive(false);

//    }



//    // Update is called once per frame
//    void Update()
//    {

//        // Hier muss VirtualButton durchgehend mit Finger bedeckt bleiben
//        //if (pizza)
//        //{
//        //    Debug.Log("Pizza ist aktiv");
//        //}

//        //if (hotdog)
//        //{
//        //    Debug.Log("Hotdog ist aktiv");
//        //}

//        //if (burger)
//        //{
//        //    Debug.Log("Burger ist aktiv");
//        //}

//        //if (pommes)
//        //{
//        //    Debug.Log("Pommes ist aktiv");
//        //}
//    }

//    // Methoden wenn VirtualButton mit finger getriggert wird


//    private void OnButtonPressed(VirtualButtonBehaviour obj)
//    {
//        Debug.Log(gericht + " - Button pressed");
//        gericht3Dmodel.SetActive(true);
//    }


//    public void OnButtonPressed_Pizza(VirtualButtonBehaviour vb)
//    {
//        Debug.Log("Pizza - Button pressed");
//        //pizza = true;
//        //Pizza.SetActive(true);

//    }

//    public void OnButtonPressed_Hotdog(VirtualButtonBehaviour vb)
//    {
//        Debug.Log("Hotdog - Button pressed");
//        //hotdog = true;
//        //Hotdog.SetActive(true);
//    }

//    public void OnButtonPressed_Burger(VirtualButtonBehaviour vb)
//    {
//        Debug.Log("Burger - Button pressed");
//        //burger = true;
//        //Burger.SetActive(true);
//    }

//    public void OnButtonPressed_Pommes(VirtualButtonBehaviour vb)
//    {
//        Debug.Log("Pommes - Button pressed");
//        //pommes = true;
//        //Pommes.SetActive(true);
//    }

//    // Methode wenn ein beliebiger VirtualButton dann nicht mehr bedeckt ist

//    public void OnButtonReleased(VirtualButtonBehaviour vb)
//    {
//        Debug.Log("Button released");

//        //pizza = false;
//        //hotdog = false;
//        //burger = false;
//        //pommes = false;
//    }
//}