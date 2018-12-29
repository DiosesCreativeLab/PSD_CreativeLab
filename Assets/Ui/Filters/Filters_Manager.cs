using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Filters_Manager : MonoBehaviour {

    public DataManager data_mana;
    public Toggle[] climatic;
    public Toggle[] events;
    public Toggle[] normallife;
    public Toggle[] emergencies;
    

    void Finish()
    {


   
        for (int temp = 0; temp < climatic.Length; temp++)
        {
          //  data_mana.playerdata.profiles_filters.Find(profiles_filters.name);

          //  data_mana.filt.cl[0] = climatic[0].isOn;
        }

    }


}
