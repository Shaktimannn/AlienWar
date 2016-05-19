using UnityEngine;
using System.Collections;

public class Cam_Movement : MonoBehaviour {
	public GameObject Player;
	[HideInInspector]
	public float temp_timer;
	public float x_Offset, z_Offset,timer,speed;
	public bool BlockZAxis;
	[HideInInspector]
	public Vector3 target_trans;
	public bool Smoothfollow=false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Smoothfollow) {
			if (BlockZAxis == false) {
				target_trans = new Vector3 (Player.transform.position.x - x_Offset, this.transform.position.y, Player.transform.position.z - z_Offset);
				float step = speed * Time.deltaTime;
				transform.position = Vector3.MoveTowards (transform.position, target_trans, step);
			} else {
				target_trans = new Vector3 (Player.transform.position.x - x_Offset, this.transform.position.y, z_Offset);
				float step = speed * Time.deltaTime;
				transform.position = Vector3.MoveTowards (transform.position, target_trans, step);
			}
		} else {
			if (BlockZAxis == false) {
				transform.position = new Vector3 (Player.transform.position.x - x_Offset, this.transform.position.y, Player.transform.position.z - z_Offset);
//				float step = speed * Time.deltaTime;
//				transform.position = Vector3.MoveTowards (transform.position, target_trans, step);
			} else {
				transform.position = new Vector3 (Player.transform.position.x - x_Offset, this.transform.position.y, z_Offset);
//				float step = speed * Time.deltaTime;
//				transform.position = Vector3.MoveTowards (transform.position, target_trans, step);
			}
		}

	}
}
