using System.Windows;

namespace CSharp9._5PracticeWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SplitButton_Click(object sender, RoutedEventArgs e)
        {
            Task1ListBox.ItemsSource = Task1.Task1.SplitText(Task1TextBox.Text);
        }

        private void ReverseButton_Click_1(object sender, RoutedEventArgs e)
        {
            Task2Label.Content = Task2.Task2.Reverse(Task2TextBox.Text);
        }
    }
}
