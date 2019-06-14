using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTextScript : MonoBehaviour {

    public Text text;
    public static int coinAmount;

	// Use this for initalization
	void Start () {
        text.GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        text.text = coinAmount.ToString();
		
	}
}
