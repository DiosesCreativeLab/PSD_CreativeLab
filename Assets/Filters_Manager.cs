using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Filters_Manager : MonoBehaviour {

    //Filters

    //- --------------------
    public bool group_Climatic = false;

    public bool cl_Fogg = false;
  
    public bool cl_Storm = false;
    public bool cl_Snow= false;
    public bool cl_Ice = false;
    public bool cl_Wind = false;

    //- --------------------
    public bool group_Events = false;

    public bool ev_Mani = false;
    public bool ev_Concerts = false;
    public bool ev_SportEvents = false;
    public bool ev_Fairs = false;
    public bool ev_Racings = false;
    //- --------------------

    public bool group_NormalLife = false;

    public bool nl_School = false;
    public bool nl_Trafic = false;
    public bool nl_RoadWorks = false;
    public bool nl_RunningGroups = false;
    //- --------------------

    public bool group_Emergencies = false;

    public bool em_Ambulances = false;
    public bool em_CarCrash = false;
    public bool em_RocksInTheRoad = false;
    public bool em_Fire = false;
    //- --------------------

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
