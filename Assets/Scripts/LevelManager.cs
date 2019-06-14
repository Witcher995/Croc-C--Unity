using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    private Player player;

    public GameObject curCheckpoint;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<Player>();
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RespawnPlayer()
    {
        Debug.Log("Player respawn");
        player.transform.position = curCheckpoint.transform.position;
    }
}
