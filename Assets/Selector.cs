using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour {

    public Animator animator;
    GameObject[] noselectedList;


    public void SetAnimint(int integ)
    {
        animator.SetInteger("Anim_Int_Controller", integ);
    }

    //public void SelecttButton(GameObject selecteed)
    //{
    //    foreach(selecteed noselectedList)
    //    {

    //    }

    //}



}
