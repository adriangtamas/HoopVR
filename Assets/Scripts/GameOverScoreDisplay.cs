using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameOverScoreDisplay : MonoBehaviour
{

	Text text;
	ScoreAbsorber scoreAbsorber;

	// Use this for initialization
	void Start()
	{
		text = GetComponent<Text>();
		scoreAbsorber = FindObjectOfType<ScoreAbsorber>();
	}

	// Update is called once per frame
	void Update()
	{
		int currentScore = scoreAbsorber.score;
		text.text = "Score: " + currentScore;
	}
}