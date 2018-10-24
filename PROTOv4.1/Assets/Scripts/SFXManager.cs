using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXManager : MonoBehaviour {

    public AudioSource playerHurt;
    public AudioSource playerAttack;

    private static bool sfxmanExist;

	// Use this for initialization
	void Start () {
        if (!sfxmanExist)
        {
            sfxmanExist = true;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
