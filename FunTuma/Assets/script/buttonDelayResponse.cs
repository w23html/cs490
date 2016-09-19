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
		if (responseTime == this.counter) {
			ResetCounter ();
			Debug.Log (true);
		}
	}

	void ResetCounter(){
		counter = 0;
	}

	public void OnPointerEnter(PointerEventData eventData){
		isPointerEnter = true;
	}

	public void OnPointerExit(PointerEventData eventData){
		isPointerEnter = false;
		this.ResetCounter ();
	}

}
