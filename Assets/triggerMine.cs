using UnityEngine;
using System.Collections;

public class triggerMine : MonoBehaviour {

		public Color dark = Color.black;
		public Color bright = Color.white; 


 		public float[] explosionTimes;
  		public float fadeRate = 0.2f;

  		private int explosionIndex = 0;


	// Use this for initialization
	void OnTriggerEnter(){

			//Debug.Log("blah blah explosion, new scene");
     Application.LoadLevel("firstScene");
       
     }
   

}
