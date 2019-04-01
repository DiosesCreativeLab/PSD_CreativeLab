using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Administrador_de_ventanas : MonoBehaviour
{

    public GameObject[] Gos; // casos

    public void Adm_Enable(int GO) ///1- Peaje 2- Restaurant 3- Niebla 4-Parking
        /* from 1 to 4*/ 
    {
        Debug.Log("to active");
   
        Gos[GO - 1].SetActive(true);
    }

    public void Adm_Disable(int GO)
       /* from 1 to 4*/
    {
        Gos[GO - 1].SetActive(false);
    }

}
