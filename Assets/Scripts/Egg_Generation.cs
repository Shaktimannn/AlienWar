using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Egg_Generation : MonoBehaviour
{
	public int no_of_Cocks, rand_factor, random_factor, rand,RandomGrp,RandomTotalCount;
	public float time_gap, temp_time;
	public GameObject[] hens;
	// Use this for initialization
	void Start ()
	{
		//hens = GameObject.FindGameObjectsWithTag ("Hen");
		no_of_Cocks = hens.Length;
	}
	
	// Update is called once per frame
	void Update ()
	{
		//Completely Random
		//if (Timer.start_game == true && Timer.game_over == false) {
			if (no_of_Cocks > 0)
				random_factor = rand_factor / no_of_Cocks;
			if (temp_time > time_gap) {
				rand = Random.Range (1, rand_factor);
				for (int j=0,i=1; i<=no_of_Cocks; i++,j++) {
					if (rand <= (random_factor * i)) {
						/// Generate egg from i.th hen 
						//hens [j].gameObject.GetComponent<hen_eggs> ().lay_egg = true;
				
						temp_time = 0;
						break;
					}
				}
			} else {
				temp_time += Time.deltaTime;
			}
		//}
	//	Completely Random


		//New Random Logic
//		if (Timer.start_game == true && Timer.game_over == false) {
//			if (RandomTotalCount <= 0) {
//				ResetRandomVar ();
//			}
//			if (temp_time > time_gap) {
//				switch (RandomGrp) {
//				case 1:
//					rand = Random.Range (1, 1000);
//					if (rand <= 500) {
//						rand = 0;
//					} else if(rand>500) {
//						rand = 1;
//					}
//					for (int j=0; j<=1; j++) {
//						
//							/// Generate egg from i.th hen 
//						if (j == rand) {
//							hens [j].gameObject.GetComponent<hen_eggs> ().lay_egg = true;
//							//rand = 0;
//							RandomTotalCount--;
//							temp_time = 0;
//							break;
//						}
//
//					}
//					break;
//				case 2:
//					rand = Random.Range (1, 1000);
//					if (rand < 500) {
//						rand = 2;
//					} else if(rand>=500) {
//						rand = 3;
//					}
//					for (int j=2; j<=3; j++) {
//
//						/// Generate egg from i.th hen 
//						if (j == rand) {
//							hens [j].gameObject.GetComponent<hen_eggs> ().lay_egg = true;
//							//rand = 0;
//							RandomTotalCount--;
//							temp_time = 0;
//							break;
//						}
//
//					}
//					break;
//				}
//
//			} else {
//				
//				temp_time += Time.deltaTime;
//			}
//		}

		//New Random Logic
	}

	void ResetRandomVar()
	{
		RandomGrp = Random.Range (1, 3);
		RandomTotalCount = Random.Range (3, 5);
	}
}
