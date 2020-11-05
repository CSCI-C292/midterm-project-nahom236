using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;
    float movement = 0f;
    public float run = 10f;

    public HealthSystem p1Health;

    void Start()
    {
        GameObject p1 = GameObject.Find("HealthBarP1");
        p1Health = p1.GetComponent<HealthSystem>();
    }
    
    void OnTriggerEnter2D(Collider2D collider) 
    {

    }

    void Update()
    {
        
        movement = Input.GetAxisRaw("Horizontal") * run;
        animator.SetFloat("Speed", Mathf.Abs(movement));
        
        if (p1Health.isDone() == false) {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    Vector3 position = this.transform.position;
                    position.x--;
                    this.transform.position = position;
                    animator.SetBool("Punch", false);

                }
            if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    Vector3 position = this.transform.position;
                    position.x++;
                    this.transform.position = position;
                    animator.SetBool("Punch", false);
                }
       
            if (Input.GetKeyDown(KeyCode.Space))
                {
                    animator.SetBool("Punch", true);
                }
            }
        }
    }
