using UnityEngine;
using System.Collections;

public class MovingStair : MonoBehaviour {


	void Start() {

		rigidbody.AddForce(0,-2,0);

	}

	void Update(){


		this.transform.localScale += new Vector3(0.02f,0,0);

	}
}
