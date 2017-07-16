using UnityEngine;
using System.Collections;

public class PrimaryTrigger : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider collider)
	{
		SecondaryTrigger trigger = GetComponentInChildren<SecondaryTrigger>();
		trigger.ExpectCollider(collider);
	}
}
