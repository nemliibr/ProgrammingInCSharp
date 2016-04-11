﻿using ProgrammingInCSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingInCSharp.Chapter1
{
    //Creating a custom exception
    class Listing1_98 : IExecuter
    {
        public void Execute(string[] args)
        {
            int orderId = 3;
            throw new OrderProcessingException(orderId);
            throw new OrderProcessingException(orderId, "Processing order with id " + orderId + " failed");
        }
    }

    [Serializable]
    public class OrderProcessingException : Exception, ISerializable
    {
        public int OrderId { get; private set; }

        public OrderProcessingException(int orderId)
        {
            OrderId = orderId;
            this.HelpLink = "http://www.mydomain.com/infoaboutexception";
        }
        
        public OrderProcessingException(int orderId, string message) 
            : base(message)
        {
            OrderId = orderId;
            this.HelpLink = "http://www.mydomain.com/infoaboutexception";
        }
        
        public OrderProcessingException(int orderId, string message, Exception innerException) 
            : base(message, innerException)
        {
            OrderId = orderId;
            this.HelpLink = "http://www.mydomain.com/infoaboutexception";
        }

        protected OrderProcessingException(SerializationInfo info, StreamingContext context)
        {
            OrderId = (int)info.GetValue("OrderId", typeof(int));
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("OrderId", OrderId, typeof(int));
        }
    }
}
