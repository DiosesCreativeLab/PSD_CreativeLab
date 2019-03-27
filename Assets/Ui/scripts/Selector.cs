using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour {

    public Animator animator;
    GameObject[] noselectedList;


    public void SetAnimint_Peaje(int integ)
    {
        animator.SetInteger("Peaje_Select", integ);
    }
    public void SetAnimint_Restaurant(int integ)
    {
        animator.SetInteger("Restaurant_Select", integ);
    }
    public void SetAnimint_Niebla(int integ)
    {
        animator.SetInteger("Niebla_Select", integ);
    }

    public void SetAnimint_Parking(int integ)
    {
        animator.SetInteger("Parking_Select", integ);
    }

    //public void SelecttButton(GameObject selecteed)
    //{
    //    foreach(selecteed noselectedList)
    //    {

    //    }

    //}



}
