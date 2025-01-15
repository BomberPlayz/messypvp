using System;
using FishNet.Object;
using FishNet.Transporting.Tugboat;
using UnityEngine;

public class TestNetScript : NetworkBehaviour
{
    private Tugboat _tugboat;

    public void OnReady()
    {
        if (TryGetComponent(out Tugboat tugboat))
        {
            _tugboat = tugboat;
        }
        else
        {
            Debug.LogWarning("No component of type Tugboat");
        }


    }
}
