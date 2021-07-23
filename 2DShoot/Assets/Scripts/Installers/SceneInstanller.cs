using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class SceneInstanller : MonoInstaller<SceneInstanller>
{
    public override void InstallBindings()
    {
        InstallSignal();
    }

    private void InstallSignal()
    {
        SignalBusInstaller.Install(Container);

        Container.DeclareSignal<HitSignal>();
    }
}
