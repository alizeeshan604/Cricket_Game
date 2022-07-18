using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoRuns : MonoBehaviour
{
    public ScoreKeeper script;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
            print("2 runs scored");
            script.AddTwoRuns();
        }
    }
}
