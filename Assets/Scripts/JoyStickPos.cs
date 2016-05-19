using UnityEngine;
using System.Collections;

public class JoyStickPos : MonoBehaviour {
	public float x_offset, y_offset;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (Screen.width /x_offset, Screen.height / y_offset, 0);
	}
}
