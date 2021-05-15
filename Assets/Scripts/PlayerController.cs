using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 5;
    [SerializeField] public Rigidbody playerRig;


    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;
        playerRig.velocity = new Vector3(x, playerRig.velocity.y, z);

        Vector3 playerForce = playerRig.velocity;
        playerForce.y = 0;

        if(playerForce.x != 0 || playerForce.z != 0)
        {
            transform.forward = playerForce;
        }

    }
}
