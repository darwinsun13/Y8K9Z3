using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class ItemCalculatorTests
{
    [Test]
    public void CalculateTotalPotionPoints_Test()
    {
        // ARRANGE
        var pointCalculator = new ItemCalculator();
        var playerHp = 100;
        var potionPoints = 20;
        var expectedPoints = (100 + 20);

        // ACT
        var points = pointCalculator.CalculateTotalPoints(playerHp, potionPoints);

        // ASSERT
        Assert.That(points, Is.EqualTo(expectedPoints));

    }

    [Test]
    public void CalculateTotalCoinPoints_Test()
    {
        // ARRANGE
        var pointCalculator = new ItemCalculator();
        var playerHp = 90;
        var coinPoints = 10;
        var expectedPoints = (100 + 10);

        // ACT
        var points = pointCalculator.CalculateTotalPoints(playerHp, coinPoints);

        // ASSERT
        Assert.That(points, Is.EqualTo(expectedPoints));

    }

    [Test]
    public void PotionPickedUp_Test()
    {
        // ARRANGE
        GameObject gameObject = new GameObject();
        gameObject.AddComponent<Completed.Player>();
        var player = gameObject.GetComponent<Completed.Player>();
        //var potionItem = player.FindWithTag("Potion");
        var expected = true;

        // ACT
        //player.OnTriggerEnter2D(potionItem);
        var itemPickUp = player.isPickedUp;

        // ASSERT
        Assert.That(expected, Is.EqualTo(itemPickUp));

    }
}
