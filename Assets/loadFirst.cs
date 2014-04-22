using UnityEngine;
using System.Collections;

public class loadFirst : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	void Update(){
    	if(Input.GetMouseButtonDown(0)){

         	Application.LoadLevel("firstScene");
        //Debug.Log("didthiswork?");
   
		}
	}
}