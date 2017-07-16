using UnityEngine;
using System.Collections;

public class BallLauncher : MonoBehaviour {

	public float ballSpeed = 20.0f;
	public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1"))
		{
			GameObject instance = Instantiate(ballPrefab);
			instance.transform.position = transform.position;
			//instance.transform.rotation = transform.rotation;
			Rigidbody rb = instance.GetComponent<Rigidbody>();
			Camera camera = GetComponentInChildren<Camera>();
			Vector3 forwardDirection =  camera.transform.rotation * Vector3.forward;
			rb.velocity = forwardDirection * ballSpeed;
		}

	}
}
