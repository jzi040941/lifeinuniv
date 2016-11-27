using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class music_off : MonoBehaviour {

    // Use this for initialization
    AudioSource audio;

	void Start ()
    {
        audio = GetComponent<AudioSource>();
    }

    public void musicoff()
    {
        audio.Stop();
    }
}

