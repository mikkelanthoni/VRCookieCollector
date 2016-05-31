using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class CookieMover : MonoBehaviour {

	//CookiesComponent
	public Rigidbody rb;
	public float moveSpeed = 1f;
	ShopManager shopManager;


	void Start () {
		shopManager = GameObject.FindGameObjectWithTag ("CookieManager").GetComponent<ShopManager> ();
	}



	void OnCollisionStay(Collision col){
		if (col.gameObject.name == ("Transporter")) {
			rb.velocity = new Vector3 (moveSpeed, rb.velocity.y, rb.velocity.z);

		}
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.name == ("Box")) {
			shopManager.cookieCurency += 1;
			Destroy (gameObject);
		}

	}
}
