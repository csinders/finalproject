using UnityEngine;
using System.Collections;

public class SlowDown : MonoBehaviour {
	public float deathSpeed = 0.001f;

void OnTriggerEnter(Collider other){
	if (other.name == "layer19") {
		Debug.Log("slow down");
		GetComponent<cameraMovement>().maxForwardSpeed = deathSpeed; 
		GetComponent<cameraMovement>().forwardSpeed = deathSpeed; 
	}
	
	}
}