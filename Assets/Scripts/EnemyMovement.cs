using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {
	public NavMeshAgent Enemy_NavAgent;
	public Transform Target;
	// Use this for initialization
	void Start () {
		Enemy_NavAgent = this.gameObject.GetComponent<NavMeshAgent> ();

	}
	
	// Update is called once per frame
	void Update () {
		Enemy_NavAgent.SetDestination (Target.transform.position);
	}

}
