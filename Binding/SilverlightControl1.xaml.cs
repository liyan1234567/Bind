using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Binding
{
    public partial class SilverlightControl1 : UserControl
    {
        person p = new person() { Name="张三",Sex=true,Age=12};
        public SilverlightControl1()
        {
            InitializeComponent();
        }

        private void usercontrol_Loaded(object sender, RoutedEventArgs e)
        {
            li.DataContext = p;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(p.Name);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            p.Name = "lisi";
        }

    }
}
