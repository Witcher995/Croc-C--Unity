using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieArrow : MonoBehaviour {
    public LevelManager levelManager;

    // Use this for initialization
    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            
            GameControlScript.health -= 1;
            levelManager.RespawnPlayer();
           
        }

    }
 }