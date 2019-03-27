﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseCase1 : MonoBehaviour
{

    public Administrador_de_ventanas w_control;
    public Variables_Controler V_controler;

   

    void OnTriggerEnter(Collider Other_col)
    {
        if (Other_col.tag == "Player")
        {
            if (V_controler.IsCaseNumber(1))
            {
                w_control.Adm_Disable(1);
                V_controler.Add_CaseNumber();
            }

            else if (V_controler.IsCaseNumber(3))
            {
                w_control.Adm_Disable(2);
                V_controler.Add_CaseNumber();
            }
            else if (V_controler.IsCaseNumber(5))
            {
                w_control.Adm_Disable(3);
                V_controler.Add_CaseNumber();
            }
            else if (V_controler.IsCaseNumber(7))
            {
                w_control.Adm_Disable(4);
                V_controler.Add_CaseNumber();
            }
        }

    }

}
