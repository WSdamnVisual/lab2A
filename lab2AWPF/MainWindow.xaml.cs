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
using lab2AWPF;

namespace lab2AWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        String temp = "";

        public MainWindow()
        {
            InitializeComponent();
            rbRect.IsChecked = true;
        }

        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {
            if (rbRect.IsChecked.Value)
            {
                var shape = new Rect(Convert.ToSingle(tbxLenRad.Text), Convert.ToSingle(tbxWidth.Text));
                lblNameOut.Content = shape.GetName();
                lblLenRadValueOut.Content = shape.GetX();
                lblWidthOut.Content = shape.GetY();
                lblPerim.Content = Math.Round(shape.GetPerimeter(), 3);
                lblArea.Content = Math.Round(shape.GetArea(), 3);
            }
            if (rbSquare.IsChecked.Value)
            {
                var shape = new Square(Convert.ToSingle(tbxLenRad.Text));
                lblNameOut.Content = rbRect.Content;
                lblNameOut.Content = shape.GetName();
                lblLenRadValueOut.Content = shape.GetX();
                lblWidthOut.Content = shape.GetY();
                lblPerim.Content = Math.Round(shape.GetPerimeter(), 3);
                lblArea.Content = Math.Round(shape.GetArea(), 3);
            }
            if (rbCircle.IsChecked.Value)
            {
                var shape = new Circle(Convert.ToSingle(tbxLenRad.Text));
                lblNameOut.Content = shape.GetName();
                lblLenRadValueOut.Content = shape.GetR();
                lblPerim.Content = Math.Round(shape.GetPerimeter(), 3);
                lblArea.Content = Math.Round(shape.GetArea(), 3);
            }

        }

        private void rbRect_Checked(object sender, RoutedEventArgs e)
        {
            tbxWidth.Text = temp;
            lblLenRad.Content = lblLenRadOut.Content = "Длина: ";
            RowToHide.Height = OutRowToHide.Height = new GridLength(1, GridUnitType.Star);
            lblNameOut.Content = rbRect.Content;
            if (String.IsNullOrWhiteSpace(tbxLenRad.Text) || String.IsNullOrWhiteSpace(tbxWidth.Text))
                btnEnter.IsEnabled = false;
            else
                btnEnter.IsEnabled = true;
        }

        private void rbSquare_Checked(object sender, RoutedEventArgs e)
        {
            if(RowToHide.Height.Value != 0)
            temp = tbxWidth.Text;
            lblLenRad.Content = lblLenRadOut.Content = "Длина: ";
            RowToHide.Height = OutRowToHide.Height = new GridLength(0);
            lblNameOut.Content = rbSquare.Content;
            tbxWidth.Clear();
            if (String.IsNullOrWhiteSpace(tbxLenRad.Text))
                btnEnter.IsEnabled = false;
            else
                btnEnter.IsEnabled = true;
        }

        private void rbCircle_Checked(object sender, RoutedEventArgs e)
        {
            if (RowToHide.Height.Value != 0)
                temp = tbxWidth.Text;
            lblLenRad.Content = lblLenRadOut.Content = "Радиус";
            RowToHide.Height = OutRowToHide.Height = new GridLength(0);
            lblNameOut.Content = rbCircle.Content;
            tbxWidth.Clear();
            if (String.IsNullOrWhiteSpace(tbxLenRad.Text))
                btnEnter.IsEnabled = false;
            else
                btnEnter.IsEnabled = true;
        }

        private void tbxLenRad_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            TextBox tbx = (TextBox)sender;
            e.Handled = true;

            if (Char.IsDigit(e.Text, 0) || Char.IsControl(e.Text, 0))
                e.Handled = false;
            else if (String.IsNullOrWhiteSpace(tbx.Text))
            { }
            else
            {
                if (e.Text == "," && !tbx.Text.Contains(","))
                    e.Handled = false;
                if (e.Text == "." && !tbx.Text.Contains(","))
                {
                    tbx.Text += ",";
                    tbx.CaretIndex = tbx.Text.Length;
                }
            }


        }

        private void tbxLenRad_KeyUp(object sender, KeyEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(tbxLenRad.Text))
            {
                if (RowToHide.Height.Value != 0 && String.IsNullOrWhiteSpace(tbxWidth.Text))
                    btnEnter.IsEnabled = false;
                else
                    btnEnter.IsEnabled = true;
            }
            else
                btnEnter.IsEnabled = false;
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
