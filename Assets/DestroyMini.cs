using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMini : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MiniHeart"))
        {
            Destroy(gameObject); // Destroy the game object if triggered by an object with the specified tag
        }
    }
}
