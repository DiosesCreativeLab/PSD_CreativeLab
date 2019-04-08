using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainControl : MonoBehaviour
{
    public static string PlayerName;
    public Text Username_field;
    public InputField InputFieldd;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerName = InputFieldd.text.ToString();
    }

    public string GetNamee()
    {
        return PlayerName;
    }
}
