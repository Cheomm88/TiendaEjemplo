using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ButtonShop : MonoBehaviour
{
   // [SerializeField]
    TextMeshProUGUI textButton;
    [SerializeField]
    string[] posiblesNombres;
    [SerializeField]
    string nameItem = "Objeto";
    [SerializeField]
    float priceItem;

    void Start()
    {
        //Elegir un nombre
        nameItem = posiblesNombres[Random.Range(0, posiblesNombres.Length)];
        // nameItem = ....

        textButton = transform.GetChild(0).GetComponent<TextMeshProUGUI>();
        priceItem = Random.Range(25f, 350f);
        textButton.text = nameItem + "\n" + priceItem.ToString() + " €";
    }

    public void ClickEnBotonDeTienda()
    {
        Wallet.instance.InformarCompra(nameItem, priceItem);
    }
}
