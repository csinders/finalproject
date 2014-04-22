using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Footsteps : MonoBehaviour {
	
	AudioSource audioSource;
	public AudioClip[] footsteps;
	public AudioClip[] splashes;
	
	public Transform whisperPrefab;
	
	CharacterMotor motor;
	
	List<Collider> puddles = new List<Collider>();
	
	float footstepThreshold = 1.0f;
	Vector3 lastFootstepPosition;
	
	float whisperThreshold = 1.0f;
	Vector3 lastWhisperPosition;
	bool whisperFlip = false;
	
	// Use this for initialization
	void Start () {
		
		audioSource = gameObject.AddComponent( "AudioSource" ) as AudioSource;
		
		lastFootstepPosition = transform.position;
		lastWhisperPosition = transform.position;
		
		motor = GetComponent<CharacterMotor>();
	}
	
	// Update is called once per frame
	void Update () {
	
		if ( Vector3.Distance( lastFootstepPosition, transform.position ) > footstepThreshold ) {
			
			audioSource.PlayOneShot( footsteps[ Random.Range( 0, footsteps.Length ) ] );
			
			if ( puddles.Count > 0 ) {
				audioSource.PlayOneShot( splashes[ Random.Range( 0, splashes.Length ) ] );
			}
			
			lastFootstepPosition = transform.position;
		}
		
		if ( motor.movement.velocity.magnitude > motor.movement.maxForwardSpeed - .15f &&
			Vector3.Distance( lastWhisperPosition, transform.position ) > whisperThreshold ) {
			
			Vector3 offset = Vector3.forward * 3.0f + Vector3.left * ( whisperFlip ? -2.0f : 2.0f );
			Vector3 whisperPosition = transform.position + Quaternion.FromToRotation( Vector3.forward, motor.movement.velocity ) * offset;
			Instantiate( whisperPrefab, whisperPosition, Quaternion.identity );
			
			lastWhisperPosition = transform.position;
			whisperFlip = !whisperFlip;
		}
		
	}
	
	void OnTriggerEnter( Collider other ) {
		
		if ( other.name.Contains( "puddle" ) ) {
			
			puddles.Add( other );
			
		}
		
	}
	
	void OnTriggerExit( Collider other ) {
		
		if ( other.name.Contains( "puddle" ) ) {
			
			puddles.Remove( other );
			
		}
		
	}
}
