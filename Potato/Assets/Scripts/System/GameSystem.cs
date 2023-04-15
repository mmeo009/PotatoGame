using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSystem : MonoBehaviour
{

    public bool pause = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (pause == true)
            {
                pause = false;
            }
            else
            {
                pause = true;
            }
            Debug.Log(pause);
        }
    }
}
