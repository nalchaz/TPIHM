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
using System.Windows.Shapes;
using TPIHM.ViewModels;
using View.Models;

namespace TPIHM
{
    /// <summary>
    /// Interaction logic for AddView.xaml
    /// </summary>
    public partial class AddView : Window
    {
        public FilmViewModel FilmViewModel;

        public AddView()
        {
            FilmViewModel = new FilmViewModel(new Film());
            DataContext = FilmViewModel;
            InitializeComponent();
        }

    }
}
