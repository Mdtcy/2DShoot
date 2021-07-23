using UnityEngine;
using Zenject;

public class Character : MonoBehaviour
{
    [Inject]
    readonly SignalBus _signalBus;

    public void OnHit()
    {
        _signalBus.Fire(new HitSignal(null,this.gameObject,10, transform.position));
    }

}
