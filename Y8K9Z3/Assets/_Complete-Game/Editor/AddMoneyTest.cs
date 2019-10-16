using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class AddMoneyTest : MonoBehaviour
{
    
    [Test]
    public void AddMoney_Test()
    {
        //Arrange (Default value player is set when loaded into game)
        var coin = 0;
        var expectedCoin = 10;

        //ACT (When player walks over a coin)
        coin += 10;

        //Assert 
        Assert.That(coin,Is.EqualTo(expectedCoin));
    }

    [Test]
    public void AddMoney_Fail()
    {
        //Arrange (Default value player is set when loaded into game)
        var coin = 0;
        var expectedCoin = 10;

        //ACT (When player walks over a coin)
        coin += 0;

        //Assert
        Assert.That(coin, Is.EqualTo(expectedCoin));
    }
}
