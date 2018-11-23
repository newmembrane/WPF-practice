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

namespace Att_Check
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        UserManager UM = new UserManager();
        public MainWindow()
        {
            InitializeComponent();
            
            userList.ItemsSource = UM.Users;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var user_name = userName.Text;
            GenderType user_gender;
            if (gender.SelectedIndex == 0) user_gender = GenderType.Male;
            else user_gender = GenderType.Female;
            UM.Users.Add(new User
            {
                Name = user_name,
                Gender = user_gender
            });
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        
        private void Del_Button_Click(object sender, RoutedEventArgs e)
        {
			//userList.SelectedItem
			try
			{
				UM.Delete(userList.SelectedIndex);

			}
			catch(ArgumentOutOfRangeException OoRex)
			{
				MessageBox.Show("삭제하려는 명단을 눌러주세요.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.TargetSite+"\n"+ex.Message);
			}
        }

		private void Btn_check_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				UM.Users.ElementAt(userList.SelectedIndex).Check();

			}
			catch (ArgumentOutOfRangeException OoRex)
			{
				MessageBox.Show("출석하려는 명단을 눌러주세요.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.TargetSite + "\n" + ex.Message);
			}
		}
	}
}
