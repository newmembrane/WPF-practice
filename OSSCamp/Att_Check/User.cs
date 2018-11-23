using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Att_Check
{
    public enum GenderType
    {
        Male,
        Female
    }
    public class User
    {
		public event PropertyChangedEventHandler PropertyChanged;
		public string Name { get; set; }
        //public string Name
        //{
        //    get => Name + "님";
        //    set => Name = value;
        //}
        public GenderType Gender { get; set; }
        public TimeSpan Time { get; set; }
        public bool IsAttended { get; set; }
		public void Check()
		{
			IsAttended = false;
			OnPropertyChanged("IsAttended");
		}
		public void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
