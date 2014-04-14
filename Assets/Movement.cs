using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float ShakeAmount;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3(Random.Range(-ShakeAmount, ShakeAmount), Random.Range(-ShakeAmount, ShakeAmount),0);
	
	}
}
