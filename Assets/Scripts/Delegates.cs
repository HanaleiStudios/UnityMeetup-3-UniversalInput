using UnityEngine;

public delegate void VoidEvent();
public delegate void BoolEvent(bool value);
public delegate void ControllerEvent(InputManager.ControllerHand hand);
public delegate void ControllerVec2Event(InputManager.ControllerHand hand, Vector2 value);