using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class EnemyPool : MonoBehaviour {
	public int Enemies_No,poolSize;
	public GameObject poolObjs;
	public List<GameObject> enemyPool;
	// Use this for initialization
	void Start () {
		
		if (poolObjs != null) {
			for (int i = 0; i < poolSize; i++) {
				GameObject TempGO = (GameObject)Instantiate (poolObjs, this.gameObject.transform.position, this.gameObject.transform.rotation);
				TempGO.transform.parent = this.gameObject.transform;
				TempGO.SetActive (false);
				enemyPool.Add (TempGO);
			}
		}

		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
