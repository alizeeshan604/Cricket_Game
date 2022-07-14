using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
    public string tagFilter;

    private void OnTriggerEnter2D(Collider2D other) // 1
    {
        
        if (other.CompareTag(tagFilter)) // 2
        {
            Destroy(gameObject); // 3
        }
    }

}
