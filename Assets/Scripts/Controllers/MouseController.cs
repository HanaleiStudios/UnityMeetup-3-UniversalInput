using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : Controller
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            InputManager.TriggerDown(currentHand);
        }
        if (Input.GetMouseButtonUp(0))
        {
            InputManager.TriggerUp(currentHand);
        }
        InputManager.TrackpadValue(currentHand, new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")));
    }
}
