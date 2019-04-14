using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controller for mouse input
/// </summary>
public class MouseController : Controller
{

    void Update()
    {
        //Send input events to InputManager
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
