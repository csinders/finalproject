using UnityEngine;
using System.Collections;

public class loadCrash : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
void Update(){
    if(Input.GetMouseButtonDown(0))
    {
         Application.LoadLevel("crash_scene");
        //Debug.Log("didthiswork?");
    }
}
}
