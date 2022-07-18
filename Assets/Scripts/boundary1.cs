using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class boundary1 : MonoBehaviour
{
    // Start is called before the first frame update

    public ScoreKeeper script;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
            print("4 runs scored");
            script.AddFourRuns();
        }
    }



}
