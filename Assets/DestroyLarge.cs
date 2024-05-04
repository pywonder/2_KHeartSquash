using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyLarge : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LargeHeart"))
        {
            Destroy(gameObject); // Destroy the game object if triggered by an object with the specified tag
        }
    }
}
