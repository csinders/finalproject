using UnityEngine;
using System.Collections;

public class levelMovement : MonoBehaviour {
	
	//next level
	public GameObject nextGameObject;
	
	// Starting depth of initial transition
	public float START_POINT = 20;
	
	// Boolean to detect whether the level is in the game or not
	public bool ACTIVE = false;
	
	private GameObject thisGameObject;
	
	// Use this for initialization
	void Start () {
		thisGameObject = this.gameObject;

		// Initially keep the level invisible if ACTIVE is false
		if(!ACTIVE) {
			foreach (Transform child in thisGameObject.transform)
		    {
		    	if(child.gameObject.name == "primaryLayer") {
					Vector3 temp = new Vector3(child.position.x, child.position.y - START_POINT, child.position.z);
					child.position = temp;
				}
				if(child.gameObject.name == "secondaryLayer") {
					Vector3 temp = new Vector3(child.position.x, child.position.y - (START_POINT*10), child.position.z);
					child.position = temp;
				}	    
		    }	
		}
	}
	
	// Update is called once per frame
	void Update () {
	}
}