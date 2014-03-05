using UnityEngine;
using System.Collections;

public class playerFour : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow) ) {
			GetComponent<Rigidbody> ().AddForce (transform.forward * 1f, ForceMode.VelocityChange);
		}
		if (Input.GetKey (KeyCode.DownArrow) ) {
			GetComponent<Rigidbody> ().AddForce (transform.forward * -1f, ForceMode.VelocityChange);
		}
		if (Input.GetKey (KeyCode.LeftArrow) ) {
			transform.Rotate ( new Vector3 (0f, -2f) );
		}
		if (Input.GetKey (KeyCode.RightArrow) ) {
			transform.Rotate ( new Vector3 (0f, 2f) );
		}
	}
}
