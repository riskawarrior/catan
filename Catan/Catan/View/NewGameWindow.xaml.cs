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
using System.Windows.Shapes;
using Catan.Model;
using Catan.ViewModel;
using NewGameContext = Catan.ViewModel.NewGameContext;

namespace Catan.View
{
    /// <summary>
    /// Új játék ablak logikája
    /// </summary>
    public partial class NewGameWindow : Window
    {

        /// <summary>
        /// Konstruktor
        /// Felépíti a felületet
        /// </summary>
        public NewGameWindow()
        {
            InitializeComponent();
        }
    }
}
