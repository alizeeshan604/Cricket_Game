using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movethebat : MonoBehaviour
{
    

    // Update is called once per frame
    [SerializeField]
    Transform target;
    float speed = 6f;
    Vector2 targetPos; 
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            targetPos = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPos.y = 0; // I fixed Y value to zero you may change this to value you want
            target.position = targetPos;
            if ((Vector2)transform.position != targetPos)
            {
                transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
            }
        }
    }   
    
}
