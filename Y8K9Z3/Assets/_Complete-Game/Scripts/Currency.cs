using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Currency : MonoBehaviour
{

    public int money;

    GameObject currencyUI;
    // Start is called before the first frame update
    void Start()
    {
        currencyUI = GameObject.Find("Currency");
    }

    // Update is called once per frame
    void Update()
    {
    }
}
