using UnityEngine;
using System.Collections;

public class aniController : MonoBehaviour {
	
	private animateSprite aScript;
	
	// Use this for initialization
	void Start () {
		aScript = new animateSprite();
	}
	
	// Update is called once per frame
	void Update () {
		aScript.aniSprite(this.gameObject, 1, 1, 0, 0, 10, 10);
	}
}
