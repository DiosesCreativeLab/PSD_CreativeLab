using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ADD_NUMBA : MonoBehaviour
{
    public Text[] tx;
    public string[] num;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            int i = 0;
            foreach( Text t in tx)
            {
                t.text = num[i];
                i +=1;
            }  
        }
    }
}
