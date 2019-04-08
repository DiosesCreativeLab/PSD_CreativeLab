using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toclose : MonoBehaviour
{
    public Variables_Controler vc;


    void OnTriggerEnter(Collider Other_col)
    {

        Debug.Log("trigered");

        if (Other_col.tag == "Player")
        {
            vc.changeScene(0);
        }
    }

}
