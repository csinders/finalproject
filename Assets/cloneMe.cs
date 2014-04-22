using UnityEngine;
using System.Collections;

public class cloneMe : MonoBehaviour {
	public int NumberOfCopies = 100; 
	public float offset = 7;

	void Start() {
		Destroy(this);
		for(int i = 1; i < NumberOfCopies; i++) {
			Instantiate(gameObject,new Vector3(transform.position.x, transform.position.y, transform.position.z + offset*i) , Quaternion.identity);
		}
	}
}