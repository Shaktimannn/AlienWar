using UnityEngine;
using System.Collections;

public class Enemy_Properties : MonoBehaviour {
	public float Health;
	[HideInInspector]
	public float InitHealth;
	// Use this for initialization
	void Awake()
	{
		InitHealth=Health;
	}
	void Start () {
		
	}
	void OnEnable()
	{
		Health=InitHealth;
	}
	// Update is called once per frame
	void Update () {
		if (Health <= 0) {
			DestroyEnemy ();
		}
	}

	void DestroyEnemy()
	{
		this.gameObject.SetActive (false);
	}

	public void Reduce_Health(float hlthRed)
	{
		Health -= hlthRed;
	}
}
