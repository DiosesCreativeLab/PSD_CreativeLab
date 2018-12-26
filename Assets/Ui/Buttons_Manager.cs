using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons_Manager : MonoBehaviour {

	public void ChangeActive(GameObject GO)
    {
        GO.SetActive(!GO.activeSelf);
    }
    public void ChangeActiveDButton(GameObject GO,int i, GameObject GO1, GameObject GO2, GameObject GO3)
    {
        GO.SetActive(!GO.activeSelf);

        GO1.SetActive(false);
        GO2.SetActive(false);
        GO3.SetActive(false);

    }

}
