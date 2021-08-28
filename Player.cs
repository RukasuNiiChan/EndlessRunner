using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private CharacterController controller;

    public float speed;
    public float jumpHeight;
    private float jumpSpeed;
    public float gravity;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.forward * speed;

        if (controller.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                jumpSpeed = jumpHeight;
            }
        }
        else
        {
            jumpSpeed -= gravity;
        }

        direction.y += jumpSpeed;
        controller.Move(direction * Time.deltaTime);
    }
}
