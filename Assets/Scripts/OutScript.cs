using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OutScript : MonoBehaviour
{
    public ScoreKeeper script;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
            print("You Are Out");
            script.Wicket();
        }
    }
}
