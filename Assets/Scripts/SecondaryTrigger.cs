using UnityEngine;
using System.Collections;

public class SecondaryTrigger : MonoBehaviour {

	Collider expectedCollider;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ExpectCollider(Collider collider)
	{
		expectedCollider = collider;
	
	}

	void OnTriggerEnter(Collider otherCollider)
	{
		if (otherCollider == expectedCollider)
		{
			ScoreKeeper scoreKeep = FindObjectOfType<ScoreKeeper>();
			scoreKeep.IncrementScore(1);
		}
	}
}
