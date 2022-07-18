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
    //private bool flag = true;
   
  
    void Awake()
    {
        System.Random ran = new System.Random();
        movementSpeed.x = ran.Next(-130, -50);
    }
    void Update()
    {   
         transform.Translate(movementSpeed * Time.deltaTime, space);
    }
    
    //public void changeflag()
    //{
    //    flag = false; 
    //}
    
    


}
