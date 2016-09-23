using UnityEngine;
using System.Collections;

public class ShopController : MonoBehaviour {

	public Canvas shopCanvas;

	// Use this for initialization
	void Start () 
	{
		openShop ();
	}

	void openShop()
	{
		shopCanvas.enabled = true;
		Time.timeScale = 0;
	}

	public void closeShop()
	{
		shopCanvas.enabled = false;
		Time.timeScale = 1;
	}
}
