using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControlScript : MonoBehaviour {

    public GameObject image1, image2, image3;

    public static int health;
	// Use this for initialization
	void Start () {
        health = 3;
        changeHealth(true, true, true);
    }
	
	// Update is called once per frame
	void Update () {

        switch (health)
        {
            case 3:
                changeHealth(true, true, true);
                break;
            case 2:
                changeHealth(true, true, false);
                break;
            case 1:
                changeHealth(true, false, false);
                break;
            case 0:
                changeHealth(false, false, false);
                SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
                break;
        }
		
	}

    void changeHealth(bool oneHeart, bool twoHeart, bool threeHeart)
    {
        image1.gameObject.SetActive(oneHeart);
        image2.gameObject.SetActive(twoHeart);
        image3.gameObject.SetActive(threeHeart);
    }
}
