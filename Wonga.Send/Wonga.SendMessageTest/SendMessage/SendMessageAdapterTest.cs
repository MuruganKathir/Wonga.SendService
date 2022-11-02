using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Wonga.Common;
using Wonga.SendMessage.Adapters.Contracts;
using Wonga.SendMessageTest.TestData;

namespace Wonga.SendMessageTest.SendMessage
{
    [TestClass]
    public class SendMessageAdapterTest
    {
        [TestMethod]
        public void SendMessageAdapterSuccessfulTest()
        {
            //Arrange
            var sendMessageAdapter = WongaFactory.CreateInstance<ISendMessageAdapter>();
            //Act
            var outcome = sendMessageAdapter.SendMessage(ObjectMother.ValidRabbitQueueURL);

            //Assert
            Assert.IsNotNull(outcome);
        }

        [TestMethod]
        public void SendMessageAdapterUnSuccessfulTest()
        {
            //Arrange
            var sendMessageAdapter = WongaFactory.CreateInstance<ISendMessageAdapter>();
            //Act
            var outcome = sendMessageAdapter.SendMessage(ObjectMother.InValidRabbitQueueURL);

            //Assert
            Assert.IsNotNull(outcome);
        }

       
    }
}
