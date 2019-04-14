using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardController : Controller
{
    public Vector3 vel;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            InputManager.TriggerDown(currentHand);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            InputManager.TriggerUp(currentHand);
        }
        TrackpadValue();
    }

    void TrackpadValue(){
        float xAxis = 0, yAxis = 0;

        if(Input.GetKey(KeyCode.UpArrow)){
            yAxis += 1;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            yAxis -= 1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            xAxis -= 1;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            xAxis += 1;
        }
        vel = new Vector3(xAxis, yAxis, 0);
        InputManager.TrackpadValue(currentHand, new Vector2(xAxis, yAxis));
    }

    public override Vector3 Velocity{
        get { return vel; }
    }
}
