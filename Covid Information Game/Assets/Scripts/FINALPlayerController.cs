﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;


public class FINALPlayerController : MonoBehaviour
{
    public float speed = 0;


    private Rigidbody rb;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();


    }

    void OnMove(InputValue movementValue){
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }


    void FixedUpdate(){
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }


    private void OnTriggerEnter(Collider other){
        if(other.gameObject.CompareTag("Door1")){
            SceneManager.LoadScene(sceneName:"Mask");
             

        }
        if(other.gameObject.CompareTag("Door2")){
            SceneManager.LoadScene(sceneName:"Bus");

        }
        if(other.gameObject.CompareTag("Door3")){
            SceneManager.LoadScene(sceneName:"WorkRoom");

        }
        if(other.gameObject.CompareTag("Door4")){
            SceneManager.LoadScene(sceneName:"WashHands");

        }
    }
}
