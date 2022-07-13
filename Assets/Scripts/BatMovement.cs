using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatMovement : MonoBehaviour
{
    //[SerializeField]
    public Transform target;
    //float speed = 6f;
    //Vector2 targetPos;
    public GameObject batPrefab;
    //int depth = 5;
    //public Transform batspawnpoint;
    // Update is called once per frame

    void Start()
    {
        //Debug.Log(target.position);
        Instantiate(batPrefab, target.position, Quaternion.identity);
    }
    
    
    
    
}
