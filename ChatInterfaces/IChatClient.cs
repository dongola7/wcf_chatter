// ----------------------------------------------------------------------------
// Copyright 2010 Wyle
// ----------------------------------------------------------------------------
using System.ServiceModel;

namespace ChatInterfaces
{
    public interface IChatClient
    {
        [OperationContract(IsOneWay = true)]
        void ReceiveMessage(string userName, string message);
    }
}