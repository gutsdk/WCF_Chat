using System.Windows;
using System.Windows.Input;
using Client.ServiceReference1;

namespace Client
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IChatService1Callback
    {
        bool isConnected = false;
        ChatService1Client client;
        int ID;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        void ConnectUser()
        {
            if(!isConnected)
            {
                client = new ChatService1Client(new System.ServiceModel.InstanceContext(this));
                ID = client.Connect(tbUserName.Text);
                tbUserName.IsEnabled = false;
                buttConn.Content = "Отключиться";
                isConnected = true;
            }
        }

        void DisconnectUser()
        {
            if (isConnected)
            {
                client.Disconnect(ID);
                client = null;
                tbUserName.IsEnabled = true;
                buttConn.Content = "Подключиться";
                isConnected = false;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (isConnected)
            {
                DisconnectUser();
            } 
            else
            {
                ConnectUser();
            }
        }

        public void MessageCallBack(string message)
        {
            lbChat.Items.Add(message);
            lbChat.ScrollIntoView(lbChat.Items[lbChat.Items.Count-1]);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DisconnectUser();
        }

        private void TbMsg_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                if (client != null)
                {
                    client.SendMessage(tbMsg.Text, ID);
                    tbMsg.Text = string.Empty;
                }
            }
        }
    }
}