namespace Maui_Navigation_EventHandling_Task1;

 public partial class UserInputPage : ContentPage
    {
        public UserInputPage()
        {
            InitializeComponent();
        }

        // Event handler for button click
        private void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            // Get the text from the Entry field
            string inputText = inputEntry.Text;

            // Update the Label's text with the input from the Entry
            displayLabel.Text = $"You entered: {inputText}";
        }
    }