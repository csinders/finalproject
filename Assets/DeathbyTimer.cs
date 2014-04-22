using UnityEngine;
using System.Collections;

public class DeathbyTimer : MonoBehaviour {
	public float ThisIsTheEnd = 5.0f;
	// public int blurEffect = 1;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > ThisIsTheEnd) {
			//Debug.Log("oh hai, dead.");
			StartCoroutine(DyingSequence());
		}
		
	
	}

	IEnumerator DyingSequence(){
		GetComponent<GrayscaleEffect>().enabled = true; 
		while( GetComponent<GrayscaleEffect>().rampOffset > -0.7){ 
			GetComponent<GrayscaleEffect>().rampOffset -= 0.0001f;
			yield return new WaitForSeconds(1f);
		}

	
		Application.LoadLevel("firstScene");

		
	}
}
