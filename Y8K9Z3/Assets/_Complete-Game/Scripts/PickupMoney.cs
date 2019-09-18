using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupMoney : MonoBehaviour
{
    // Start is called before the first frame update
    Currency script;

    public int amountAdded;

    void Start()
    {
        script = GameObject.FindWithTag("GameController").GetComponent<Currency>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            script.money += amountAdded;
            Destroy(gameObject);
        }
    }
}
