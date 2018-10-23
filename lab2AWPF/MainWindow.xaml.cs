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
using lab2AConsole;


namespace lab2AWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (rbRect.IsChecked.Value)
            {
                var shape = new lab2AConsole.Rect(tbxName.Text, Convert.ToInt32(tbxLenRad.Text), Convert.ToInt32(tbxWidth.Text));
                lblNameOut.Content = shape.GetName();
                lblLenRadValueOut.Content = shape.GetX();
                lblWidthOut.Content = shape.GetY();
                lblPerim.Content = shape.GetPerimeter();
                lblArea.Content = shape.GetArea();
            }
            if (rbSquare.IsChecked.Value)
            {
                var shape = new Square(tbxName.Text, Convert.ToInt32(tbxLenRad.Text));
                lblNameOut.Content = shape.GetName();
                lblLenRadValueOut.Content = shape.GetX();
                lblWidthOut.Content = shape.GetY();
                lblPerim.Content = shape.GetPerimeter();
                lblArea.Content = shape.GetArea();
            }
            if (rbCircle.IsChecked.Value)
            {
                var shape = new Circle(tbxName.Text, Convert.ToInt32(tbxLenRad.Text));
                lblNameOut.Content = shape.GetName();
                lblLenRadValueOut.Content = shape.GetR();
                lblPerim.Content = shape.GetPerimeter();
                lblArea.Content = shape.GetArea();
            }

        }

        private void rbRect_Checked(object sender, RoutedEventArgs e)
        {
            lblLenRad.Content = lblLenRadOut.Content = "Длина: ";
            RowToHide.Height = OutRowToHide.Height = new GridLength(1, GridUnitType.Star);

        }

        private void rbSquare_Checked(object sender, RoutedEventArgs e)
        {
            lblLenRad.Content = lblLenRadOut.Content = "Длина: ";
            RowToHide.Height = OutRowToHide.Height = new GridLength(0);
        }

        private void rbCircle_Checked(object sender, RoutedEventArgs e)
        {
            lblLenRad.Content = lblLenRadOut.Content = "Радиус";
            RowToHide.Height = OutRowToHide.Height = new GridLength(0);
        }

        private void tbxLenRad_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0) && !Char.IsControl(e.Text, 0) && e.Text != ",")
            {
                e.Handled = true;
                if (e.Text == ".")
                {
                    ((TextBox)sender).Text += ",";
                    ((TextBox)sender).CaretIndex = ((TextBox)sender).Text.Length;
                }
            }
        }

        private void tbxLenRad_KeyUp(object sender, KeyEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbxWidth.Text) && String.IsNullOrWhiteSpace(tbxName.Text))
                btnEnter.IsEnabled = false;
            else
                btnEnter.IsEnabled = true;
        }

    }
}
/*
 *  e.Text = , (на клаве около shift)
 *  e.Key = OemComma
 *  e.Text = . (на клаве около shift)
 *  e.Key = OemPeriod
 *  e.Text = . (на NumPad)
 *  e.Key = Decimal
 */
