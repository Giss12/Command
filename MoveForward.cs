using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : ICommand
{
    public Transform transform { get; set; }
    public float dist { get; set; }
    public MoveForward(Transform t, float d) { transform = t; dist = d;}



    public void Invoke()
    {
        transform.Translate(transform.forward * dist);
    }

    public void Undo()
    {
        transform.Translate(transform.forward * -dist);
    }
}
