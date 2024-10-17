using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wallet : MonoBehaviour
{
    [SerializeField]
    float saldo;
    [SerializeField]
    TextMeshProUGUI labelSaldo;

    [SerializeField]
    GameObject confirmarCompra;
    [SerializeField]
    GameObject noSaldo;
    // Start is called before the first frame update
    void Start()
    {
        saldo = Random.Range(450f, 950f);
        labelSaldo.text = saldo.ToString("000.00") + " €";

    }

    public void RestarSaldo(float precio)
    {
        if (saldo > precio)
        {
            saldo -= precio;
            labelSaldo.text = saldo.ToString("000.00") + " €";
        }
        else
        {
            noSaldo.SetActive(true);
        }
    }
}
