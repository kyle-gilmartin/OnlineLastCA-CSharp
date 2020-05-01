using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


namespace OnlineLastCA_CSharp
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        ObservableCollection<players> playerName;

        public Window1()
        {
            InitializeComponent();




        }

        private void backbutton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            players p1 = new players("Salah");
            players p2 = new players("Mane");
            players p3 = new players("firmino");
            players p4 = new players("Long");
            players p5 = new players("de bruyne");
            players p6 = new players("laporte");

            playerName = new ObservableCollection<players>();
            playerName.Add(p1);
            playerName.Add(p2);
            playerName.Add(p3);
            playerName.Add(p4);
            playerName.Add(p5);
            playerName.Add(p6);

            lbNames.ItemsSource = playerName;


            born b1 = new born("Afica");
            born b2 = new born("Afica");
            born b3 = new born("Brazil");
            born b4 = new born("Ireland");
            born b5 = new born("Belgium");
            born b6 = new born("France");
            p1.Born.Add(b1);
            p2.Born.Add(b2);
            p3.Born.Add(b3);
            p4.Born.Add(b4);
            p5.Born.Add(b5);
            p6.Born.Add(b6);

            Club c1 = new Club("Liverpool");
            Club c4 = new Club("Southampton");
            Club c5 = new Club("ManCity");
           
            p1.Club.Add(c1);
            p2.Club.Add(c1);
            p3.Club.Add(c1);
            p4.Club.Add(c4);
            p5.Club.Add(c5);
            p6.Club.Add(c5);

            postion n1 = new postion("Forward");
            postion n2 = new postion("Midfield");
            postion n3 = new postion("Defender");

            p1.Postions.Add(n1);
            p2.Postions.Add(n1);
            p3.Postions.Add(n1);
            p4.Postions.Add(n1);
            p5.Postions.Add(n2);
            p6.Postions.Add(n3);

            Wage w1 = new Wage(100000);
            Wage w2 = new Wage(103400);
            Wage w3 = new Wage(100050);
            Wage w4 = new Wage(70000);
            Wage w5 = new Wage(180000);
            Wage w6 = new Wage(109000);

            p1.Wage.Add(w1);
            p2.Wage.Add(w2);
            p3.Wage.Add(w3);
            p4.Wage.Add(w4);
            p5.Wage.Add(w5);
            p6.Wage.Add(w6);

            height h2 = new height("5'9");
            height h3 = new height("5'10");
            height h4 = new height("5'11");
            height h6 = new height("6'3");

            p1.Height.Add(h2);
            p2.Height.Add(h2);
            p3.Height.Add(h3);
            p4.Height.Add(h4);
            p5.Height.Add(h4);
            p6.Height.Add(h6);

        }

        private void lbNames_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            players selectedBand = lbNames.SelectedItem as players;


            //make sure it's not null
            if (selectedBand != null)
            {
                pName.ItemsSource = selectedBand.Born;
                pClub.ItemsSource = selectedBand.Club;
                pPostion.ItemsSource = selectedBand.Postions;
                pWage.ItemsSource = selectedBand.Wage;
                pHeight.ItemsSource = selectedBand.Height;
               
            }
        }
    }
}        
           