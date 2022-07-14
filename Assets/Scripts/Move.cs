using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static System.Random;
//using System.random;

public class Move : MonoBehaviour
{
    public Vector3 movementSpeed; //1
    public Space space; //2
    private bool flag = true;
   
  
    void Awake()
    {
        System.Random ran = new System.Random();
        movementSpeed.x = ran.Next(-130, -50);
    }
    void Update()
    {
        
           
            transform.Translate(movementSpeed * Time.deltaTime, space);
    }
    public void changeflag()
    {
        flag = false; 
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
