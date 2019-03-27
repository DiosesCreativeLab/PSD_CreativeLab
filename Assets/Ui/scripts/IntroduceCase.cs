using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroduceCase : MonoBehaviour
{
    public Administrador_de_ventanas w_control;


    void OnTriggerEnter(Collider Other_col)
    {

        Debug.Log("trigered");
        if (Other_col.tag == "Player")
        {
            w_control.Adm_Enable(1);
        }

    }

    void Update()
    {
   

    }
}
