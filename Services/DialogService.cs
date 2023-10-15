using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Bank.Services
{
    public class DialogService : IDialogService
    {
        public void OpenDialog<T>() where T : Window, new()
        {
            T view = new T();
            view.ShowDialog();
        }
    }
}