using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ShopManager : MonoBehaviour {
	public float cookieCurency;
	public float cookiesPerSec;

	public Text cpsText;
	public Text cookiesTOT;
	public float updateTime = 1;
	float counter;

	//Upgrade1
	public float baseCost1 = 10f;
	public float numberOwned1;
	public float finalCost1;
	//public Text upgradeText1;

	//Upgrade1
	public float baseCost2= 20f;
	public float numberOwned2;
	public float finalCost2;
	//public Text upgradeText2;

	void Update () {
		if (counter < updateTime) {
			counter += Time.deltaTime;
		} else {
			cookieCurency += cookiesPerSec * updateTime;
				counter = 0;
		}
		cpsText.text = "Cookies Per Second: " + cookiesPerSec;
		cookiesTOT.text = "Cookies: " + cookieCurency;	
	}

	public void Upgrade1(){
		if(numberOwned1 >0){
			finalCost1 = Mathf.Pow (1.15f, numberOwned1) * baseCost1;
				}
		finalCost1 = Mathf.Round (finalCost1);
		if(finalCost1 <= cookieCurency){
		cookiesPerSec += 1;
		cookieCurency -= finalCost1;
		//upgradeText1 = ("Price: ") + finalCost1;
		numberOwned1 += 1;
		}
	}

	public void Upgrade2(){

		if(numberOwned2 >0){
			finalCost2 = Mathf.Pow (1.15f, numberOwned2) * baseCost2;
		}
		finalCost2 = Mathf.Round (finalCost2);
		if(finalCost2 <= cookieCurency){
			Debug.Log (finalCost2);
			cookiesPerSec += 2;
			cookieCurency -= finalCost2;
			//upgradeText2 = ("Price: ") + finalCost2;
			numberOwned2 += 1;
		}
	}

}
