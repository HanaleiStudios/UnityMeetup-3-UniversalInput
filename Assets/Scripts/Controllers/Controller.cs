using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public InputManager.ControllerHand currentHand;

    private void Awake()
    {
        InputManager.AssignController(currentHand, this);
    }

    public virtual Vector3 Position{
        get { return Vector3.zero; }
    }

    public virtual Vector3 Velocity{
        get { return Vector3.zero; }
    }

    public virtual Vector3 AngularVelocity{
        get { return Vector3.zero; }
    }
}
