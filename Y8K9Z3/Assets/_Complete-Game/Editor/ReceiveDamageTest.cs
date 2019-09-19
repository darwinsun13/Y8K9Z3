using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class ReceiveDamageTest
{
    [Test]
    public void ReceiveDamage_Test()
    {
        // ARRANGE
        //GameObject enemyGameObject = MonoBehaviour.Instantiate(Resources.Load<GameObject>("_Complete-Game/Scripts"));
        //var enemy = enemyGameObject.GetComponent<Completed.Enemy>();
        GameObject gameObject = new GameObject();
        gameObject.AddComponent<Completed.Enemy>();
        var enemy = gameObject.GetComponent<Completed.Enemy>();
        var damage = 100;
        var expected = false;

        // ACT
        enemy.ReceiveDamage(damage);
        var enemyDeath = enemy.isAlive;

        // ASSERT
        Assert.That(expected, Is.EqualTo(enemyDeath));
    }
}
