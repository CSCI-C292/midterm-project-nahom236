using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HitBoxManager : MonoBehaviour
{

    public PlayerMovement player1;
    public Player2Script player2;
    public BoxCollider2D frame;
    private BoxCollider2D[] colliders;
    public HealthSystem p2Health;
    public HealthSystem p1Health;




    public enum hitBoxes
    {
        Colliding,

    }

    private void Update() {

    }

   

    void Start()
    {
        GameObject go = GameObject.Find("HealthBar");
        p2Health =  go.GetComponent<HealthSystem>();

        GameObject p1 = GameObject.Find("HealthBarP1");
        p1Health = p1.GetComponent<HealthSystem>();

        p1Health.SetMaxHealth(100);
        p2Health.SetMaxHealth(100);

        GameObject p = GameObject.Find("Player");
        player1 = p.GetComponent<PlayerMovement>();

        GameObject p2 = GameObject.Find("Player2");
        player2 = p2.GetComponent<Player2Script>();

        colliders = new BoxCollider2D[]{frame};
    
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(this.CompareTag("Player"))       
        {
            if(col.CompareTag("Player2")) {
                p2Health.decreaseHealth(20);
                if (p2Health.isDone()==true) {
                    player2.animator.SetBool("KO", true);
                    

                }
            }
        }

        if(this.CompareTag("Player2"))
        {
            if(col.CompareTag("Player")) {
                p1Health.decreaseHealth(20);
                if (p1Health.isDone() == true) {
                    player1.animator.SetBool("KO", true);
                }
            }  
        }
        
    }

    public void setHitBox(hitBoxes num)
    {

    }

}