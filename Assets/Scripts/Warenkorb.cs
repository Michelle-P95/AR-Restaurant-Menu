using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warenkorb : MonoBehaviour
{
    public MenuManager menuManager;
    public List<string> bestellungen;

    private string alleBestellungen;

    void Start()
    {
        bestellungen.Clear();
    }

    void Update()
    {

    }

    public string getAlleBestellungen()
    {
        alleBestellungen = "";
        foreach (string bestellung in bestellungen)
        {
            alleBestellungen += "\n" + bestellung;
        }
        return alleBestellungen;
    }
}