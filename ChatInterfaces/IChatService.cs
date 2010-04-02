// ----------------------------------------------------------------------------
// Copyright 2010 Wyle
// ----------------------------------------------------------------------------
using System.ServiceModel;

namespace ChatInterfaces
{
    [ServiceContract(CallbackContract = typeof(IChatClient))]
    public interface IChatService
    {
        [OperationContract]
        void Login(string userName);

        [OperationContract]
        void Logout();

        [OperationContract]
        void SendMessage(string message);

        ChatUser[] LoggedInUsers
        { 
            [OperationContract]
            get;
        }
    }
}