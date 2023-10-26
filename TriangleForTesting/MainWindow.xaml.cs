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

namespace TriangleForTesting
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

        private void btn_clicked(object sender, RoutedEventArgs e)
        {
            Lbl.Content = "Click";
            UInt32 A, B, C;

            try
            {
                A = Convert.ToUInt32(TxtA.Text);
                B = Convert.ToUInt32(TxtB.Text);
                C = Convert.ToUInt32(TxtC.Text);

                if (A == 0 || B == 0 || C == 0) 
                {
                    Lbl.Content = ("Sides cannot be equal to 0.");
                    return;
                }

                if (A >= C+B || C >= A+B || B >= A+C) 
                {
                    Lbl.Content = ("This is an impossible triangle. \nBiggest side should be less than the sum of the others.");
                    return;
                }

                if (A == B && B == C) 
                {
                    Lbl.Content = ("This is equilateral triangle.");
                    return;
                }

                if (A == B || B == C || A == C)
                {
                    Lbl.Content = ("This is isosceles triangle.");
                    return;
                }
                else
                {
                    Lbl.Content = ("This is scalene triangle.");
                }

                //Lbl.Content = A+B+C;
            }
            catch
            {
                Lbl.Content = ("Incorrect sides entered. Try others.");
            }

            
                
        }
    }
}
