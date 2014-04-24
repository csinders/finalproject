using UnityEngine;
using System.Collections;

public class audioTrigger : MonoBehaviour {

public AudioSource audio; 

void OnTriggerEnter(){
        audio.Play();
    }


// void OnTriggerExit(){ 
//         audio.Pause();
//     }
}

