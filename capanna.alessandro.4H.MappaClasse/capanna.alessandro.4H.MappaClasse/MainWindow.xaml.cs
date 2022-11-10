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

namespace capanna.alessandro._4H.MappaClasse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Quarta Riga

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco sono presenti:" + "Dyrmishi Leo e Chietti Antonio");
            btn1.Content = "Dyrmishi Leo" + "\r\n" + "Chietti Antonio";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Priori Francesco");
            btn2.Content = "Priori Francesco";
        }

        //Terza Riga

        private void Btn20_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Joshep Ricci");
            Btn20.Content = "Joseph Ricci";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Rossini Agostino");
            btn3.Content = "Rossini Agostino";
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco sono presenti: " + "Tumidei Matteo e Cancelieri Andrea");
            btn4.Content = "Tumidei Matteo" + "\n\r" + "Cancelieri Andrea";
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Basilico Karol");
            btn5.Content = "Basilico Karol";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Dervishi Samuele");
            btn6.Content = "Dervishi Samuele";
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "burioli Alessandro");
            btn7.Content = "Burioli Alessandro";
        }

        //Seconda Riga

        private void Btn19_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Ghinelli Johan");
            btn19.Content ="Ghinelli Johan";

        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Casadei Federico");
            btn8.Content = "Casadei Federico";
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Morelli Giovanni");
            btn9.Content = "Morelli Giovannni";
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Zang");
            btn11.Content = "Zang"+"\n\r"+"Capicchioni Davide";
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Islamovsky Fathi");
            btn12.Content = "Islamovsky Fathi";
        }

        //Prima Riga
        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Capanna Alessandro");
            btn13.Content = "Capanna Alessandro";
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Cau Federico");
            btn14.Content ="Cau Federico";
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Lombardi Samuele");
            btn15.Content = "Lombardi Samuele";
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Salvi Matteo");
            btn16.Content = "Salvi Matteo";
        }

        private void Button_Click_16(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("In questo banco è presente: " + "Paolo Pompa");
            btn17.Content = "Paolo Pompa";
        }

        //Cattedra Prof

        private void Button_Click_17(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Nella Cattedra è presente il: " + "Prof Conti Maurizio");
            btn18.Content = "Conti Maurizio" + "\r\n" + "Sartini Massimiliano";
        }

        

        private void Tutti_Click(object sender, RoutedEventArgs e)
        {
            //Cattedra
            btn18.Content = "Conti Maurizio" + "\r\n" + "Sartini Massimiliano";
            //Prima riga
            btn17.Content = "Paolo Pompa";
            btn16.Content = "Salvi Matteo";
            btn15.Content = "Lombardi Samuele";
            btn14.Content = "Cau Federico";
            btn13.Content = "Capanna Alessandro";
            //Seconda riga
            btn12.Content = "Islamovsky Fathi";
            btn11.Content = "Zang"+"\r\n"+"Capicchioni Davide";
            btn9.Content = "Morelli Giovannni";
            btn8.Content = "Casadei Federico";
            btn19.Content = "Ghinelli Johan";
            //Terza riga
            btn7.Content = "Burioli Alessandro";
            btn6.Content = "Dervishi Samuele";
            btn5.Content = "Basilico Karol";
            btn4.Content = "Tumidei Matteo" + "\n\r" + "Cancelieri Andrea";
            btn3.Content = "Rossini Agostino";
            Btn20.Content = "Joseph Ricci";
            //Quarta Riga
            btn2.Content = "Priori Francesco";
            btn1.Content = "Dyrmishi Leo" + "\r\n" + "Chietti Antonio";
        }

        private void Nascosti_Click(object sender, RoutedEventArgs e)
        {
            //Cattedra
            btn18.Content = "";
            //Prima riga
            btn17.Content = "";
            btn16.Content = "";
            btn15.Content = "";
            btn14.Content = "";
            btn13.Content = "";
            //Seconda riga
            btn12.Content = "";
            btn11.Content = "";
            btn9.Content = "";
            btn8.Content = "";
            btn19.Content = "";
            //Terza riga
            btn7.Content = "";
            btn6.Content = "";
            btn5.Content = "";
            btn4.Content = "";
            btn3.Content = "";
            Btn20.Content = "";
            //Quarta Riga
            btn2.Content = "";
            btn1.Content = "";
        }
    }
}
