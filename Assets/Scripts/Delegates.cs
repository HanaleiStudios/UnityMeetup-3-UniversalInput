//Just used to store delegates in the one place, instead of having them over different scripts
using UnityEngine;

public delegate void VoidEvent();
public delegate void BoolEvent(bool value);
public delegate void ControllerEvent(InputManager.ControllerHand hand);
public delegate void ControllerVec2Event(InputManager.ControllerHand hand, Vector2 value);