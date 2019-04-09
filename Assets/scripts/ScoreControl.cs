using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreControl : MonoBehaviour
{

    int n_Players=0;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void Looad()
    {
        string temp_name = "000";
        float temp_Time = -1;
        int temp_Peaje = -1;
        int temp_Restaurante = -1;
        int temp_Niebla = -1;
        int temp_Parking = -1;


        n_Players = PlayerPrefs.GetInt("cant_Jugadores", 0);


        for (int i = 0; i < n_Players; i++)
        {

            temp_Time = PlayerPrefs.GetFloat("Jugador_" + i + "_Time", 0);
            temp_Peaje = PlayerPrefs.GetInt("Jugador_" + i + "_Peaje", 0);
            temp_Restaurante = PlayerPrefs.GetInt("Jugador_" + i + "_Restaurante", 0);
            temp_Niebla = PlayerPrefs.GetInt("Jugador_" + i + "_Niebla", 0);
            temp_Parking = PlayerPrefs.GetInt("Jugador_" + i + "_Parking", 0);
            temp_name = PlayerPrefs.GetString("Jugador_" + i, "unknown");

        }

    }


}
