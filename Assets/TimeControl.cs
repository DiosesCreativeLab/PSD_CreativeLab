using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TimeControl : MonoBehaviour
{
    public Text cTime_1;
    public float cTime2Time_1;
    public Text cCoi_1;
    public float cCoi2Coi_1;
    [Space]
    public Text cTime_2;
    public float cTime2Time_2;
    public Text cCoi_2;
    public float cCoi2Coi_2;
    [Space]
    public Text cTime_3;
    public float cTime2Time_3;
    public Text cCoi_3;
    public float cCoi2Coi_3;
    [Space]
    public Text cTime_4;
    public float cTime2Time_4;
    public Text cCoi_4;
    public float cCoi2Coi_4;

    void Start ()
    {

        cTime_1.text = " " + cTime2Time_1;
        cCoi_1.text = " " + cCoi2Coi_1;

        cTime_2.text = " " + cTime2Time_2;
        cCoi_2.text = " " + cCoi2Coi_2;

        cTime_3.text = " " + cTime2Time_3;
        cCoi_3.text = " " + cCoi2Coi_3;

        cTime_4.text = " " + cTime2Time_4;
        cCoi_4.text = " " + cCoi2Coi_4;

    }

	void Update ()
    {
        //1 --- ---
        cTime2Time_1 -= Time.deltaTime;

        if(cTime2Time_1>=0)
          cTime_1.text = " " + cTime2Time_1.ToString("f0");
        else
        {
          cTime_1.text = " " + 0;
        }
        if (cTime2Time_1 <= 3)
        {
            cCoi_1.text = " " + 100;
        }

        // --- --- --- --- ---

        //2 --- ---
        cTime2Time_2 -= Time.deltaTime;

        if (cTime2Time_2 >= 0)
            cTime_2.text = " " + cTime2Time_2.ToString("f0");
        else
        {
            cTime_2.text = " " + 0;
        }

        if (cTime2Time_2 <= 3)
        {
            cCoi_2.text = " " + 100;
        }

        // --- --- --- --- ---

        //3 --- ---
        cTime2Time_3 -= Time.deltaTime;

        if (cTime2Time_3 >= 0)
            cTime_3.text = " " + cTime2Time_3.ToString("f0");
        else
        {
            cTime_3.text = " " + 0;
        }
        if (cTime2Time_3 <= 3)
        {
            cCoi_3.text = " " + 100;
        }
        // --- --- --- --- ---

        //4 --- ---
        cTime2Time_4 -= Time.deltaTime;

        if (cTime2Time_4 >= 0)
            cTime_4.text = " " + cTime2Time_4.ToString("f0");
        else
        {
            cTime_4.text = " " + 0;
        }
        if (cTime2Time_4 <= 3)
        {
            cCoi_4.text = " " + 100;
        }

        // --- --- --- --- ---

    }
}
