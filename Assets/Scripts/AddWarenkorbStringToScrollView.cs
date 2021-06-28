using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AddWarenkorbStringToScrollView : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textField;
    public Warenkorb warenkorb;

    void Start()
    {

    }

    void Update()
    {
        textField.SetText(warenkorb.getAlleBestellungen());
    }
}
