using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {

    public LevelManager levelManager;

    // Use this for initialization
    void OnTriggerEnter2D(Collider2D other)
    { 

        if (other.name == "Arrow") ;
        {

            Destroy(other.gameObject);
        }

        /*if (other.name == "Player") ;
        {

            Physics2D.IgnoreCollision(other.gameObject);
        }*/
    }
}
