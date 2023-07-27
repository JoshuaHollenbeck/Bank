﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bank.Model;

namespace Bank.ViewModel
{
    class ClientOverviewVM : Utilities.ViewModelBase
    {
        private readonly PageModel _pageModel;
        public int CustomerID
        {
            get { return _pageModel.CustomerCount; }
            set { _pageModel.CustomerCount = value; OnPropertyChanged(); }
        }

        public ClientOverviewVM()
        {
            _pageModel = new PageModel();
            CustomerID = 100528;
        }
    }
}