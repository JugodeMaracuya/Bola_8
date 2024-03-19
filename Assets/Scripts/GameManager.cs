using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public float Coins;
    public TextMeshProUGUI textoPuntosPro;

    public void sumarPuntos(float CoinsIn)
    {
        Debug.Log(CoinsIn);
        this.Coins += CoinsIn;
        textoPuntosPro.text = Coins.ToString();
    }
}
