using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{

    public ActiveDishKeeper activeDishKeeper;

    private GameObject backgroundPanel;
    private GameObject[] dishUIsArray; // dishUIs is searching for GameObjects with Tag dishUI !!!! 
    private GameObject activeDishUI;
    private GameObject bestellButton, warenkorbButton;

    void Start()
    {
        backgroundPanel = GameObject.Find("BackgroundPanel");
        dishUIsArray = GameObject.FindGameObjectsWithTag("dishUI");
        bestellButton = GameObject.Find("Button_Bestellen");
        warenkorbButton = GameObject.Find("Button_AddToKorb");

        backgroundPanel.SetActive(false);
        warenkorbButton.SetActive(false);

        for (int i = 0; i < dishUIsArray.Length; i++)
        {
            dishUIsArray[i].SetActive(false);
        }
    }

    void Update()
    {

    }

    public void Bestellen()
    {
        if (activeDishKeeper.dishActive)
        {
            Debug.Log("Bestellen gedrückt mit aktivem Gericht: " + activeDishKeeper.activeDishName);
            for (int i = 0; i < dishUIsArray.Length; i++)
            {
                if (activeDishKeeper.activeDishName + "_UI" == dishUIsArray[i].name)
                {
                    Debug.Log("DISH UI WAS FOUND.");
                    dishUIsArray[i].SetActive(true);
                    activeDishUI = dishUIsArray[i];
                }
                ActivateUI();
            }
        }
        else
        {
            Debug.Log("Bestellen gedrückt ohne Gericht");
        }
    }

    public void BestellenAbbrechen() // gehe zurück zu Speisekarte ohne Gericht zum Warenkorb hinzuzufügen
    {
        DeactivateUI();
    }

    public void AddToWarenkorb()
    {
        Debug.Log("AddToWarenkorb");
        // TODO: 
    }

    private void ActivateUI()
    {
        backgroundPanel.SetActive(true);
        warenkorbButton.SetActive(true);
        bestellButton.SetActive(false);
    }

    private void DeactivateUI() {
        backgroundPanel.SetActive(false);
        warenkorbButton.SetActive(false);
        bestellButton.SetActive(true);
        activeDishUI.SetActive(false);
        activeDishUI = null;
    }
}
