using System;
using System.Collections;
using System.Collections.Generic;
using MoreMountains.Feedbacks;
using UnityEngine;
using Zenject;

public class HitProcesser : MonoBehaviour
{
    [Inject]
    readonly SignalBus _signalBus;

    [SerializeField]
    private MMFeedbacks hitFeedBack;


    private void Awake()
    {
        _signalBus.Subscribe<HitSignal>(OnHit);
    }

    void OnHit(HitSignal args)
    {
        hitFeedBack.PlayFeedbacks(args.Position);
    }
}
