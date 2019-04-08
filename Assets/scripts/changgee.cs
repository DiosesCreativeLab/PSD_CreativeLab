using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class changgee : MonoBehaviour
{
    public void changeScene(int toWitchScene)
    {
        SceneManager.LoadScene(toWitchScene);
    }
}
