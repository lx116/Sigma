using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sigma
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Chats : ContentPage, INotifyPropertyChanged
    {
        
        public Command ReloadChats { get; set; }
        
        private bool busy;
        public bool Busy
        {
            get 
            { 
                return busy; 
            }
            set 
            { 
                busy = value;
            }
        }
        
        public class ChatsInfo
        {
            public ImageSource Image { get; set; }
            public string Name { get; set; }
            public string Message { get; set; }
        }

        private ObservableCollection<ChatsInfo> chatsInfos;

        public ObservableCollection<ChatsInfo> ChatsInfos
        {
            get { return chatsInfos;}
            set
            {
                chatsInfos = value;
                OnPropertyChanged();
            }
        }
        
        public Chats()
        {
            BindingContext = this;
            
            
            ReloadChats = new Command(()=>
            {
                Busy = true;
                
                ChatsInfos.Add(new ChatsInfo{ Name = "Leo Messi", Image = "https://i.ibb.co/3rPXYDH/messi-cerveza-goles-porteros.jpg", Message = "Lorem ipsum dolor sit amet."});
                ChatsInfos.Add(new ChatsInfo{ Name = "Cristiano Ronaldo", Image = "https://i.ibb.co/qykb9CW/b9ed2262-51e6-40a3-8786-c3d7e5feaca3.webp", Message = "Lorem ipsum dolor sit amet."});
                ChatsInfos.Add(new ChatsInfo{ Name = "George Lucas", Image = "https://i.ibb.co/dJxf9Vr/george-lucas.jpg", Message = "Lorem ipsum dolor sit amet."});
                ChatsInfos.Add(new ChatsInfo{ Name = "Leonardo DiCaprio", Image = "https://i.ibb.co/Sd4J9qd/Getty-Images-1200624256.jpg", Message = "Lorem ipsum dolor sit amet."});
                
                Busy = false;
            });
            InitializeComponent();

            ChatsInfos = new ObservableCollection<ChatsInfo>
            {
                new ChatsInfo
                {
                    Image = "https://i.ibb.co/xsr7pts/the-child-yoda-mandalorian.jpg",
                    Message = "Lorem ipsum dolor sit amet.", Name = "Grogu"
                },
                new ChatsInfo
                {
                    Image = "https://i.ibb.co/p20721p/800px-Mark-Hamill-2017.jpg",
                    Message = "Lorem ipsum dolor sit amet.", Name = "Mark Hamill"
                },
            };

        }
        
        private void SelectableItemsView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.FlyoutP.Detail.Navigation.PushAsync(new ChatSimulation());
            App.FlyoutP.IsPresented = false;
        }
    }
}