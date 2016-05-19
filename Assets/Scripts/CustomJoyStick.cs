using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;
public class CustomJoyStick : MonoBehaviour,IDragHandler,IPointerUpHandler,IPointerDownHandler{
	//whaat tha fuck joustick Huhahahahaha Finally Did It;
	public Image bgImg,joyStick_Img;
	public Vector3 inputVector;
	[Range(0.1f,1f)]
	public float sensitivity;
	public static CustomJoyStick Instance;
	public bool J_XDirection=true, J_YDirection=true;

	void Awake()
	{
		Instance = this;
	}
	public void OnPointerDown(PointerEventData ped)
	{
		
	}
	public void OnPointerUp(PointerEventData ped)
	{
		joyStick_Img.rectTransform.anchoredPosition=new Vector3(0,0,0);
		inputVector = new Vector3 (0, 0, 0);
	}
	public void OnDrag(PointerEventData ped)
	{
		Vector2 pos;
		if (RectTransformUtility.ScreenPointToLocalPointInRectangle (bgImg.rectTransform, ped.position, ped.pressEventCamera, out pos)) {
			pos.x = (pos.x / (bgImg.rectTransform.sizeDelta.x/3));
			pos.y = (pos.y / (bgImg.rectTransform.sizeDelta.y/3));
			if (J_XDirection == true && J_YDirection == true) {
				inputVector = new Vector3 (pos.x * sensitivity, pos.y * sensitivity, 0);
			} else {
				if (J_XDirection == true)
					inputVector = new Vector3 (pos.x * sensitivity, 0, 0);// pos.y*sensitivity,0 );
				if (J_YDirection == true)
					inputVector = new Vector3 (0, pos.y * sensitivity, 0);
			}
			inputVector = (inputVector.magnitude > 1.0f) ? inputVector.normalized : inputVector;
			//print (inputVector);
			//Move Joystick
			joyStick_Img.rectTransform.anchoredPosition=new Vector3(inputVector.x*(bgImg.rectTransform.sizeDelta.x),inputVector.y*(bgImg.rectTransform.sizeDelta.y));
		}

	}
	public void OnBeginDrag(PointerEventData ped)
	{
		print ("BeginDrag");
	}
	public void OnEndDrag(PointerEventData ped)
	{
		print ("EndDrag");
	}
	public float Horizontal()
	{
	//	if (inputVector.x != 0) {
			return inputVector.x;
		//}
	}

	public float Vertical()
	{
		if (inputVector.y > 0) {
			return inputVector.y;
		} else {
			return 0;
		}
	}
}
