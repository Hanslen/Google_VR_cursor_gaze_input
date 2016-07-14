using UnityEngine;
using System.Collections;

public class MoveUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void MoveBoxUp(){
		transform.position += new Vector3(0f, 1f, 0f);
	}

}
