using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimsControl : MonoBehaviour
{
    public Animator[] anims;

    void OnTriggerEnter(Collider Other_col)
    {
        if (Other_col.tag == "Player")
        {
            foreach(Animator temp in anims)
            {
                temp.SetBool("CanPlay", true);
            }
        }
    }

    void OnTriggerExit(Collider Other_col)
    {
        if (Other_col.tag == "Player")
        {
            foreach (Animator temp in anims)
            {
                temp.SetBool("CanPlay", false);
            }
        }
    }

    public void PlayAnims()
    {
        foreach (Animator temp in anims)
        {
            temp.SetBool("CanPlay", true);
        }
    }

    public void StopAnims()
    {
        foreach (Animator temp in anims)
        {
            temp.SetBool("CanPlay", false);
        }
    }
}
