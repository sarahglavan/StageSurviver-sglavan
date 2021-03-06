﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
    private Rigidbody2D rb2d; //Store a reference to the Rigidbody2D component required to use 2D Physics.
    public float speed; //Floating point variable to store the player's movement speed.

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> (); //Get and store a reference to the Rigidbody2D component so that we can access it.
    }

    void FixedUpdate() //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //Store the current horizontal input in the float moveHorizontal.
        Vector2 movement = new Vector2(moveHorizontal, 0); //Use the two store floats to create a new Vector2 variable movement.
        rb2d.AddForce(movement * speed); //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
    }
}

//https://unity3d.com/de/learn/tutorials/projects/2d-ufo-tutorial/controlling-player