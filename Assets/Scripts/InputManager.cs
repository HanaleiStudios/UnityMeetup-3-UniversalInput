using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    public enum ControllerHand { Left, Right, None };

    static Dictionary<ControllerHand, Controller> controllers;

    public static event ControllerEvent OnTriggerDown;
    public static event ControllerEvent OnTriggerUp;
    public static event ControllerVec2Event OnTrackpadValue;

    public static void AssignController(ControllerHand c, Controller g){
        if(controllers == null){
            controllers = new Dictionary<ControllerHand, Controller>();
        }
        if (controllers.ContainsKey(c))
        {
            controllers[c] = g;
        }
        else
        {
            controllers.Add(c, g);
        }
    }

    public static Controller GetControllerTransform(ControllerHand hand){
        return controllers[hand];
    }

    public static void TriggerDown(ControllerHand c){
        if(OnTriggerDown != null){
            OnTriggerDown(c);
        }
    }

    public static void TriggerUp(ControllerHand c){
        if (OnTriggerUp != null)
        {
            OnTriggerUp(c);
        }
    }

    public static void TrackpadValue(ControllerHand c, Vector2 value){
        if(OnTrackpadValue != null){
            OnTrackpadValue(c, value);
        }
    }

}
