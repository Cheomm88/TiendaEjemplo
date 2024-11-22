using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wallet : MonoBehaviour
{
    public static Wallet instance;

    [SerializeField]
    float saldo;
    [SerializeField]
    TextMeshProUGUI labelSaldo;
    [SerializeField]
    TextMeshProUGUI labelConfirmacion;
    [SerializeField]
    GameObject confirmarCompra;
    [SerializeField]
    GameObject noSaldo;

    float precioObjetoQueCompro;
    // Start is called before the first frame update
    private void Awake()
    {
        if (Wallet.instance == null)
        {
            Wallet.instance = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void Start()
    {
        saldo = Random.Range(450f, 950f);
        labelSaldo.text = saldo.ToString("000.00") + " €";

    }

    public void InformarCompra(string nameItem, float precio)
    {
        if (saldo > precio)
        {
            labelConfirmacion.text = "¿Quieres comprar " + nameItem + " por " + precio + " €?";
            confirmarCompra.SetActive(true);
            precioObjetoQueCompro = precio;
        }
        else
        {
            noSaldo.SetActive(true);
        }
    }
    public void ConfirmarCompra()
    {
        if (saldo > precioObjetoQueCompro)
        {
            saldo = saldo - precioObjetoQueCompro;
            precioObjetoQueCompro = 0.0f;
            labelSaldo.text = saldo.ToString("000.00") + " €";
            confirmarCompra.SetActive(false);
        }
        else
        {
            confirmarCompra.SetActive(false);
            noSaldo.SetActive(true);
        }
    }
}
