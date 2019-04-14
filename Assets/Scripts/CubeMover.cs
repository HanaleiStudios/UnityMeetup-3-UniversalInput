using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Moves attached object based on InputManager input
/// </summary>
public class CubeMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Subscrive to OnTrackpadValue event
        InputManager.OnTrackpadValue += MoveCube;
    }

    /// <summary>
    /// Moves the cube based on the InputManager's Trackpad value
    /// </summary>
    /// <param name="hand">Controller ID.</param>
    /// <param name="value">Trackpad value</param>
    void MoveCube(InputManager.ControllerHand hand, Vector2 value){
        if(hand == InputManager.ControllerHand.Left){
            transform.position += Vector3.up * value.y * Time.deltaTime;
        }
        else if (hand == InputManager.ControllerHand.Right){
            transform.position += new Vector3(value.x, 0, value.y);
        }
    }
}
