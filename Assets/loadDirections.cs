using UnityEngine;
using System.Collections;

public class loadDirections : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}


void Update(){
    if(Input.GetMouseButtonDown(0))
    {
         Application.LoadLevel("directions");
        //Debug.Log("didthiswork?");
    }
}
}