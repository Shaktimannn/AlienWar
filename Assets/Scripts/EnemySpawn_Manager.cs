using UnityEngine;
using System.Collections;

public class EnemySpawn_Manager : MonoBehaviour {

	public int no_of_spawnPoints, rand_factor, random_factor, rand,RandomGrp,RandomTotalCount;
	public float time_gap, temp_time;
	public GameObject[] SpawnPts;
	// Use this for initialization
	void Start ()
	{
		
		no_of_spawnPoints = SpawnPts.Length;
	}

	// Update is called once per frame
	void Update ()
	{
		//Completely Random
				//if (Timer.start_game == true && Timer.game_over == false) {
		if (no_of_spawnPoints > 0)
			random_factor = rand_factor / no_of_spawnPoints;
					if (temp_time > time_gap) {
						rand = Random.Range (1, rand_factor);
			for (int j=0,i=1; i<=no_of_spawnPoints; i++,j++) {
							if (rand <= (random_factor * i)) {
								/// Generate Enemy from i.th Spawn Point
								//Gen_Point [j].gameObject.GetComponent<hen_eggs> ().lay_egg = true;
						
								temp_time = 0;
								break;
							}
						}
					} else {
						temp_time += Time.deltaTime;
					}
				//}
	}
}
