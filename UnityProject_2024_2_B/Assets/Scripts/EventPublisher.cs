using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventPublisher : MonoBehaviour
{
    public EventChannel eventChannel;

     void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            eventChannel.RaiseEvent();
        }
    }
}
