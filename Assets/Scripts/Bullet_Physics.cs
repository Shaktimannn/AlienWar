using UnityEngine;
using System.Collections;

public class Bullet_Physics : MonoBehaviour {
	public float force,bulletStrength;
	// Use this for initialization
	void OnEnable()
	{
		//Add Force on Bullet
		//this.transform.rotation=new Quaternion(0,1,0,0);
		this.GetComponent<Rigidbody> ().velocity=Vector3.zero;
		this.GetComponent<Rigidbody> ().angularVelocity = Vector3.zero;
			AddBulletForce();
	}
	void Start () {
	
	}
	void OnDisable()
	{
		//this.GetComponent<Rigidbody>().
		this.transform.rotation = Quaternion.identity;
	}
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.A))
			{
			AddBulletForce ();
				
			}
	}

	public void AddBulletForce()
	{
		this.GetComponent<Rigidbody> ().AddForce(transform.forward*force);
		//this.GetComponent<Rigidbody> ().useGravity = true;
	}

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag.Contains ("Enemy")) {
			//col.gameObject.GetComponent<Rigidbody> ().AddForce(transform.forward*1);
			//print ("EnemyHit");
			col.gameObject.GetComponent<Enemy_Properties>().Reduce_Health(bulletStrength);
			this.gameObject.SetActive (false);
		}
	}
}
