using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

   private const float PLAYER_SPEED = 20;
    private bool Alive = true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
    
    }

    private void FixedUpdate()
    {

        //moving controls

        if(Alive)
        {
            float moveX = 0;
            float moveY = 0;

            if (Input.GetKey(KeyCode.D)) moveX += 1;
            if (Input.GetKey(KeyCode.A)) moveX -= 1;
            if (Input.GetKey(KeyCode.W)) moveY += 1;
            if (Input.GetKey(KeyCode.S)) moveY -= 1;

            Vector2 newVelocity = new Vector2(moveX, moveY).normalized * PLAYER_SPEED;

            GetComponent<Rigidbody2D>().velocity = newVelocity;
        }
    }
}
