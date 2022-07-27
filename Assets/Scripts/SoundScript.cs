using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //�K�v�ł��I�I

public class SoundScript : MonoBehaviour
{

	//�q�G�����L�[����D&D���Ă���
	public AudioSource BGM_home;
	public AudioSource BGM_alarm;

	//�P�O�̃V�[����
	private string beforeScene = "UnityAlarmScene";

	// Use this for initialization
	void Start()
	{
		//�����ƊeBGM�I�u�W�F�N�g���V�[���؂�ւ������j�����Ȃ��悤�ɂ���
		DontDestroyOnLoad(gameObject);
		DontDestroyOnLoad(BGM_home.gameObject);
		DontDestroyOnLoad(BGM_alarm.gameObject);

		//�V�[�����؂�ւ�������ɌĂ΂�郁�\�b�h��o�^
		SceneManager.activeSceneChanged += OnActiveSceneChanged;
	}

	//�V�[�����؂�ւ�������ɌĂ΂�郁�\�b�h
	void OnActiveSceneChanged(Scene prevScene, Scene nextScene)
	{
		

		//���C�����烁�j���[��UnityAlarmScene
		if (beforeScene == "MissionClearScene" && nextScene.name == "HomeScene" + EvoScript.HomeNumber.ToString() 
			|| beforeScene == "MissionClearScene2" && nextScene.name == "HomeScene" + EvoScript.HomeNumber.ToString()
			|| beforeScene == "MissionFailureScene" && nextScene.name == "HomeScene" + EvoScript.HomeNumber.ToString())
		{
			BGM_alarm.Stop();
			BGM_home.Play();
		}

		//�V�[�����ǂ��ς�������Ŕ���

		//���j���[���烁�C����
		if (beforeScene == "UnityAlarmScene" && nextScene.name == "Mission1Scene"
			|| beforeScene == "UnityAlarmScene" && nextScene.name == "Mission2Scene")
		{
			BGM_home.Stop();
			BGM_alarm.Play();
		}

		//�J�ڌ�̃V�[�������u�P�O�̃V�[�����v�Ƃ��ĕێ�
		beforeScene = nextScene.name;
	}
}

