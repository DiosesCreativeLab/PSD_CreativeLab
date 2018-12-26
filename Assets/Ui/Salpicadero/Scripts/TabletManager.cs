using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Step
{
    string name = null;
    TabletManager.DirectionSignal signalDirection = TabletManager.DirectionSignal.D_Start;


    public Step(string name, TabletManager.DirectionSignal dir)
    {
        this.name = name;
        this.signalDirection = dir;
    }
    public int GetDir()
    {
        return (int)signalDirection;
    }

}


public class TabletManager : MonoBehaviour
{

    public enum DirectionSignal { D_Right, D_Left, D_UpRight, D_UpLeft, D_G_Right, D_G_Left, D_G_Up, D_End, D_Start }

    public List<Step> steps = null;

    //temp
    public int stepsNum = 15;
    public int num = 0;

    void Start ()
    {
        steps = new List<Step>();

        // asign randomly a list of directions 
        for (int temp = 0; temp< stepsNum; temp++)
        {

            var rnd = new Random();

            Step s = new Step("Signal_:" + temp.ToString(), (DirectionSignal)System.Enum.GetNames(typeof(DirectionSignal)).Length);

            steps.Add(s);
        }

        Debug.Log("num steps" + steps.Count);
        num = steps.Count;

    }

}

