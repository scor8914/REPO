using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VolumeManager : MonoBehaviour {

    public VolumeController[] voObjects;

    public float MaxVolumeLevel = 1.0f;
    public float currentVolumeLevel;

	// Use this for initialization
	void Start () {
        voObjects = FindObjectsOfType<VolumeController>();

        if(currentVolumeLevel > MaxVolumeLevel)
        {
            currentVolumeLevel = MaxVolumeLevel;
        }

        for(int i = 0; i < voObjects.Length; i++)
        {
            voObjects[i].SetAudioLevel(currentVolumeLevel);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
