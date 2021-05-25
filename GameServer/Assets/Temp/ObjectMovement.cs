using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    public int id;

    public void Initialize(int _id)
    {
        id = _id;
    }

    public void FixedUpdate()
    {
        ServerSend.ObjectPosition(this);
        ServerSend.ObjectRotation(this);
    }


}
