using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class ItemCalculatorTests
{
    [Test]
    public void CalculateTotalPoints_Test()
    {
        // ARRANGE
        var pointCalculator = new ItemCalculator();
        var coinPoints = 100;
        var potionPoints = 20;
        var expectedPoints = (100 + 20);

        // ACT
        var points = pointCalculator.CalculateTotalPoints(coinPoints,potionPoints);
        
        // ASSERT
        Assert.That(points, Is.EqualTo(expectedPoints));

    }
}
