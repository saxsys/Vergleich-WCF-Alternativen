﻿using System.Collections.Generic;
using System.ServiceModel;

// Namespace in Server und Client muss gleich sein, sonst klappt das Deserialisieren bei TCP nicht (binary!!)
namespace CoreWCFChatApplication.Shared.Contract
{
    interface IChatCallback
    {
        [OperationContract(IsOneWay = true)]
        void ReceiveChat(Message message);

        [OperationContract(IsOneWay = true)]
        void RefreshUserList(List<string> userList);
    }
}
