using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShooterScript : MonoBehaviour
{
    public GameObject ballPrefab; // 1
    public Transform ballspawnpoint; // 2
    public float shootInterval; // 3
    private float shootTimer; // 4

    private void ShootBall()
    {

        Instantiate(ballPrefab, ballspawnpoint.position, Quaternion.identity);
    }

    private void UpdateShootball()
    {
      
        shootTimer -= Time.deltaTime; // 1

        if (shootTimer <= 0) // 2
        {
            shootTimer = shootInterval; // 3
            ShootBall(); // 4
        }

    }

    // Update is called once per frame
    void Update()
    {
        UpdateShootball();   
    }
}
