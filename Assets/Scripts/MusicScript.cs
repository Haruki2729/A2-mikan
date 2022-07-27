using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public bool DontDestoryEnabled = true;
    static GameObject instance;

    void Awake()
    {
        if (DontDestoryEnabled)
        {
            if (instance == null)
            {
                instance = gameObject;
                DontDestroyOnLoad(this);
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        //��ʑJ�ڂ��Ă��I�u�W�F�N�g�����Ȃ��悤�ɂ���
        DontDestroyOnLoad(this);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
