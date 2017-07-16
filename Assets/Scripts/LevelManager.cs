using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public float timeTilNextLevel = 0.0f;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if (timeTilNextLevel > 0)
		{
			timeTilNextLevel -= Time.deltaTime;
			//print("Time left:" + timeTilNextLevel);
			if (timeTilNextLevel < 0)
			{
				LoadNextScene();
			}
		}

	}

	public void LoadNextScene()
	{
		//Load Scene
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		// Load currentIndex + 1
		SceneManager.LoadScene(currentIndex + 1);
	}

	public void LoadPreviousScene()
	{
		//Load Scene
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		// Load currentIndex + 1
		SceneManager.LoadScene(currentIndex - 1);
	}
}
