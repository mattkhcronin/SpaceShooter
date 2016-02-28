using UnityEngine;
using System.Collections;

public class LaserControls : MonoBehaviour {
	
	void Update () {
		if (this.GetComponent<Renderer>().isVisible){
			Destroy(this);
		}
	}
}
