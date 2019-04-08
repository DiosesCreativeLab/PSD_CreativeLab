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
        
        select_Peaje s_Peaje;
        select_Restaurant s_Restaurant;
        select_Niebla s_Niebla;
        select_Parking s_Parking;

        public string Player_Name;

        public void setpeaje(int p)
        {
            s_Peaje = (select_Peaje)p;
        }

        public void setrest(int r)
        {
            s_Restaurant = (select_Restaurant)r;
        }

        public void setfog(int f)
        {
            s_Niebla = (select_Niebla)f;
        }

        public void setpark(int pa)
        {
            s_Parking = (select_Parking)pa;
        }

    }

    static playerr[] playersScore;

    public playerr currentPlayer;

    static int num_current_Player = 0;
    public int caseNumber = 0;

    public Text txt;
    public mainControl mcontrol;

    // -----------------------------------------------
    void Start()
    {
        if(num_current_Player==0)
        {
            playersScore = new playerr[50];

        }

        num_current_Player += 1;

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
        currentPlayer.setpeaje(toSet);
    }
    public void setRest(int toSet)//A,B,C
    {
        currentPlayer.setrest(toSet);
    }
    public void setfog(int toSet)//A,B
    {
        currentPlayer.setpeaje(toSet);
    }
    public void setParking(int toSet)//A,B,C
    {
        currentPlayer.setpark(toSet);
    }

    public void changeScene(int toWitchScene)
    {
        if (num_current_Player < 50)
        {
            playersScore.SetValue(currentPlayer, num_current_Player - 1);
        }

        SceneManager.LoadScene(toWitchScene);
    }

}
