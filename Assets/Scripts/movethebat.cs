using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movethebat : MonoBehaviour
{
    public float moveSpeed = 10;
    public Camera cam;

    void Update()
    {
        Vector2 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.MoveTowards(transform.position, mousePosition, moveSpeed * Time.deltaTime);
        
    }
    
}
