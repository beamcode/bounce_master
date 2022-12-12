using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermovement : MonoBehaviour {

    public CharacterController2D controller;

    public float runSpeed = 40f;

    float horizontalMove = 0f;
    bool jump = false;
    
    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D boom)
    {
        SceneManager.LoadScene("gameover");
    }
    void Update () {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
    
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate ()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
