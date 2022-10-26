using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;

namespace WCF_Chat
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class ChatService1 : IChatService1
    {
        List<ServerUser> users = new List<ServerUser>();
        int nextID = 1;

        public int Connect(string name)
        {
            ServerUser user = new ServerUser(){
                ID = nextID,
                Name = name,
                operationContext = OperationContext.Current
            };
            nextID++;
            SendMessage(": " + user.Name + " подключился к чату!", 0);
            users.Add(user);
            return user.ID;
        }

        public void Disconnect(int ID)
        {
            var user = users.FirstOrDefault(i => i.ID == ID);
            if(user != null)
            {
                users.Remove(user);
                SendMessage(": " + user.Name + " отключился", 0);
            }
        }

        public void SendMessage(string message, int ID)
        {
            foreach(var it in users)
            {
                string answer = DateTime.Now.ToShortTimeString();
                var user = users.FirstOrDefault(i => i.ID == ID);
                if (user != null)
                {
                    answer += ": " + user.Name + ": ";
                }
                answer += message;

                it.operationContext.GetCallbackChannel<IServerChatCallBack>().MessageCallBack(answer);
            }
        }
    }
}
