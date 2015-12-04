using UnityEngine;
using System.Collections;

public class ShotDown : MonoBehaviour {
	public GameObject prefShot = null;

	public void shotDown() {
		Instantiate(prefShot, transform.position, Quaternion.identity);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
