using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace AgTransitionControl_CustomEffect {
    public partial class MainPage : UserControl {
        int index;
        public MainPage() {
            InitializeComponent();
            trControl.Content = GetElement("r0");
        }
        private void trControl_MouseLeftButtonUp(object sender, MouseButtonEventArgs e) {
            if (index == 2)
                index = 0;
            else
                index++;
            trControl.Content = GetElement("r" + index.ToString());
        }
        private FrameworkElement GetElement(string id) {
            return (FrameworkElement)((DataTemplate)LayoutRoot.Resources[id]).LoadContent();
        }
    }
}
