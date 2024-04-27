using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using wpf_chat_task.Models;

namespace wpf_chat_task
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            list1.ItemsSource = Database.Messages; list1.SelectedIndex = 0;
           
        }

        private void send_btn_Click(object sender, RoutedEventArgs e)
        {
            if (txt.Text != "")
            {
                string t="";
                if (DateTime.Now.Hour.ToString().Length == 1)
                {
                    t = "0";
                    t += DateTime.Now.Hour.ToString();
                }
                else
                {
                    t += DateTime.Now.Hour.ToString();
                }
                t += ":";
                if (DateTime.Now.Minute.ToString().Length == 1)
                {
                    t += "0";
                    t += DateTime.Now.Minute.ToString();
                }
                else
                {
                    t += DateTime.Now.Minute.ToString();
                }
                _Time time = new _Time(t);
                Database.times.Add(time);
                list1.ItemsSource = null;
                list1.ItemsSource = Database.times;

                Message message = new Message(txt.Text);
                Database.Messages.Add(message);
                list2.ItemsSource = null;
                list2.ItemsSource = Database.Messages;

                if(message.Text=="Salam"|| message.Text == "salam" || message.Text == "hello" || message.Text == "SALAM" 
                    || message.Text == "Hello" || message.Text == "HELLO" || message.Text == "Halo" || message.Text == "HALO"
                    || message.Text == "halo"|| message.Text == "Selam" || message.Text == "selam" || message.Text == "SELAM")
                {
                    
                    _Time time2 = new _Time(t);
                    Database.times.Add(time2);
                    list1.ItemsSource = null;
                    list1.ItemsSource = Database.times;

                    Message message2 = new Message("SALAMMM");
                    Database.Messages.Add(message2);
                    list2.ItemsSource = null;
                    list2.ItemsSource = Database.Messages;
                }
                else if(message.Text=="Necesen"|| message.Text == "necesen" || message.Text == "NECESEN" || message.Text == "How are you" 
                    || message.Text == "HOW ARE YOU" || message.Text == "how are you" || message.Text == "nasilsin" || message.Text == "NASILSIN"
                    || message.Text == "NASILSIN")
                {
                    _Time time2 = new _Time(t);
                    Database.times.Add(time2);
                    list1.ItemsSource = null;
                    list1.ItemsSource = Database.times;

                    Message message2 = new Message("Yaxsiyam sen?");
                    Database.Messages.Add(message2);
                    list2.ItemsSource = null;
                    list2.ItemsSource = Database.Messages;
                }
                else if(message.Text=="yaxsi"|| message.Text == "Yaxsi" || message.Text == "YAXSI" || message.Text == "good" 
                    || message.Text == "GOOD" || message.Text == "Good" || message.Text == "iyi" || message.Text == "IYI"
                    || message.Text == "Iyi"|| message.Text == "Mohtesem" || message.Text == "MOHTESEM" || message.Text == "mohtesem"
                    )
                {
                    _Time time2 = new _Time(t);
                    Database.times.Add(time2);
                    list1.ItemsSource = null;
                    list1.ItemsSource = Database.times;

                    Message message2 = new Message("Ela");
                    Database.Messages.Add(message2);
                    list2.ItemsSource = null;
                    list2.ItemsSource = Database.Messages;
                }
                else if(message.Text=="pis"|| message.Text == "Pis" || message.Text == "PIS" || message.Text == "yaxsi deyilem" 
                    || message.Text == "yaxsi deilem" || message.Text == "Berbad" || message.Text == "BERBAD" || message.Text == "berbad"
                    || message.Text == "normal"|| message.Text == "NORMAL" || message.Text == "Normal"
                    )
                {
                    _Time time2 = new _Time(t);
                    Database.times.Add(time2);
                    list1.ItemsSource = null;
                    list1.ItemsSource = Database.times;

                    Message message2 = new Message("Senin yaxsi olmaqini dileyirem");
                    Database.Messages.Add(message2);
                    list2.ItemsSource = null;
                    list2.ItemsSource = Database.Messages;
                }
                else if(message.Text=="Sagol"|| message.Text == "SAGOL" || message.Text == "sagol" || message.Text == "Goruserik" 
                    || message.Text == "goruserik" || message.Text == "GORUSERIK" || message.Text == "Saqol" || message.Text == "SAQOL" || message.Text == "saqol"
                    )
                {
                    _Time time2 = new _Time(t);
                    Database.times.Add(time2);
                    list1.ItemsSource = null;
                    list1.ItemsSource = Database.times;

                    Message message2 = new Message("Saqol^-^");
                    Database.Messages.Add(message2);
                    list2.ItemsSource = null;
                    list2.ItemsSource = Database.Messages;
                }
            }
        }
    }
}