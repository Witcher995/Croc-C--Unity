using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour {
    Rigidbody2D rb;
    public Vector2 dir = new Vector2(0, 0);
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        rb.velocity = dir;
	}

    void OnriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Barrier")
        {
            Destroy(other.gameObject);
        }

    }

}
