using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables_Controler : MonoBehaviour
{
    public int caseNumber = 0;



    public void Add_CaseNumber(){caseNumber++;}
    public bool IsCaseNumber(int num) { return num == caseNumber; }

}
