using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGame.Models;
using System;
using System.Collections.Generic;

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
            Assert.AreEqual(newPingPong.InputNum.GetType(), userInput.GetType());
            Assert.AreEqual(newPingPong.InputNum, userInput);
        }
        [TestMethod]
        public void SetInputNum_ReturnsUserChoice_Int()
        
        {
            int userInput = 4;
            PingPong newPingPong = new PingPong(userInput);
            int userInput2 = 5;
            newPingPong.InputNum = userInput2;
            Assert.AreEqual(newPingPong.InputNum, userInput2);

        }
        // [TestMethod]
        // public void GetInputNum_Returns_Error()
        // {
        //     string userInput = "4";
        //     PingPong newPingPong = new PingPong(userInput);
        //     // newPingPong.InputNum = userInput;
        //     Assert.AreEqual(newPingPong.InputNum.GetType(), userInput.GetType());
        //     //Assert.AreEqual(newPingPong.InputNum, userInput);
        // }
        [TestMethod]
        public void GetOutputList_ReturnsOutputList_List()
        {
            int userinput = 4;
            PingPong newPingPong = new PingPong(userinput);
            Assert.AreEqual(newPingPong.OutputList.GetType(), typeof(List<string>));
        }
    }

}