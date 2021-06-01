using System;
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


namespace Testing
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<string> cmblist = new List<string>() { "*", "+", "-", "^", "/"};
            cmb.ItemsSource = cmblist;
            Plus plusik = new Plus();
            //Plus(txt1.Text, txt2.Text);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Plus plusik = new Plus();
            //plusik.Pluss();
            if (cmb.SelectedIndex == 0)
            {
                var num1 = Convert.ToDouble(txt1.Text);
                var num2 = Convert.ToDouble(txt2.Text);
                txtblock.Text = Convert.ToString(Plus.Multiplication(num1,num2)); 
            }
            if (cmb.SelectedIndex == 1)
            {
                var num1 = Convert.ToDouble(txt1.Text);
                var num2 = Convert.ToDouble(txt2.Text);
                txtblock.Text = Convert.ToString(Plus.Pluss(num1,num2));
            }
            if (cmb.SelectedIndex == 2)
            {
                var num1 = Convert.ToDouble(txt1.Text);
                var num2 = Convert.ToDouble(txt2.Text);
                txtblock.Text = Convert.ToString(Plus.Minus(num1,num2));
            }
            if (cmb.SelectedIndex == 3)
            {
                var num1 = Convert.ToDouble(txt1.Text);
                var num2 = Convert.ToDouble(txt2.Text);
                txtblock.Text = Convert.ToString(Plus.Degree(num1,num2));
            }
            if (cmb.SelectedIndex == 4)
            {
                var num1 = Convert.ToDouble(txt1.Text);
                var num2 = Convert.ToDouble(txt2.Text);
                txtblock.Text = Convert.ToString(Plus.Division(num1,num2));
            }
        }


        private void cmb_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            int a = cmb.SelectedIndex;
            MessageBox.Show("Work!"+ a);

        }
    }
}
