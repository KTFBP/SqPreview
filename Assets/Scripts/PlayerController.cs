using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;

public class PlayerController : MonoBehaviour
{
    public CharacterController characterController;
    public float speed = 6;

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move(){
        float horizontalMove = Input.GetAxis("Horizontal");
        float verticalMove = Input.GetAxis("Vertical");

        // Vector3 move = transform.forward * verticalMove + transform.right * horizontalMove;
        // characterController.Move(speed * Time.deltaTime * move);
        Vector3 deltaMove = new Vector3(-horizontalMove, 0, -verticalMove) * speed * Time.deltaTime;
        characterController.Move(deltaMove);
    }
}
