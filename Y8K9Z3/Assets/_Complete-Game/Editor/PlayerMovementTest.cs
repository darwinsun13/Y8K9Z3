using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class PlayerMovementTest
    {
        // A Test behaves as an ordinary method
        [Test]
        public void PlayerMovementTestSimplePasses()
        {
            var player = new Completed.Player;

            // Use the Assert class to test conditions
        }

        // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
        
        [UnityTest]
        public IEnumerator PlayerMovementTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
