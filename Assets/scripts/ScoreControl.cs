using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    public Text You_Name;
    public Text You_score;
    public Text You_score_Recorrido;

    public Text Best_Name;
    public Text Best_score;
    public Text Best_score_Recorrido;

    public Text Worst_Name;
    public Text Worst_score;
    public Text Worst_score_Recorrido;


    int n_Players=0;
 
    public string _You_Name;

     float _You_score = 0f;
     int _You_score_PEaje = 9;
     int _You_score_rest = 9;
     int _You_score_nieb = 9;
     int _You_score_Park = 9;

     string _Best_Name = "unknown";
     float _Best_score = 5000f;
     int _Best_score_PEaje = 9;
     int _Best_score_rest = 9;
     int _Best_score_nieb = 9;
     int _Best_score_Park = 9;

     string _Worst_Name = "unknown";
     float _Worst_score = 0f;
     int _Worst_score_PEaje = 9;
     int _Worst_score_rest = 9;
     int _Worst_score_nieb = 9;
     int _Worst_score_Park = 9;


    public InputField innname;
    //
    void Start()
    {
        Looad();
        Settextss();
    }

    public void Settextss()
    {
        You_Name.text = _You_Name;
        You_score.text = _You_score.ToString("n2");
        You_score_Recorrido.text = "__" + _You_score_PEaje.ToString()+"_"+ _You_score_rest.ToString() + "_" + _You_score_nieb.ToString() + "_" + _You_score_Park.ToString() + "__";


        Best_Name.text = _Best_Name;
        Best_score.text = _Best_score.ToString("n2");
        Best_score_Recorrido.text = "__" + _Best_score_PEaje.ToString() + "_"+ _Best_score_rest.ToString() + "_"+ _Best_score_nieb.ToString() + "_" + _Best_score_Park.ToString() + "__";


        Worst_Name.text = _Worst_Name;
        Worst_score.text = _Worst_score.ToString("n2");
        Worst_score_Recorrido.text = "__" + _Worst_score_PEaje.ToString() + "_" + _Worst_score_rest.ToString() + "_" + _Worst_score_nieb.ToString() + "_" + _Worst_score_Park.ToString() + "__";
         
   
    }

    public void SetName()
    {
        Debug.Log(innname.text);

        _You_Name = innname.text;
        Debug.Log(_You_Name + "________________________________");

        PlayerPrefs.SetString("Jugador_" + n_Players.ToString(), _You_Name);
        _You_Name = PlayerPrefs.GetString("Jugador_" + n_Players.ToString(), "Error al SetName");

        Debug.Log(_You_Name + "________________________________");
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

        for (int i = 1; i < n_Players; i++)
        {

            Debug.Log("Numeeero del foooooooooooooor________"+ i.ToString());
            temp_Time = PlayerPrefs.GetFloat("Jugador_" + i + "_Time", -4);
            Debug.Log("_Timeeeeeeeeeeeeeeeeeeeeeee" + temp_Time);


            temp_Peaje = PlayerPrefs.GetInt("Jugador_" + i + "_Peaje", -4);
            Debug.Log("_Peajeeeeeeeeeeeeeeee" + temp_Peaje);


            temp_Restaurante = PlayerPrefs.GetInt("Jugador_" + i + "_Restaurante",-4);
            Debug.Log("_Restauranteeeeeeeeeeeeeeeeeeeee" + temp_Restaurante);

            temp_Niebla = PlayerPrefs.GetInt("Jugador_" + i + "_Niebla", -4);

                temp_Parking = PlayerPrefs.GetInt("Jugador_" + i + "_Parking", -4);
                temp_name = PlayerPrefs.GetString("Jugador_" + i, "unknown");
            Debug.Log("nameeeeeeeeeeeeee" + temp_name);

            if (temp_Time < _Best_score)
                {
                    _Best_Name = temp_name;
                    _Best_score = temp_Time;
                    _Best_score_PEaje = temp_Peaje;
                    _Best_score_rest = temp_Restaurante;
                    _Best_score_nieb = temp_Niebla;
                    _Best_score_Park = temp_Parking;
                    
                }
                else if (temp_Time > _Worst_score)
                {
                    _Worst_Name = temp_name;
                    _Worst_score = temp_Time;
                    _Worst_score_PEaje = temp_Peaje;
                    _Worst_score_rest = temp_Restaurante;
                    _Worst_score_nieb = temp_Niebla;
                    _Worst_score_Park = temp_Parking;
                }
                if(i == n_Players-1)
                {
                    _You_Name = temp_name;
                    _You_score = temp_Time;
                    _You_score_PEaje = temp_Peaje;
                    _You_score_rest = temp_Restaurante;
                    _You_score_nieb = temp_Niebla;
                    _You_score_Park = temp_Parking;
                }      
       
        }
    }




}
