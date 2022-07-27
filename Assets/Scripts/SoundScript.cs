using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundScript : MonoBehaviour
{
	public AudioSource BGM_home;
	public AudioSource BGM_alarm;

	//１つ前のシーン名
	private string beforeScene = "UnityAlarmScene";

	void Start()
	{
		BGM_home.Stop();


		DontDestroyOnLoad(gameObject);
		DontDestroyOnLoad(BGM_home.gameObject);
		DontDestroyOnLoad(BGM_alarm.gameObject);

		SceneManager.activeSceneChanged += OnActiveSceneChanged;
	}

	void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
	{
		

		//ミッションクリア・失敗からホームシーンへ
		if (beforeScene == "MissionClearScene" && nextScene.name == "HomeScene" + EvoScript.HomeNumber.ToString() 
			|| beforeScene == "MissionClearScene2" && nextScene.name == "HomeScene" + EvoScript.HomeNumber.ToString()
			|| beforeScene == "MissionFailureScene" && nextScene.name == "HomeScene" + EvoScript.HomeNumber.ToString())
		{
			//BGM_home.Play();
			BGM_alarm.Stop();
		}

		//シーンがどう変わったかで判定

		//アラームシーンからミッションシーンへ
		if (beforeScene == "UnityAlarmScene" && nextScene.name == "Mission1Scene"
			|| beforeScene == "UnityAlarmScene2" && nextScene.name == "Mission2Scene")
		{
			//BGM_home.Stop();
			BGM_alarm.Play();
		}

		//遷移後のシーン名を「１つ前のシーン名」として保持
		beforeScene = nextScene.name;
	}
}

