using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public TextManager textManager;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            textManager.AddCoins();
            Destroy(gameObject);
        }
    }
}