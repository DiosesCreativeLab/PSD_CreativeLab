using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.IO;

public class DataManager : MonoBehaviour
{
    public player_data playerdata;

    string filePath;
    string playerdata_filePath;
    string JsonString;

    public string GetJson_str(string jsonName)
    {
        filePath = Application.dataPath + "/" + jsonName + ".json";
        return File.ReadAllText(filePath);
    }

    public string GetJson_path(string jsonName)
    { 
        return Application.dataPath + "/" + jsonName + ".json";
    }

    public void Serial_PlayerData()
    {
        JsonString = JsonUtility.ToJson(playerdata);
        File.WriteAllText(GetJson_path("Playerdata"), JsonString);
    }

    public void Serial_score() { } //future inplementation
    public void DesSerial_score() { } //future inplementation

    public void DesSerial_PlayerData()
    {
        JsonString = GetJson_str("Playerdata");
        playerdata = JsonUtility.FromJson<player_data>(JsonString);
    }

}

public class player_data
{
    public string ip;
    public string port;
    public string name;

    public List<filters> profiles_filters;

    // public filters filt;

}

public class filters
{
    public string name;

    //Filters
    // Array of filters in every group // to make easy add new filters
    //- --------------------



    public bool group_Climatic = false;
    public int numCl = 0;
    public bool[] cl;
    //public bool cl_Fogg = false;
    //public bool cl_Storm = false;
    //public bool cl_Snow = false;
    //public bool cl_Ice = false;
    //public bool cl_Wind = false;

    //- --------------------
    public bool group_Events = false;
    public int numEv = 0;
    public bool[] ev;

    //public bool ev_Mani = false;
    //public bool ev_Concerts = false;
    //public bool ev_SportEvents = false;
    //public bool ev_Fairs = false;
    //public bool ev_Racings = false;
    //- --------------------

    public bool group_NormalLife = false;
    public int numNl = 0;
    public bool[] nl;

    //public bool nl_School = false;
    //public bool nl_Trafic = false;
    //public bool nl_RoadWorks = false;
    //public bool nl_RunningGroups = false;
    //- --------------------

    public bool group_Emergencies = false;
    public int numEm = 0;
    public bool[] em;


    //public bool em_Ambulances = false;
    //public bool em_CarCrash = false;
    //public bool em_RocksInTheRoad = false;
    //public bool em_Fire = false;
    //- --------------------

}


public class player //future inplementation
{
    public string name; //future inplementation
    public int time; //future inplementation
}

public class scoreboard //future inplementation
{
    public List<player> players; //future inplementation
}