using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //必要です！！

public class SoundScript : MonoBehaviour
{

	//ヒエラルキーからD&Dしておく
	public AudioSource BGM_home;
	public AudioSource BGM_alarm;

	//１つ前のシーン名
	private string beforeScene = "UnityAlarmScene";

	// Use this for initialization
	void Start()
	{
		//自分と各BGMオブジェクトをシーン切り替え時も破棄しないようにする
		DontDestroyOnLoad(gameObject);
		DontDestroyOnLoad(BGM_home.gameObject);
		DontDestroyOnLoad(BGM_alarm.gameObject);

		//シーンが切り替わった時に呼ばれるメソッドを登録
		SceneManager.activeSceneChanged += OnActiveSceneChanged;
	}

	//シーンが切り替わった時に呼ばれるメソッド
	void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
	{
		

		//メインからメニューへUnityAlarmScene
		if (beforeScene == "MissionClearScene" && nextScene.name == "HomeScene" + EvoScript.HomeNumber.ToString() 
			|| beforeScene == "MissionClearScene2" && nextScene.name == "HomeScene" + EvoScript.HomeNumber.ToString()
			|| beforeScene == "MissionFailureScene" && nextScene.name == "HomeScene" + EvoScript.HomeNumber.ToString())
		{
			BGM_alarm.Stop();
			BGM_home.Play();
		}

		//シーンがどう変わったかで判定

		//メニューからメインへ
		if (beforeScene == "UnityAlarmScene" && nextScene.name == "Mission1Scene"
			|| beforeScene == "UnityAlarmScene" && nextScene.name == "Mission2Scene")
		{
			BGM_home.Stop();
			BGM_alarm.Play();
		}

		//遷移後のシーン名を「１つ前のシーン名」として保持
		beforeScene = nextScene.name;
	}
}

