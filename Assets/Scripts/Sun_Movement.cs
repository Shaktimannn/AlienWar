using UnityEngine;
using System.Collections;

public class Sun_Movement : MonoBehaviour {
	public float movement_speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.RotateAround (Vector3.left, movement_speed*Time.deltaTime);
	}
}
