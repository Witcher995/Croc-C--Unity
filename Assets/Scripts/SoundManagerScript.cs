using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour {

    public static AudioClip getCoinSound, themeMusic;
    public static AudioSource audioSource;

	// Use this for initialization
	void Start () {

        getCoinSound = Resources.Load<AudioClip>("PickCoin");
        themeMusic = Resources.Load<AudioClip>("CrocTheme");
        audioSource = GetComponent<AudioSource>();

		
	}
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "PickCoin":
                audioSource.PlayOneShot(getCoinSound);
                break;

        }
    }
}
