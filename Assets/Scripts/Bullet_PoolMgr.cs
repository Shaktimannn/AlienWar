using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class Bullet_PoolMgr : MonoBehaviour {
	public GameObject player_bullet;
	public int bulletPool_Count;
	public List<GameObject> Pl_Bullet_List;
	public static Bullet_PoolMgr Instance;
	// Use this for initialization
	void Awake()
	{
		Instance = this;
	}

	void Start () {
		if (player_bullet != null) {
			for (int i = 0; i < bulletPool_Count; i++) {
				GameObject temp = (GameObject)Instantiate (player_bullet, this.transform.position, this.transform.rotation);
				temp.SetActive (false);
				Pl_Bullet_List.Add (temp);
			}
			}

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Get_PlayerBullet(Transform pos)
	{
		//this.transform.position = pos.position;
		for (int i = 0; i < bulletPool_Count; i++) {
			if (Pl_Bullet_List [i].activeInHierarchy == false) {
				Pl_Bullet_List [i].transform.position = pos.position;
				Pl_Bullet_List [i].transform.rotation = PlayerMovement.Instance.Body_Part.transform.rotation;//pos.transform.localRotation;
				Pl_Bullet_List [i].SetActive (true);
				break;
			}
		}
	}
}
