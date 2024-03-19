using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Monea : MonoBehaviour
{
   public GameObject ObjPuntos;
   public float puntosQueDa;

   private void OnTriggerEnter(Collider collision)
   {
        if(collision.gameObject.CompareTag("Player"))
        {
            ObjPuntos.GetComponent<GameManager>().Coins += puntosQueDa;
            Destroy(gameObject);
        }
   }
   
}