using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Sigma
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Calls : ContentPage
    {
        
        public Command ChargeCalls { get; set; }

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
        
        public class CallsInfo
        {
            public ImageSource Image { get; set; }
            public string Name { get; set; }
            public string DateTime { get; set; }
        }

        private ObservableCollection<CallsInfo> callsInfos;

        public ObservableCollection<CallsInfo> CallsInfos
        {
            get { return callsInfos; }
            set
            {
                callsInfos = value;
                OnPropertyChanged();
            }
        }
        
        public Calls()
        {
            this.BindingContext = this;

            ChargeCalls = new Command(() =>
            {
                Busy = true;
                CallsInfos.Add(new CallsInfo() { Name = "Andres Cepeda", Image = "https://i.ibb.co/8mtBtSn/captura-de-pantalla-2018-07-13-a-las-4-57-47-p-m.png", DateTime = "Call rejected at: 13:59" });
                Busy = false;
            });
            InitializeComponent();

            CallsInfos = new ObservableCollection<CallsInfo> { };
        }
        
        private void SelectableItemsView_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            App.FlyoutP.Detail.Navigation.PushAsync(new ChatSimulation());
            App.FlyoutP.IsPresented = false;
        }
    }
}