using UnityEngine;
using System.Collections;

public class MovingPlayer : MonoBehaviour {

	public static float speed = 10;
	
	void Update () {
	
		//move down
		if (Input.GetKey (KeyCode.RightArrow)) {
			if(this.transform.position.x < 8)
				this.transform.Translate (new Vector3 (1, 0, 0) * Time.deltaTime * speed);
		}
		
		//move right
		if (Input.GetKey (KeyCode.LeftArrow)) {
			if(this.transform.position.x > -8)
				this.transform.Translate (new Vector3 (-1, 0, 0) * Time.deltaTime * speed);

		}
	}
}