using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameSystem : MonoBehaviour
{

    public bool sP = false;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            if (sP == false)
            {
                sP = true;
            }
            else
            {
                sP = false;
            }
        }
    }
}
