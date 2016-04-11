using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    //Throwing a new exception that points to the original one
    class Listing1_96 : IExecuter
    {
        public void Execute(string[] args)
        {
            int orderId = 7;

            try 
            { 
                ProcessOrder(orderId); 
            } 
            catch (MessageQueueException ex) 
            {
                throw new OrderProcessingException(orderId, "Error while processing order", ex); 
            }
        }

        private void ProcessOrder(int orderId)
        {
            throw new MessageQueueException("Internal error in message queue while processing OrderId : " +orderId+ " - error code: 42");
        }
    }

    public class MessageQueueException : Exception
    {
        public MessageQueueException(string message): base(message){}
        public MessageQueueException(string message, Exception innerException) : base(message, innerException){}
    }
}
