﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Catan.Model;
using Catan.ViewModel;

namespace Catan.View
{
    /// <summary>
    /// Interaction logic for NewGameView.xaml
    /// </summary>
    public partial class NewGameView : UserControl
    {
        public NewGameView()
        {
            InitializeComponent();
            DataContext = new NewGameContext(new[] {
                new Player("Red", PlayerColor.Red), 
                new Player("Blue", PlayerColor.Blue), 
                new Player("Orange", PlayerColor.Orange), 
                new Player("Green", PlayerColor.Green), 
            });
        }
    }
}
