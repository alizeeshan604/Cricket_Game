using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movethebat : MonoBehaviour
{
    public Transform mybat;
    public Vector3 target;
    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            int turnSpeed = 12000;
            Vector3 targetRotation = new Vector3(0, 0, 70);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(targetRotation), turnSpeed * Time.deltaTime);
        }

        if (Input.GetKeyDown("down"))
        {
            int turnspeed2 = 12000;
            Vector3 defaultlocation = new Vector3(0, 0, 5);
            transform.rotation = Quaternion.RotateTowards(mybat.rotation, Quaternion.Euler(defaultlocation), turnspeed2 * Time.deltaTime); ;
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ball"))
        {
            float force = 100;
            Vector3 dir = target - transform.position;
            //other.changeflag();
            other.GetComponent<Move>().enabled = false;
            other.GetComponent<Rigidbody2D>().velocity = dir.normalized * force;
            
        }
    }


}


