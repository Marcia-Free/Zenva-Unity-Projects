using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float moveSpeed = 5;
    [SerializeField] public float jumpForce = 6;
    [SerializeField] public Rigidbody playerRig;

    private bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        //gets the horizontat and vertical inputs
        float x = Input.GetAxis("Horizontal") * moveSpeed;
        float z = Input.GetAxis("Vertical") * moveSpeed;

        //sets player velocity based on inputs
        playerRig.velocity = new Vector3(x, playerRig.velocity.y, z);

        //create a copy of our velocity variable and sets the Y axis to be 0
        Vector3 playerForce = playerRig.velocity;
        playerForce.y = 0;

        //if player is moving, rotate to face our moving direction
        if(playerForce.x != 0 || playerForce.z != 0)
        {
            transform.forward = playerForce;
        }

        //if Space is pressed player jumps
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            isGrounded = false;
            playerRig.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.contacts[0].normal == Vector3.up)
        {
            isGrounded = true;
        }
    }
}
