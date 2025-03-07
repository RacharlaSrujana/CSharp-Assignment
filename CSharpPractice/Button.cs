using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    public delegate void ClickHandler();
    class Button
    {
        public event ClickHandler OnClick;

        public string ButtonText { get; set; }

        public Button(string buttonText)
        {
            ButtonText = buttonText;
        }

        // Method to simulate clicking the button
        public void Click()
        {
            Console.WriteLine($"{ButtonText} button clicked!");
            // Trigger the event if there are any subscribers
            OnClick?.Invoke();
        }
    }
}
