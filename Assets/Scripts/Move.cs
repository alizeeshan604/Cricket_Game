using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Vector3 movementSpeed; //1
    public Space space; //2

    void Update()
    {
        transform.Translate(movementSpeed * Time.deltaTime, space);
    }


}
