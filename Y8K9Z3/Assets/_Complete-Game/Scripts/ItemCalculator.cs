using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCalculator 
{
    public int CalculateTotalPoints(
        int potionPoints,
        int coinPoints)
    {
        int points = 0;

        points += potionPoints + 20;
        //points += coinPoints + 10;

        return points; 

    }

}
