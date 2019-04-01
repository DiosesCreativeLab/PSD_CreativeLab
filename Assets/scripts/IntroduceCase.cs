using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroduceCase : MonoBehaviour
{
    public Administrador_de_ventanas w_control;
    public Variables_Controler V_controler;


    void OnTriggerEnter(Collider Other_col)
    {

        Debug.Log("trigered");
        if (Other_col.tag == "Player")
        {
            if (V_controler.IsCaseNumber(0))
            {
                w_control.Adm_Enable(1);
                V_controler.Add_CaseNumber();
            }

            else if (V_controler.IsCaseNumber(2))
            {
                w_control.Adm_Enable(2);
                V_controler.Add_CaseNumber();
            }
            else if (V_controler.IsCaseNumber(4))
            {
                w_control.Adm_Enable(3);
                V_controler.Add_CaseNumber();
            }
            else if (V_controler.IsCaseNumber(6))
            {
                w_control.Adm_Enable(4);
                V_controler.Add_CaseNumber();
            }
        }

    }
}
