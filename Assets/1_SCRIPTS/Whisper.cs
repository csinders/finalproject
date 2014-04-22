using UnityEngine;
using System.Collections;

public class Whisper : MonoBehaviour {
	
	public AudioClip[] whispers;

	// Use this for initialization
	void Start () {
		
		audio.clip = whispers[ Random.Range( 0, whispers.Length ) ];
		audio.Play();
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if ( !audio.isPlaying ) {
			
			Destroy( gameObject, 5.0f );
			
		}
		
	}
}
