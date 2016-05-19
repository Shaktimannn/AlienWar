using UnityEngine;
using System.Collections;

public class RotateTowards : MonoBehaviour {
	public Transform target;
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetDir = target.position - transform.position;
		targetDir.y = 0;
		float step = speed * Time.deltaTime;
		Vector3 newDir = Vector3.RotateTowards(transform.forward, targetDir, step, 0.0F);
		Debug.DrawRay(transform.position, newDir, Color.red);
		//transform.rotation = Quaternion.LookRotation(newDir);
		Quaternion Q1 = Quaternion.LookRotation(newDir);
		transform.rotation = Quaternion.Slerp(transform.rotation, Q1, Time.deltaTime * speed);

	}
}
