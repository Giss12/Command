using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : ICommand
{
    public Transform transform { get; set; }
    public float angle { get; set; }
    public Rotate(Transform t, float a) { transform = t; angle = a; }

    public void Invoke()
    {
        transform.Rotate(new Vector3(0, angle, 0));
    }

    public void Undo()
    {
        transform.Rotate(new Vector3(0, -angle, 0));
    }
}

