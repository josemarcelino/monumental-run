using UnityEngine;
using System.Collections;

public class MapGenerator : MonoBehaviour {
	public GameObject MapPlate;
	public float timer;
	public float cd= 1;
	private bool gen = false;

	
	void FixedUpdate(){
				if (gen == false) {
						if (Time.time >= timer)
								gen = true;
				}
		}

	// Use this for initialization
	void Start () {
		Instantiate (MapPlate, new Vector3 (this.transform.position.x, this.transform.position.y, 1), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {

		if (gen == true) {
 			Instantiate (MapPlate, new Vector3 (this.transform.position.x, this.transform.position.y, 1), Quaternion.identity);
			timer = Time.time + cd;	
			gen = false;
		}
	}
}
