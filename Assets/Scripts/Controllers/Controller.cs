using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Base controller class
/// </summary>
public class Controller : MonoBehaviour
{
    /// <summary>
    /// Assigned ID of this controller. Change to Int for less constraints
    /// </summary>
    public InputManager.ControllerHand currentHand;

    private void Awake()
    {
        //Register the controller in the InputManager
        InputManager.AssignController(currentHand, this);
    }

    /// <summary>
    /// Gets the position.
    /// </summary>
    /// <value>The position.</value>
    public virtual Vector3 Position{
        get { return Vector3.zero; }
    }

    /// <summary>
    /// Gets the velocity.
    /// </summary>
    /// <value>The velocity.</value>
    public virtual Vector3 Velocity{
        get { return Vector3.zero; }
    }

    /// <summary>
    /// Gets the angular velocity.
    /// </summary>
    /// <value>The angular velocity.</value>
    public virtual Vector3 AngularVelocity{
        get { return Vector3.zero; }
    }
}
