using System.ServiceModel;

namespace WCF_Chat
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IChatService1" в коде и файле конфигурации.
    [ServiceContract(CallbackContract = typeof(IServerChatCallBack))]
    public interface IChatService1
    {
        [OperationContract]
        int Connect(string name);

        [OperationContract]
        void Disconnect(int ID);

        [OperationContract(IsOneWay = true)]
        void SendMessage(string message, int ID);
    }

    public interface IServerChatCallBack
    {
        [OperationContract(IsOneWay = true)]
        void MessageCallBack(string message);
    }

}
