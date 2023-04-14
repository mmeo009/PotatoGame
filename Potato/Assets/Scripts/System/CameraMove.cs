using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class CameraMove : MonoBehaviour
{
    bool isC;
    Vector2 clickPoint;
    float dragSpeed = 50.0f;

    private void Update()

    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            isC = true;
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            isC = false;
        }

        if (Input.GetMouseButtonDown(0))
        {
            clickPoint = Input.mousePosition;
        }

        if (Input.GetMouseButton(0))
        {
            if (isC)
            {
                Vector3 position
                    = Camera.main.ScreenToViewportPoint((Vector2)Input.mousePosition - clickPoint);


                Vector3 move = position * (Time.deltaTime * dragSpeed);

                float y = transform.position.y;

                transform.Translate(move);
                transform.transform.position
                    = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            }
        }
    }
}


