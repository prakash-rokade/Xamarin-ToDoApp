﻿using Prism.Mvvm;
using System.Collections.ObjectModel;
using System.ComponentModel;
using ToDoApp.Helpers;
using ToDoApp.Models;

namespace ToDoApp.ViewModels.Templates
{
    public class AddListViewModel: BindableBase, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ListModel AddList { get; set; }
        public ObservableCollection<string> ColorList { get; set; }

        public AddListViewModel(): base()
        {
            ColorList = Constants.ListColorList;
            AddList = Constants.DefaultList;
        }
    }
}