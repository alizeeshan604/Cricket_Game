using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movethebat : MonoBehaviour
{
    //public Quaternion mybat;
    public Vector3 target;
    public BoxCollider2D sweetpoint;
    public BoxCollider2D notsweet;


    void Update()
    {
        if (Input.GetKeyDown("up"))
        {
            //int turnSpeed = 12000;
            //Vector3 targetRotation = new Vector3(0, 0, 70);
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(targetRotation), turnSpeed * Time.deltaTime);
            MoveUp();
        }

        if (Input.GetKeyDown("down"))
        {
            //int turnspeed2 = 12000;
            //Vector3 defaultlocation = new Vector3(0, 0, -30);
            //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(defaultlocation), turnspeed2 * Time.deltaTime); 
            //transform.position = mybat.position;
            //transform.rotation = mybat.rotation;
            MoveDown();
        }



    }

    public void MoveUp()
    {
        int turnSpeed = 12000;
        Vector3 targetRotation = new Vector3(0, 0, 70);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(targetRotation), turnSpeed * Time.deltaTime);
    }

    public void MoveDown()
    {
        int turnspeed2 = 12000;
        Vector3 defaultlocation = new Vector3(0, 0, -30);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(defaultlocation), turnspeed2 * Time.deltaTime);
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        print("check");
        print(other.collider.gameObject);
        if (sweetpoint.IsTouching(other.collider))
        {
            print("check1");
            if (other.collider.CompareTag("Ball"))
            {
                float force = 100;
                //Vector3 dir = target - transform.position; //which direction the ball will travel after being hit
                //other.changeflag();
                Vector3 dir = other.contacts[0].point - (Vector2)other.transform.position;
                // We then get the opposite (-Vector3) and normalize it
                dir = -dir.normalized;
                //print(dir);
                Vector2 stamp = new Vector2(Mathf.Abs((dir * force).x), Mathf.Abs((dir * force).y));
                print(stamp);
                other.collider.GetComponent<Move>().enabled = false;
                other.collider.GetComponent<Rigidbody2D>().velocity = stamp;

            }
        }
        else if (notsweet.IsTouching(other.collider))
        {
            print("check1");
            if (other.collider.CompareTag("Ball"))
            {
                float force = 50;
                //Vector3 dir = target - transform.position;
                //other.changeflag();
                Vector3 dir = other.contacts[0].point - (Vector2)other.transform.position;
                // We then get the opposite (-Vector3) and normalize it
                dir = -dir.normalized;
                //print(dir);
                Vector2 stamp = new Vector2(Mathf.Abs((dir * force).x), Mathf.Abs((dir * force).y));
                print(stamp);
                other.collider.GetComponent<Move>().enabled = false;
                other.collider.GetComponent<Rigidbody2D>().velocity = stamp;
            }
        }
    }


}


