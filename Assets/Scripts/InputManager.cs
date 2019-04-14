using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Input manager
/// 
/// This should be the one point of call for all input in your code. All mouse, keyboard, joystick and other controllers
/// should reference this instead of Unity's Input system, or your Controller's SDK.
/// 
/// This will allow you to do whatever you like to interpret input for each controller, without needing to affect and of the input
/// code in any of your other scripts
/// </summary>
public class InputManager
{
    /// <summary>
    /// Controllers. This can be removed if you want to handle any number of controllers
    /// </summary>
    public enum ControllerHand { Left, Right, None };

    /// <summary>
    /// Registered controllers. Replace ControllerHand with an Int for variable number of controllers
    /// </summary>
    static Dictionary<ControllerHand, Controller> controllers;

    //events
    public static event ControllerEvent OnTriggerDown;
    public static event ControllerEvent OnTriggerUp;
    public static event ControllerVec2Event OnTrackpadValue;

    /// <summary>
    /// Assigns the controller.
    /// </summary>
    /// <param name="c">The ID of the controller</param>
    /// <param name="g">The gameobject of the controller</param>
    public static void AssignController(ControllerHand c, Controller g){
        //ensure dictionary exists
        if(controllers == null){
            controllers = new Dictionary<ControllerHand, Controller>();
        }
        //set controller if it already exists, otherwise add it
        if (controllers.ContainsKey(c))
        {
            controllers[c] = g;
        }
        else
        {
            controllers.Add(c, g);
        }
    }

    /// <summary>
    /// Gets the controller transform.
    /// </summary>
    /// <returns>The controller transform.</returns>
    /// <param name="hand">ID of the controller</param>
    public static Controller GetControllerTransform(ControllerHand hand){
        return controllers[hand];
    }

    /// <summary>
    /// Called when trigger down
    /// </summary>
    /// <param name="c">Controller ID</param>
    public static void TriggerDown(ControllerHand c){
        if(OnTriggerDown != null){
            OnTriggerDown(c);
        }
    }

    /// <summary>
    /// Called when trigger Up
    /// </summary>
    /// <param name="c">Controller ID</param>
    public static void TriggerUp(ControllerHand c){
        if (OnTriggerUp != null)
        {
            OnTriggerUp(c);
        }
    }

    /// <summary>
    /// Called when Trackpad value changed
    /// </summary>
    /// <param name="c">Controller ID</param>
    public static void TrackpadValue(ControllerHand c, Vector2 value){
        if(OnTrackpadValue != null){
            OnTrackpadValue(c, value);
        }
    }

}
