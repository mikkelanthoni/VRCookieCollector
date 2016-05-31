using UnityEngine;
using System.Collections;

public class CookieController : MonoBehaviour {

	public float coolDownTime;
	public Transform spawnPoint;
	public GameObject cookie;
	public int cookies;
	public float currecy;

	void Start () {
		StartCoroutine (CookieSpawn());	
	}

	IEnumerator CookieSpawn(){
		yield return new WaitForSeconds (coolDownTime);
			Instantiate (cookie, new Vector3(spawnPoint.transform.position.x,spawnPoint.transform.position.y, spawnPoint.transform.position.z),Quaternion.identity);
					StartCoroutine (CookieSpawn());			
	}



	public void CookiePerSecond (){
	
	
	}

}
