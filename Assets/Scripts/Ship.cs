using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ship : MonoBehaviour
{
    public event System.Action OnShipDestroyed;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //var shipShield = gameObject.GetComponent<ShipShield>();

        //if (!shipShield.Active)
        //    return;
        var aaa = collision.attachedRigidbody;

        var asteroid = collision.gameObject.GetComponent<Asteroid>();
       
        if (asteroid == null)
            return;

        if (OnShipDestroyed != null)
            OnShipDestroyed.Invoke();
    }
}
