using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colum : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Player")) 
        {
            GameControler.Instance.BirdScore();
        }
    }
}
