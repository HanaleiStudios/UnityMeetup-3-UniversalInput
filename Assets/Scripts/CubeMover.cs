using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InputManager.OnTrackpadValue += MoveCube;
    }

    void MoveCube(InputManager.ControllerHand hand, Vector2 value){
        if(hand == InputManager.ControllerHand.Left){
            transform.position += Vector3.up * value.y * Time.deltaTime;
        }
        else if (hand == InputManager.ControllerHand.Right){
            transform.position += new Vector3(value.x, 0, value.y);
        }
    }
}
