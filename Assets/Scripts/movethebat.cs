using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movethebat : MonoBehaviour
{
    public float maxTurnSpeed = 90;
    public float smoothTime = 0.3f;
    float angle;
    float currentVelocity;
    public Camera cam;


    void Update()
    {


        int turnSpeed = 60;
        int moveSpeed = 30;
        Vector3 mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - transform.position;
        float angle = Vector2.SignedAngle(Vector2.right, direction);
        Vector3 targetRotation = new Vector3(0, 0, angle);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(targetRotation), turnSpeed * Time.deltaTime);
        transform.position = Vector2.MoveTowards(transform.position, mousePosition, moveSpeed * Time.deltaTime);
    }
}
    

