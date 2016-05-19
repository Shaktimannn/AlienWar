using UnityEngine;
using System.Collections;

public class Bullet_Destroy : MonoBehaviour {

	// Use this for initialization
	void OnEnable()
	{
		StartCoroutine (bull_Destroy ());

	}
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	IEnumerator bull_Destroy()
	{
		yield return new WaitForSeconds (2f);
		this.gameObject.SetActive (false);

	}
}
