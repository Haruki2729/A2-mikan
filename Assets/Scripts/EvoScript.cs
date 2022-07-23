using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvoScript : MonoBehaviour
{
    public static int GiveApple = 0;
    public static int GiveChicken = 0;
    public static int GiveFish = 0;
    public static int GiveCake = 0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static int returnGiveApple()
    {
        return GiveApple;
    }

    public static int returnGiveChicken()
    {
        return GiveChicken;
    }

    public static int returnGiveFish()
    {
        return GiveFish;
    }

    public static int returnGiveCake()
    {
        return GiveCake;
    }
}
