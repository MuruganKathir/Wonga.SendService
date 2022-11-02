using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Wonga.Common;
using Wonga.SendMessage.Contracts.SendMessage;
using Wonga.SendMessage.Orchestrations.SendMessage;
using Wonga.SendMessageTest.TestData;

namespace Wonga.SendMessageTest
{
    [TestClass]
    public class SendMessageOrchestrationTest
    {
        [TestMethod]
        public void ValidMessageTest()
        {
            //Arrange
            var sendMessageOrchestration = WongaFactory.CreateInstance<ISendMessageOrchestrations>();
            //Act
            var outcome = sendMessageOrchestration.SendMessage(ObjectMother.ValidMessage);

            //Assert
            Assert.IsNotNull(outcome);
        }

        [TestMethod]
        public void InValidMessageTest()
        {
            //Arrange
            var sendMessageOrchestration = WongaFactory.CreateInstance<ISendMessageOrchestrations>();
            //Act
            var outcome = sendMessageOrchestration.SendMessage(ObjectMother.InValidMessage);

            //Assert
            Assert.IsNotNull(outcome);
        }

    }
}
