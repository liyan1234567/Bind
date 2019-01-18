using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Binding
{
    public class person:DependencyObject
    {
        
        public string Name
        {
            get { return GetValue(NameProperty).ToString(); }
            set { SetValue(NameProperty,value); }
        }

        public static DependencyProperty NameProperty = DependencyProperty.Register("Name", typeof(string), typeof(person), null);
      
        bool sex;

        public bool Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        int age;

        public int Age
        {
            get { return age; }
            set { age = value; }
        }
    }
}
