using UnityEngine;
using System.Collections;

public class DeathbyTimer : MonoBehaviour {
	public float ThisIsTheEnd = 5.0f;
	public float blurEffect = 0.01f;

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
		while( GetComponent<Vignetting>().intensity < 6){
			GetComponent<Vignetting>().intensity += 0.001f;
			yield return new WaitForSeconds(0.01f);
		}

		// while( GetComponent<Blur>().blurIterations < 6){
		// 	GetComponent<Blur>().blurIterations += blurEffect;
		// 	yield return new WaitForSeconds(0.01f);
		// }
		

		Debug.Log("Something else");

		
	}
}
