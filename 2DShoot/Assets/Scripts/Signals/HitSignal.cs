using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSignal
{
    public GameObject Instigator { get; private set; }

    public GameObject Sufferer { get; private set; }

    public float Damage { get; private set; }

    public Vector3 Position { get; private set; }

    public HitSignal(GameObject instigator, GameObject sufferer,float damage, Vector3 position)
    {
        Instigator = instigator;
        Sufferer   = sufferer;
        Position   = position;
        Damage     = damage;
    }
}
