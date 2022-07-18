using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneRun : MonoBehaviour
{
    public ScoreKeeper script;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            Destroy(other.gameObject);
            print("1 run scored");
            script.AddOneRun();
        }
    }

}
