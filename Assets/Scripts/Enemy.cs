using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    private float speed = 1;
    public LayerMask enemyMask;
    Rigidbody2D myBody;
    Transform myTrans;
    float myWidth, myHeight;
    public LevelManager levelManager;

    public Transform weakness;

    // Use this for initialization
    void Start()
    {
        myTrans = this.transform;
        myBody = this.GetComponent<Rigidbody2D>();
        SpriteRenderer mySprite = this.GetComponent<SpriteRenderer>();
        myWidth = this.GetComponent<SpriteRenderer>().bounds.extents.x;
        myHeight = this.GetComponent<SpriteRenderer>().bounds.extents.y;
        levelManager = FindObjectOfType<LevelManager>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        Vector2 lineCastPos = myTrans.position.toVector2() - myTrans.right.toVector2() * myWidth + Vector2.up * myHeight;
        Debug.DrawLine(lineCastPos, lineCastPos + Vector2.down);
        bool isGrounded = Physics2D.Linecast(lineCastPos, lineCastPos + Vector2.down *2, enemyMask);
 

        if (!isGrounded)
        {
            Vector3 currRot = myTrans.eulerAngles;
            currRot.y += 180;
            myTrans.eulerAngles = currRot;
        }

        Vector2 myVel = myBody.velocity;
        myVel.x = -myTrans.right.x * speed;
        myBody.velocity = myVel;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            float height = collision.contacts[0].point.y - weakness.position.y;
            if(height > 0)
            {
                Dies();
                collision.rigidbody.AddForce(new Vector2(0, 200));

            }
            else
            {
                GameControlScript.health -= 1;
                levelManager.RespawnPlayer();
            }
        }


    }

    /*Enemy enemy = collision.collider.GetComponent<Enemy>();
        if (enemy != null)
        {
            GameControlScript.health -= 1;
            //levelManager.RespawnPlayer();
        }*/


void Dies()
    {
        Destroy(this.gameObject);
    }
}