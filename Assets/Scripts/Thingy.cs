using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thingy : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        InputManager.OnTriggerDown += ReceiveTriggerDownEvent;
        InputManager.OnTriggerUp += ReceiveTriggerUpEvent;
    }

    void ReceiveTriggerDownEvent(InputManager.ControllerHand hand)
    {
        PrintText("Trigger is down on " + System.Enum.GetName(typeof(InputManager.ControllerHand), hand) + " hand");
    }

    void ReceiveTriggerUpEvent(InputManager.ControllerHand hand)
    {
        PrintText("Speed: " + InputManager.GetControllerTransform(hand).Velocity);
    }

    void PrintText(string text){
        Debug.Log(text);

    }
}
