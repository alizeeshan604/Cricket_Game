using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
    public Vector3 movementSpeed; //1
    public Space space; //2

    void Update()
    {
        transform.Translate(movementSpeed * Time.deltaTime, space);
        
    }
    private void OnTriggerEnter(Collider other)
    {
        print("Hi");
    }
    //public void OnCollisionEnter(Collision other)
    //{
    //    print("Here");
    //    // how much the character should be knocked back
    //    var magnitude = 5000;
    //    // calculate force vector
    //    var force = transform.position - other.transform.position;
    //    // normalize force vector to get direction only and trim magnitude
    //    force.Normalize();
    //    gameObject.GetComponent<Rigidbody2D>().AddForce(force * magnitude);
    //}


}
