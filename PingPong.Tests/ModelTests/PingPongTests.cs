using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGame.Models;
using System;

namespace PingPongGame.Tests
{
    [TestClass]
    public class PingPongTests
    {
        [TestMethod]
        public void PingPongConstructor_CreatesInstanceOfPingPong_PingPong()
        {
            PingPong newPingPong = new PingPong(4);
            Assert.AreEqual(typeof(PingPong), newPingPong.GetType());
        }
        [TestMethod]
        public void GetInputNum_ReturnsUserChoice_Int()
        {
            int userInput = 4;
            PingPong newPingPong = new PingPong(userInput);
            // newPingPong.InputNum = userInput;
            // Assert.AreEqual(typeof(newPingPong.InputNum), userInput.GetType());
            Assert.AreEqual(newPingPong.InputNum, userInput);
        }
    }
}