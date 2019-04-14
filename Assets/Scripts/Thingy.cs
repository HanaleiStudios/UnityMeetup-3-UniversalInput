using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thingy : MonoBehaviour
{
    /// <summary>
    /// Subscribe to relevant events
    /// </summary>
    void Awake()
    {
        InputManager.OnTriggerDown += ReceiveTriggerDownEvent;
        InputManager.OnTriggerUp += ReceiveTriggerUpEvent;
    }

    /// <summary>
    /// Get Trigger Down Event
    /// </summary>
    /// <param name="hand">Controller ID</param>
    void ReceiveTriggerDownEvent(InputManager.ControllerHand hand)
    {
        PrintText("Trigger is down on " + System.Enum.GetName(typeof(InputManager.ControllerHand), hand) + " hand");
    }

    /// <summary>
    /// Get Trigger Down Event
    /// </summary>
    /// <param name="hand">Controller ID</param>
    void ReceiveTriggerUpEvent(InputManager.ControllerHand hand)
    {
        PrintText("Speed: " + InputManager.GetControllerTransform(hand).Velocity);
    }

    /// <summary>
    /// Fires off a Debug log for given text.
    /// </summary>
    /// <param name="text">string to debug</param>
    void PrintText(string text){
        Debug.Log(text);

    }
}
