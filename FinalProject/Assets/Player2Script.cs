﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Script : MonoBehaviour
{
    public Animator animator;
    float movement = 0f;
    public float run = 10f;
    public HealthSystem p2Health;
    public Timer _time;


    void Start()
    {
        GameObject go = GameObject.Find("HealthBar");
        p2Health =  go.GetComponent<HealthSystem>();

        GameObject time = GameObject.Find("TimeCountdown");
        _time = time.GetComponent<Timer>();
    }

    void OnTriggerEnter2D(Collider2D collider) 
    {


    }

    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal") * run;
        animator.SetFloat("Speed", Mathf.Abs(movement));

        if (p2Health.isDone() == false && _time.timeExpired() == false) {
            if (Input.GetKeyDown(KeyCode.A)) {
                Vector3 position = this.transform.position;
                position.x--;
                this.transform.position = position;
                animator.SetBool("Punch", false);
                animator.SetBool("Kick", false);
            }

            if (Input.GetKeyDown(KeyCode.D)) {
                Vector3 position = this.transform.position;
                position.x++;
                this.transform.position = position;
                animator.SetBool("Punch", false);
                animator.SetBool("Kick", false);
            }

            if (Input.GetKeyDown(KeyCode.Q))
            {
                animator.SetBool("Punch", true);
                animator.SetBool("Kick", false);
            }
            if (Input.GetKeyDown(KeyCode.W))
            {
                animator.SetBool("Kick", true);
                animator.SetBool("Punch", false);
            }
        }
    }

}
