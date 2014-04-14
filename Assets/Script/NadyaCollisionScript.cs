using UnityEngine;
using System.Collections;

public class NadyaCollisionScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		Debug.Log (collision.gameObject.name);
		Destroy (collision.gameObject);
	}
}
