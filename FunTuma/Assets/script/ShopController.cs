using UnityEngine;
using System.Collections;

public class ShopController : MonoBehaviour {

	public GameObject shopPanel;
	public Canvas shopCanvas;
	public GameObject closeShopButton;
	public GameObject rightTopUIGroup;

	public void OnClickShopButton () 
	{
		Debug.Log ("Shop button clicked!");

		// load the scene
		openShop ();
	}

	void openShop ()
	{
		rightTopUIGroup.SetActive (false);
		shopPanel.SetActive (true);
		closeShopButton.SetActive (true);
		Time.timeScale = 0;
	}

	public void closeShop()
	{
		shopPanel.SetActive (false);
		closeShopButton.SetActive (false);
		rightTopUIGroup.SetActive (true);
		Time.timeScale = 1;
	}
}
