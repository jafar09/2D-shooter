using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Star : MonoBehaviour
{
    public int livesToAdd = 1; // Qo'shiladigan hayot miqdori

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // Tag yordamida tekshirish
        {
            // Jon qo'shish
            Health playerHealth = other.GetComponent<Health>();
            if (playerHealth != null)
            {
                playerHealth.AddLife(livesToAdd); 
                Debug.Log("Life added!");


               
                // Ob'ektni yo'q qilish
                Destroy(gameObject);
            }
        }
    }
}