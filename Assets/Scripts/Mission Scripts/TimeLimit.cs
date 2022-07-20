using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeLimit : MonoBehaviour
{
	//public Text timerText;
	public TextMeshProUGUI TimerText;

	public float totalTime;
	int seconds;
	int End = 0;

	// Use this for initialization
	void Start()
	{
		//TimerText = GetComponent<TextMeshProUGUI>();
	}

	// Update is called once per frame
	void Update()
	{
		totalTime -= Time.deltaTime;
		seconds = (int)totalTime;
		TimerText.text = seconds.ToString();


		if (totalTime < 1)
		{
			totalTime = 0;
			Limit();
			//this.gameObject.SetActive(true);
			SceneManager.LoadScene("MissionFailureScene");

		}

	}

	public void Limit()
	{
		TimerText.text = End.ToString();
	}

}