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
    

        if (image.GetComponent<Image>().color.a <= 0.6f)
        {
            Debug.Log("da" + image.GetComponent<Image>().color.a);
          

            image.GetComponent<Image>().color = new Color32((byte)(image.GetComponent<Image>().color.r*256), (byte)(image.GetComponent<Image>().color.g * 256), (byte)(image.GetComponent<Image>().color.b * 256), 255);
     
        }
        else
        {
            image.GetComponent<Image>().color = new Color32((byte)(image.GetComponent<Image>().color.r * 256), (byte)(image.GetComponent<Image>().color.g * 256), (byte)(image.GetComponent<Image>().color.b * 256), 128);
        }
    }

}
