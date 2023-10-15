using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Bank.Services
{
    public interface IDialogService
    {
        void OpenDialog<T>() where T : Window, new();
    }
}