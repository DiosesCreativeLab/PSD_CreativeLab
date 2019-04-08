using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Timerr : MonoBehaviour
{
    public Text txt;
    public Text txt2;
    private float tiiime = 0;
   
    void Update()
    {
        tiiime += Time.deltaTime;
        txt2.text = tiiime.ToString();
        txt.text = Time.time.ToString();
    }
}
