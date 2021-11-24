using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HomeWork14WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Problem> problems;
        public MainWindow()
        {
            InitializeComponent();
            problems = new ObservableCollection<Problem>();
            problems.Add(new Problem()
            {
                ProblemName = "Пылесос",
                Description = "Data/1.png",
                Priority = 10000,
                ProblemType = ProblemTypes.Appliances
            });
            problems.Add(new Problem()
            {
                ProblemName = "Морковь",
                Description = "Data/2.png",
                Priority = 40,
                ProblemType = ProblemTypes.Food
            });
            problems.Add(new Problem()
            {
                ProblemName = "Помидоры",
                Description = "Data/3.png",
                Priority = 298,
                ProblemType = ProblemTypes.Food
            });
            lstBox.ItemsSource = problems;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            problems.Add(new Problem()
            {
                ProblemName = "Огурцы",
                Description = "Data/4.png",
                Priority = 150,
                ProblemType = ProblemTypes.Food
            });
        }
    }
}
