using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerTransform : NetworkBehaviour {
	[SyncVar]private Vector3 serverPostion;

	public float speed = 5.0f;



	[Command]
	void CmdPostion(Vector3 position){
		serverPostion = position;
	}

	void Start(){
		this.transform.position = new Vector3 (Random.Range(-9.5f,9.5f),1.0f,Random.Range(-9.5f,9.5f));
	}

	void FixedUpdate(){
		if (isLocalPlayer) {
			CmdPostion (this.transform.position);
		} else {
			FixedPosition ();
		}
	}

	void FixedPosition(){
		transform.position = Vector3.Lerp (this.transform.position, serverPostion, speed * Time.fixedDeltaTime);
	}

}
