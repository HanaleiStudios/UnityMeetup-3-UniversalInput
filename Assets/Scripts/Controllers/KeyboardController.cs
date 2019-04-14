using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Controller for keyboard input
/// </summary>
public class KeyboardController : Controller
{
    public Vector3 vel;
   
    void Update()
    {
        //Send events to input manager based on key pressed
        if(Input.GetKeyDown(KeyCode.Space)){
            InputManager.TriggerDown(currentHand);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            InputManager.TriggerUp(currentHand);
        }
        TrackpadValue();
    }

    /// <summary>
    /// Convert arrow key input to trackpad value
    /// </summary>
    void TrackpadValue(){
        float xAxis = 0, yAxis = 0;

        if(Input.GetKey(KeyCode.UpArrow)){
            yAxis += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            yAxis -= 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            xAxis -= 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            xAxis += 1;
        }
        vel = new Vector3(xAxis, yAxis, 0);
        //send trackpad value to input manager
        InputManager.TrackpadValue(currentHand, new Vector2(xAxis, yAxis));
    }

    /// <summary>
    /// Return the velocity.
    /// </summary>
    /// <value>The velocity</value>
    public override Vector3 Velocity{
        get { return vel; }
    }
}
