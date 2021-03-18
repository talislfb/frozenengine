using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FrozenEditor.GameProject
{
    /// <summary>
    /// Interaction logic for ProjectBrowserDialog.xaml
    /// </summary>
    public partial class ProjectBrowserDialog : Window
    {
        public ProjectBrowserDialog()
        {
            InitializeComponent();
        }

        private void OnToggleButton_Clicked(object Sender, RoutedEventArgs e)
        {
            if(Sender == ButtonOpenProject)
            {
                if(ButtonCreateProject.IsChecked == true)
                {
                    ButtonCreateProject.IsChecked = false;
                    ProjectBrowserContent.Margin = new Thickness(0);
                }
                ButtonOpenProject.IsChecked = true;
            }
            else
            {
                if(ButtonOpenProject.IsChecked == true)
                {
                    ButtonOpenProject.IsChecked = false;
                    ProjectBrowserContent.Margin = new Thickness(-800, 0, 0, 0);
                }
                ButtonCreateProject.IsChecked = true;
            }
        }
    }
}
