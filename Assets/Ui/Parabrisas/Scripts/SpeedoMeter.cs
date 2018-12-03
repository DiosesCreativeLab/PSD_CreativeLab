
using UnityEngine;
using UnityEngine.UI;

public class SpeedoMeter : MonoBehaviour {

    Image img;



  
    public Slider vel;//velocity
    public Text speed_text;

    private int initRotation = 120;


	void Start ()
    {
        img = GetComponent<Image>();


    }
	

	void Update ()
    {

       
        img.rectTransform.eulerAngles = new Vector3(0, 0, initRotation -  vel.value);

        speed_text.text = vel.value.ToString();

    }


}
