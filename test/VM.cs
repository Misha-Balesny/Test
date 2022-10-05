using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System;

namespace test
{
    internal class VM
    {
        private UserModel selectedUser;
        public ObservableCollection<UserModel> Users { get; set; }
        public ObservableCollection<LineModel> Lines { get; set; }
        private RelayCommand saveCommand;
        public RelayCommand SaveCommand
        {
            get
            {
                return saveCommand ??
                  (saveCommand = new RelayCommand(obj =>
                  {
                      FileHandler.SaveUserInfo(SelectedUser);
                  }));
            }
        }
        public UserModel SelectedUser
        {
            get { return selectedUser; }
            set
            {
                selectedUser = value;
                OnPropertyChanged("SelectedUser");
                if (selectedUser != null)
                {
                    Drawer.Draw(Lines, selectedUser);
                }
            }
        }

        public VM()
        {
            int avgSteps = 0;
            Users = new ObservableCollection<UserModel> { };
            var users = FileHandler.CreateUsers();
            foreach (var user in users)
            {
                avgSteps += user.AvgSteps;
            }
            avgSteps = avgSteps/users.Length;
            foreach (var user in users) 
            {
                if (Math.Abs(avgSteps - user.AvgSteps) > avgSteps/5)
                {
                    user.Color = "LightCoral";
                }
                else
                {
                    user.Color = "White";
                }
                Users.Add(user);
            }
            Lines = new ObservableCollection<LineModel> { };
            
            if (selectedUser != null)
            {
                Drawer.Draw(Lines, selectedUser);
            }
        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }        
    }
}

