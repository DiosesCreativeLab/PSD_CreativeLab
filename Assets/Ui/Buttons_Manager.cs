using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

    public void changeAlpha(GameObject image)
    {
        float transparency = 0.5f; // (float)128 / (float)256;

        if (true/*mathf.Round(image.GetComponent<Image>().color.a) == 0.5f*/)
        {
  

            image.GetComponent<Image>().color = new Color32(233, 131, 131, 255);
     
        }
        else
        {
            image.GetComponent<Image>().color = new Color32(233, 131, 131, 128);
            //cb.a = transparency;
            //cb2.a = transparency;
        }
    }

}
