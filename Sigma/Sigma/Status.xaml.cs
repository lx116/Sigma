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
    public partial class Status : ContentPage
    {
        public class StatusInfo
        {
            public ImageSource Image { get; set; }
            public string Name { get; set; }
        }
        
        private ObservableCollection<StatusInfo> statusInfos;

        public ObservableCollection<StatusInfo> StatusInfos
        {
            get { return statusInfos; }
            set
            {
                statusInfos = value;
                OnPropertyChanged();
            }
        }
        
        public Status()
        {
            this.BindingContext = this;
            StatusInfos = new ObservableCollection<StatusInfo>
            {
                new StatusInfo
                {
                    Image = "https://i.ibb.co/G9qGdkL/ebdad2f7-4276-4103-ba78-db3776181f8f-16-9-discover-aspect-ratio-default-0.jpg",
                     Name = "Boba"
                },
                new StatusInfo
                {
                    Image = "https://i.ibb.co/6Fywh8R/pelee.jpg",
                     Name = "Pele"
                },
                new StatusInfo
                {
                    Image = "https://i.ibb.co/n8CpPrK/tetetetetetete.jpg",
                     Name = "Arturito"
                },
                new StatusInfo
                {
                    Image = "https://i.ibb.co/MkD9c8b/f5e5e726-af1c-462b-b6e6-f70e89cf0ebc-alta-libre-aspect-ratio-default-0.jpg",
                     Name = "Xavineta"
                },
               
            };
            InitializeComponent();
        }
    }
}