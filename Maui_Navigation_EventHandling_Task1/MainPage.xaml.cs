namespace Maui_Navigation_EventHandling_Task1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;
         
        string _newLabel = "Welcome to MAUI";
        private string _entryText;
        private Color _labelColor = Colors.Black;
        public MainPage()
        {             
            InitializeComponent();
            BindingContext = this;
        }

        private async void OnNavigateButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GetProductPage());
        }

        
        public string NewLabel
        {
            get => _newLabel;
            set
            {
                _newLabel = value;
                OnPropertyChanged(); // Notify the binding system of changes
            }
        }

        public string EntryText
        {
            get => _entryText;
            set
            {
                if (_entryText != value)
                {
                    _entryText = value;
                    OnPropertyChanged();
                    // Update NewLabel when EntryText changes
                }
            }
        }
        public Color LabelColor
        {
            get => _labelColor;
            set
            {
                if (_labelColor != value)
                {
                    _labelColor = value;
                    OnPropertyChanged();
                }
            }
        }
        

        private void OnLabelChanged(object sender, EventArgs e)
        {
            NewLabel = EntryText;
            LabelColor = Colors.Blue;
        }
        private void OnResetClicked(object sender, EventArgs e)
        {
            NewLabel = "Welcome to MAUI"; // Reset to initial text or empty
            LabelColor = Colors.Black;   // Reset to initial color
            EntryText = "";    // Clear the entry text
        }
    }

}
