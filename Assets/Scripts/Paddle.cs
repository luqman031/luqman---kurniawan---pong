using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
   public int speed;
   public KeyCode upKey;
   public KeyCode downKey; 
   private Rigidbody2D rig;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }


    private void Update()
    {
        MoveObject(GetInput());
    }


    private Vector2 GetInput()
    {
        
        if (Input.GetKey(upKey))
        {
          return Vector2.up * speed;  // gerakan ke atas
        }
        else if (Input.GetKey(downKey))
        {
           return Vector2.down * speed; // gerakan ke bawah
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        Debug.Log("Kecepatan Paddle : " + movement);
        rig.velocity = movement;
    }
}
