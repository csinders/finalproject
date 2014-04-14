using UnityEngine;
using System.Collections;

public class ChangeColorOnTrigger : MonoBehaviour {
	public Color highlightColor = Color.red; 

	// Use this for initialization
	void OnTriggerEnter () {
		renderer.material.color = highlightColor;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
