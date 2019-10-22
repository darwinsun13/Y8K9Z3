using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class HealthTest 
{
    [Test]
    public void CalculateHealth_Test()
    {
        // ARRANGE
        //GameObject enemyGameObject = MonoBehaviour.Instantiate(Resources.Load<GameObject>("_Complete-Game/Scripts"));
        //var enemy = enemyGameObject.GetComponent<Completed.Enemy>();
        GameObject gameObject = new GameObject();
        gameObject.AddComponent<Completed.Player>();
        var player = gameObject.GetComponent<Completed.Player>();
        var expected = false;
        
        // ACT
        player.CheckIfGameOver();
        var playerDeath = player.hasHealth;

        // ASSERT
        Assert.That(expected, Is.EqualTo(playerDeath));
    }
}
