using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowSpawner : MonoBehaviour {

    public  ArrowScript arrowPrefab;
    public float arrowSpeed;
    public float arrowDelay;
    public float time = 0;

    public bool fromLeft = false;
    public bool shoot;

    private Vector2 dir2;


	// Use this for initialization
	void Start () {
        dir2 = new Vector2(arrowSpeed, 10);
    }
	
	// Update is called once per frame
	void Update () {
	    if(shoot == true)
        {
            if(time < Time.time)
            {
                ArrowScript arrow = Instantiate(arrowPrefab, transform.position, transform.rotation) as ArrowScript;
                arrow.dir = dir2;
                time = Time.time + arrowDelay;
            }
        }
	}

    void OnriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Barrier")
        {
            Destroy(other.gameObject);
        }

    }

}
