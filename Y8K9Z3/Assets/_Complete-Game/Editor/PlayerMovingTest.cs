using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class PlayerMovingTest
{
    [Test]
    public void PlayerMoving_Test_ShouldReturnTrue()
    {
        var result = PlayerMoving_Test(true);
        Assert.IsTrue(result);
    }

    [Test]
    public void PlayerMoving_Test_ShouldReturnFalse()
    {
        var result = PlayerMoving_Test(false);
        Assert.IsFalse(result);
    }

    private bool PlayerMoving_Test(bool expectedMovingValidality)
    {
        bool result = true;

        return result;
    }
}
