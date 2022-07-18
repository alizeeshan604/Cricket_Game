using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SixScript : MonoBehaviour
{

    //public int Score;
    //public Text scorekeeper;
    public ScoreKeeper script;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
            print("6 runs scored");
            script.AddSixRuns();    
        }
    }


}
