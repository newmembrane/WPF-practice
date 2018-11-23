using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Att_Check
{
    public class UserManager
    {
        public ObservableCollection<User> Users = new ObservableCollection<User>();
		public event PropertyChangedEventHandler PropertyChanged;

		public UserManager()
        {
            //생성자
            var myUser = new User
            {
                Name = "신종훈",
                Gender = GenderType.Male,
                IsAttended = false
            };
            Users.Add(myUser);

            var myUser2 = new User
            {
                Name = "sjh봇",
                Gender = GenderType.Male,
                IsAttended = true
            };
            Users.Add(myUser2);
        }
		public void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		public void Delete(int index)
		{
			Users.RemoveAt(index);
		}
		
    }
}
