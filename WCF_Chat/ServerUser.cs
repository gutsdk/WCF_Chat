﻿using System.ServiceModel;

namespace WCF_Chat
{
    class ServerUser
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public OperationContext operationContext { get; set; }

    }
}
