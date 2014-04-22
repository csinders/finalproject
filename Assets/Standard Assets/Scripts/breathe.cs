using UnityEngine;
using System.Collections;

public class breathe : MonoBehaviour {
	public AudioClip[] breathes;


	// Use this for initialization
	void Start () {
		
		InvokeRepeating("playBreathe", 33, 5);
	
	}
	

	void playBreathe(){
		audio.clip = breathes[ Random.Range( 0, breathes.Length ) ];
		audio.Play();

	}
}