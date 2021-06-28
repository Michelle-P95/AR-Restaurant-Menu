using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MenuManager : MonoBehaviour
{

    public ActiveDishKeeper activeDishKeeper;
    public Warenkorb warenkorb;
    public GameObject warenkorbTextField;
    
    private TextMeshProUGUI dishName_Text;
    private GameObject backgroundPanel;
    private GameObject[] dishUIsArray; // dishUIs is searching for GameObjects with Tag dishUI !!!! 
    private GameObject activeDishUI;
    private GameObject bestellButton, warenkorbAddButton, warenkorbButton, backButton, buyButton;
    private GameObject bestellungDoneUI;

    private bool warenkorbIsOpen;

    private string fullBestellung, optionsAsString;

    void Start()
    {
        backgroundPanel = GameObject.Find("BackgroundPanel");
        dishName_Text = backgroundPanel.GetComponentInChildren<TextMeshProUGUI>();
        dishUIsArray = GameObject.FindGameObjectsWithTag("dishUI");
        bestellButton = GameObject.Find("Button_Bestellen");
        warenkorbAddButton = GameObject.Find("Button_AddToKorb");
        warenkorbButton = GameObject.Find("Button_Warenkorb");
        backButton = GameObject.Find("Button_Zurueck");
        buyButton = GameObject.Find("Button_Buy");
        bestellungDoneUI = GameObject.Find("BestellungDone_UI");

        backgroundPanel.SetActive(false);
        backButton.SetActive(false);
        warenkorbAddButton.SetActive(false);
        warenkorbTextField.SetActive(false);
        buyButton.SetActive(false);
        bestellungDoneUI.SetActive(false);

        warenkorbIsOpen = false;

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
            // Debug.Log("Bestellen gedrückt mit aktivem Gericht: " + activeDishKeeper.activeDishName);
            for (int i = 0; i < dishUIsArray.Length; i++)
            {
                if (activeDishKeeper.activeDishName + "_UI" == dishUIsArray[i].name)
                {
                    Debug.Log("DISH UI WAS FOUND.");
                    dishUIsArray[i].SetActive(true);
                    activeDishUI = dishUIsArray[i];
                }
                ActivateDishUI();
            }
        }
        else
        {
            Debug.Log("Bestellen gedrückt ohne Gericht");
        }
    }

    public void BestellenAbbrechen() // gehe zurück zu Speisekarte ohne Gericht zum Warenkorb hinzuzufügen
    {
        if (warenkorbIsOpen)
        {
            DeactivateWarenkorbUI();
            bestellungDoneUI.SetActive(false);
        }
        else
        {
            DeactivateUI();
        }
    }

    public void AddToWarenkorb()
    {
        Debug.Log("AddToWarenkorb");
        GameObject[] dishOptions = GameObject.FindGameObjectsWithTag("dishOption");
        for (int i = 0; i < dishOptions.Length; i++)
        {
            // Debug.Log(dishOptions[i].name);
            optionsAsString += " - " + dishOptions[i].GetComponent<DishOption>().fullText + "\n";
        }
        fullBestellung = activeDishKeeper.activeDishName + "\n" + optionsAsString;
        // Debug.Log(fullBestellung);
        warenkorb.bestellungen.Add(fullBestellung);
        ResetBestellungStrings();
        DeactivateUI();
    }

    public void ShowWarenkorb()
    {
        ActivateWarenkorbUI();
        Debug.Log(warenkorb.getAlleBestellungen());
    }

    public void BuyBestellungen()
    {
        // sende String des Warenkorbs an Küche, damit sie wissen, was sie zubereiten sollen
        Debug.Log("Bestellung wurde aufgegeben und wir nun zubereitet.");
        bestellungDoneUI.SetActive(true);
    }

    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////

    private void ActivateWarenkorbUI()
    {
        backgroundPanel.SetActive(true);
        backButton.SetActive(true);
        warenkorbButton.SetActive(false);
        bestellButton.SetActive(false);
        warenkorbTextField.SetActive(true);
        buyButton.SetActive(true);

        warenkorbIsOpen = true;
    }

    private void DeactivateWarenkorbUI()
    {
        backgroundPanel.SetActive(false);
        backButton.SetActive(false);
        warenkorbButton.SetActive(true);
        bestellButton.SetActive(true);
        warenkorbTextField.SetActive(false);
        buyButton.SetActive(false);

        warenkorbIsOpen = false;
    }

    private void ActivateDishUI()
    {
        backgroundPanel.SetActive(true);
        dishName_Text.SetText(activeDishKeeper.activeDishName);
        warenkorbAddButton.SetActive(true);
        backButton.SetActive(true);
        bestellButton.SetActive(false);
        warenkorbButton.SetActive(false);
    }

    private void DeactivateUI()
    {
        backgroundPanel.SetActive(false);
        dishName_Text.SetText("");
        warenkorbAddButton.SetActive(false);
        backButton.SetActive(false);
        bestellButton.SetActive(true);
        activeDishUI.SetActive(false);
        warenkorbButton.SetActive(true);
        activeDishUI = null;
    }

    private void ResetBestellungStrings()
    {
        fullBestellung = "";
        optionsAsString = "";
    }
}
