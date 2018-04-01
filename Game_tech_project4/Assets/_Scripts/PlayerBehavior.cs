using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;

public class PlayerBehavior : NetworkBehaviour {

	public float speed = 5.0f;
	public Text myText;

	// Use this for initialization
	void Start () {
		myText = GameObject.Find("Result").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if(!isLocalPlayer){
			return;
		}
		float h = Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
		transform.Translate (h,0,0);
		float v = Input.GetAxis ("Vertical") * Time.deltaTime * speed;
		transform.Translate (0,0,v);
		if(Input.GetKeyDown(KeyCode.Space)){
			transform.Translate (0,50.0f*Time.deltaTime, 0);
		}
	}

	void OnCollisionEnter(Collision collision) 
	{
		if (collision.collider.tag == "friend") {
			myText.text = "you find your friend!";
		}
	}
}
