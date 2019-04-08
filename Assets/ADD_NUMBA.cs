using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ADD_NUMBA : MonoBehaviour
{
    public Text tx;
    public int num;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            tx.text = num.ToString();
        }
    }
}
