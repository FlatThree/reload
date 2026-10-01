using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollector : MonoBehaviour
{
    public TMP_Text textUI;
    int coinsCollected = 0;

    void Start() {
        textUI.text = "Coins: " + coinsCollected;
    }

    void OnTriggerEnter2D(Collider2D collision) {
        GameObject trigObject = collision.gameObject;

        if (trigObject.CompareTag("Coin")) {
            coinsCollected++;
            Debug.Log("Coin Collected - Total: " + coinsCollected);
            textUI.text = "Coins: " + coinsCollected;
            Destroy(trigObject);
        }
    }
    
}
