﻿using System;
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
using Gra.ViewModel;

namespace Gra.View
{
    /// <summary>
    /// Interaction logic for AccountCreationPage.xaml
    /// </summary>
    public partial class AccountCreationPage : Page
    {
        public AccountCreationPage()
        {
            InitializeComponent();
            DataContext = new AccountCreationPageHandler();
        }
    }
}
