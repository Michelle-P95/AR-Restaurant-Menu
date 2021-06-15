using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SpeisekartenManager : MonoBehaviour
{
    public GameObject[] dishesArray;
    public List<Dish> dishes;

    // Start is called before the first frame update
    void Start()
    {
        dishesArray = GameObject.FindGameObjectsWithTag("dish");
        for(int i = 0; i < dishesArray.Length; i++) {
            dishes.Add(new Dish(dishesArray[i].name,
            dishesArray[i], 
            GameObject.Find("VirtualButton_" + dishesArray[i].name)));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


/////////////////////////////////////////////////////////////
/////                     DISH CLASS                    /////
/////////////////////////////////////////////////////////////


public class Dish
{
    public string name;
    public GameObject dish3dModel;
    public GameObject dishVirtualButton;

    public Dish(string name, GameObject model, GameObject button) {
        this.name = name;
        this.dish3dModel = model;
        this.dishVirtualButton = button;
        DishSetUp();
    }

    private void DishSetUp() {
        dishVirtualButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        dishVirtualButton.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        dish3dModel.SetActive(false);
    }

    private void OnButtonPressed(VirtualButtonBehaviour obj)
    {
        if(dish3dModel.activeSelf) {
            dish3dModel.SetActive(false);
        } else {
           dish3dModel.SetActive(true); 
        }              
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button released");       
    }
}