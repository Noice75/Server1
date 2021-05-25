using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectMovementManager : MonoBehaviour
{
    public int id;

    void Start()
    {
        GameManager.ObjectMove.Add(GameManager.ObjectMove.Count, gameObject);
    }
}
