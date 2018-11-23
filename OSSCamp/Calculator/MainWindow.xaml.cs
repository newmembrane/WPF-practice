using System;
using System.Collections.Generic;
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

namespace Calculator
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            try
            {
                
                double left = double.Parse(TextLeft.Text);
                double right = double.Parse(TextRight.Text);
                double result = 0;
                int index = opr.SelectedIndex;
                switch(opr.SelectedIndex)
                {
                    case 0:
                        result = left + right;
                        break;
                    case 1:
                        result = left - right;
                        break;
                    case 2:
                        result = left * right;
                        break;
                    case 3:
                        result = left / right;
                        break;
                }
                MessageBox.Show(result.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
