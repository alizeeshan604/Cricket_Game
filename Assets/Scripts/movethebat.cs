using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movethebat : MonoBehaviour
{
    //public Quaternion mybat;
    public Vector3 target;
    public BoxCollider2D sweetpoint;
    public BoxCollider2D notsweet;


    void LateUpdate()
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
            Vector3 defaultlocation = new Vector3(0, 0, -30);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(defaultlocation), turnspeed2 * Time.deltaTime); 
            //transform.position = mybat.position;
            //transform.rotation = mybat.rotation;
        }

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (sweetpoint.IsTouching(other))
        {
            if (other.CompareTag("Ball"))
            {
                float force = 300;
                Vector3 dir = target - transform.position;
                //other.changeflag();
                other.GetComponent<Move>().enabled = false;
                other.GetComponent<Rigidbody2D>().velocity = dir.normalized * force;

            }
        }
        else if (notsweet.IsTouching(other))
        {
            if (other.CompareTag("Ball"))
            {
                float force = 50;
                Vector3 dir = target - transform.position;
                //other.changeflag();
                other.GetComponent<Move>().enabled = false;
                other.GetComponent<Rigidbody2D>().velocity = dir.normalized * force;

            }
        }
    }


}


