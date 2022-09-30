using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        // coin??
        if(other.gameObject.tag == "Coin")
        {
            GamePlayManager.Instance.AddScore();
            Destroy(other.gameObject, 0.02f);
        }
    }
}
