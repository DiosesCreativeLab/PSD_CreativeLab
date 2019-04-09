using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UnityEngine.SceneManagement;

public class Variables_Controler : MonoBehaviour
{

    enum select_Peaje {A,B,C,D, NaN};
    enum select_Restaurant { A, B, C, NaN };
    enum select_Niebla { A, B, NaN };
    enum select_Parking { A, B, D, NaN };

    //static string PlayerName;

    public struct playerr
    {
        public float timee;
        
        public int s_Peaje;
        public int s_Restaurant;
        public int s_Niebla;
        public int s_Parking;

        public string Player_Name;

    }
    public playerr currentPlayer;

    static int num_current_Player = 0;
    public int caseNumber = 0;

    public Text txt;
    public mainControl mcontrol;

    // -----------------------------------------------

    void Start()
    {
        num_current_Player = PlayerPrefs.GetInt("cant_Jugadores", num_current_Player)+1;

        caseNumber = 0;

        currentPlayer.timee = 0f;

        currentPlayer.Player_Name = mcontrol.GetNamee();
    }
    // -----------
    void Update()
    {

        currentPlayer.timee += Time.deltaTime;
        txt.text = currentPlayer.timee.ToString("n2");

    }
    // -----------
    void Finish()
    {

    }

    // -----------------------------------------------

    
    public void Add_CaseNumber()
    {
        caseNumber++;
    }

    public bool IsCaseNumber(int num)
    {
        return num == caseNumber;
    }

    public void setPeaje(int toSet) //A,B,C,D
    {
        currentPlayer.s_Peaje = toSet;
    }
    public void setRest(int toSet)//A,B,C
    {
        currentPlayer.s_Restaurant = toSet;
    }
    public void setfog(int toSet)//A,B
    {
        currentPlayer.s_Niebla = toSet;
    }
    public void setParking(int toSet)//A,B,C
    {
        currentPlayer.s_Parking = toSet;
    }

    public void changeScene(int toWitchScene)
    {
        SAaave();
        SceneManager.LoadScene(toWitchScene);
    }

    void SAaave()
    {
        PlayerPrefs.SetInt("cant_Jugadores", num_current_Player);
    //  PlayerPrefs.SetString("Jugador_" + num_current_Player.ToString(), name);

        PlayerPrefs.SetFloat("Jugador_" + num_current_Player.ToString() + "_Time", currentPlayer.timee);
        PlayerPrefs.SetInt("Jugador_" + num_current_Player.ToString() + "_Peaje", currentPlayer.s_Peaje);
        PlayerPrefs.SetInt("Jugador_" + num_current_Player.ToString() + "_Restaurante", currentPlayer.s_Restaurant);
        PlayerPrefs.SetInt("Jugador_" + num_current_Player.ToString() + "_Niebla", currentPlayer.s_Niebla);
        PlayerPrefs.SetInt("Jugador_" + num_current_Player.ToString() + "_Parking", currentPlayer.s_Parking);

    }


}
