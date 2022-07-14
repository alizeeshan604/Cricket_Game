using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boundary1 : MonoBehaviour
{
    // Start is called before the first frame update


    private void OnTriggerEnter2D(Collider2D other) {
        if (other.CompareTag("Ball"))
        {
            print("Hi");
        }
}



}
