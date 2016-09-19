using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class buttonDelayResponse : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler {

	private int counter;
	private readonly int responseTime = 200;
	private bool isPointerEnter;
	// Use this for initialization
	void Start () {
		counter = 0;
		isPointerEnter = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (isPointerEnter) {
			counter++;
		}
		if (isPointerEnter && responseTime == this.counter) {
			ResetCounter ();
			GameObject obj = this.transform.parent.FindChild("dropDownButtonGroup").gameObject;
			obj.SetActive (true);
			//GameObject.Find ("dropDownButtonGroup").SetActive(true);
		}


	}

	void ResetCounter(){
		counter = 0;
	}

	public void OnPointerEnter(PointerEventData eventData){
		Debug.Log ("Enter");
		isPointerEnter = true;
	}

	public void OnPointerExit(PointerEventData eventData){
		isPointerEnter = false;
		Debug.Log ("Leave");
		this.ResetCounter ();
	}


}
