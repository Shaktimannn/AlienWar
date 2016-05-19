using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public float run_speed, rotation_speed, handRot_Speed;
    public bool moveup, movedown, moveRight, moveLeft,StartUp,StartDown,StartRight,StartLeft,StartRotLeft,StartRotRight;
	public GameObject HandObj;
	Vector2 touchBegin0,touchInProgress0,touchBegin1,touchInProgress1;
	Vector3 velocity;
	//vv
	public CustomJoyStick _tpLeft,_tpRight;
	public float Rotationbounds,startRot,shoot_Timer,ShootTempTimer;
	public GameObject[] BulletGenPoint;
	public GameObject Rot_TargetGO,Body_Part;
	public static PlayerMovement Instance;
	public bool RotX_Axis, RotZ_Axis;
	// Use this for initialization
	void Start ()
	{
		Instance = this;
		moveup = moveRight = moveLeft = movedown = true;

		startRot = this.transform.rotation.y;

		shoot_Timer = ShootTempTimer;
	}
	
	// Update is called once per frame
	void Update ()
	{

						
		if (_tpLeft) {
			this.GetComponent<CharacterController>().Move(new Vector3(_tpLeft.inputVector.x,0,_tpLeft.inputVector.y)* run_speed * Time.deltaTime);	
		}
		if (_tpRight) {
			
			{
				if (_tpRight.inputVector.x != 0) {
					Shoot_Bullets ();
					if (RotX_Axis) {
						if (Rot_TargetGO.transform.localPosition.x > 1.5f) {
							Rot_TargetGO.transform.localPosition = new Vector3 (1.5f, 1.17f, 1.16f);// Rot_TargetGO.transform.localPosition.y, Rot_TargetGO.transform.localPosition.z);
						}
						if (Rot_TargetGO.transform.localPosition.x < -1.5f) {
							Rot_TargetGO.transform.localPosition = new Vector3 (-1.5f, 1.17f, 1.16f);//Rot_TargetGO.transform.localPosition.y, Rot_TargetGO.transform.localPosition.z);
						}
						if (Rot_TargetGO.transform.localPosition.x >= -1.5f && Rot_TargetGO.transform.localPosition.x <= 1.5f) {
							Rot_TargetGO.GetComponent<CharacterController> ().Move (new Vector3 ( _tpRight.inputVector.x, 0,0) * run_speed * Time.deltaTime);//.transform.position = new Vector3 ((Rot_TargetGO.transform.position.x + (_tpRight.inputVector.x *0.1f)),Rot_TargetGO.transform.position.y,Rot_TargetGO.transform.position.z);
						}
					}
					if (RotZ_Axis) {
						if (Rot_TargetGO.transform.localPosition.x > 1.5f) {
							Rot_TargetGO.transform.localPosition = new Vector3 (1.5f, 1.17f, 1.16f);// Rot_TargetGO.transform.localPosition.y, Rot_TargetGO.transform.localPosition.z);
						}
						if (Rot_TargetGO.transform.localPosition.x < -1.5f) {
							Rot_TargetGO.transform.localPosition = new Vector3 (-1.5f, 1.17f, 1.16f);//Rot_TargetGO.transform.localPosition.y, Rot_TargetGO.transform.localPosition.z);
						}
						if (Rot_TargetGO.transform.localPosition.x >= -1.5f && Rot_TargetGO.transform.localPosition.x <= 1.5f) {
							Rot_TargetGO.GetComponent<CharacterController> ().Move (new Vector3 (0, 0, _tpRight.inputVector.x) * run_speed * Time.deltaTime);//.transform.position = new Vector3 ((Rot_TargetGO.transform.position.x + (_tpRight.inputVector.x *0.1f)),Rot_TargetGO.transform.position.y,Rot_TargetGO.transform.position.z);
						}
					}
				}
				else {
					Rot_TargetGO.transform.localPosition = new Vector3 (0, Rot_TargetGO.transform.localPosition.y, Rot_TargetGO.transform.localPosition.z);
				}
				//Rot_TargetGO.transform.position=new Vector3((Rot_TargetGO.transform.position.x+_tpRight.inputVector.x*100)*rotation_speed*Time.deltaTime,Rot_TargetGO.transform.position.y,Rot_TargetGO.transform.position.z);
//				transform.Rotate (new Vector3 (0, _tpRight.inputVector.x/*Mathf.Clamp( _tpRight.inputVector.x,0.4f,1f)*/, 0) * rotation_speed * Time.deltaTime, Space.World);
//				if( _tpRight.inputVector.x!=0)

			}
		}

                                              
	}

	public void Shoot_Bullets()
	{
		if (shoot_Timer >ShootTempTimer) {
			shoot_Timer = 0;
			Generate_Bullet ();
		} else {
			shoot_Timer += Time.deltaTime;
		}
	}
	 void Generate_Bullet()
	{
		//Call Bullet to specified Bullet Generation Point.
		if (BulletGenPoint != null) {
			for (int i = 0; i < BulletGenPoint.Length; i++) {
				Bullet_PoolMgr.Instance.Get_PlayerBullet (BulletGenPoint[i].transform);
			}
		}
	}


}
