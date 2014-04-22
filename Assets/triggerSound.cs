using UnityEngine;
using System.Collections;

public class triggerSound : MonoBehaviour {


	void OnTriggerEnter(Collider otherObj){
    	if (otherObj.tag == "Main Camera")
   		 {

        //audio.Play();
   		 	Debug.Log("audio here");

    	}

    else {
        audio.Stop();
    	}
	}
}

