using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class PlayerMovingTest
{
    [Test]
    public void PlayerMoving_Test_ShouldReturnTrue()
    {
        var moving = new MonoBehaviour();
        var result = PlayerMoving_Test(true);
        Assert.IsTrue(result);
    }

    [Test]
    public void PlayerMoving_Test_ShouldReturnFalse()
    {
        var moving = new MonoBehaviour();
        var result = PlayerMoving_Test(false);
        Assert.IsFalse(result);
    }

    [Test]
    public bool PlayerMoving_Test(bool expectedMovingValidality)
    {
        var moving = new MonoBehaviour();
        var result = PlayerMoving_Test(expectedMovingValidality);
        return result;
    }
}
