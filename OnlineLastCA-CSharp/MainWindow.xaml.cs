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

namespace OnlineLastCA_CSharp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        NewEPLDataBaseEntities db = new NewEPLDataBaseEntities();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from t in db.TeamTBLs
                        select t.TeamName;

            ListTeams.ItemsSource = query.ToList();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string company = (string)ListTeams.SelectedItem;

            var query = (from details in db.StatsTBLs
                         where details.TeamTBL.TeamName == company
                         select details.Manager);
            TBMarnager.Text = string.Format("{0}", string.Join(",", query));

            var query1 = (from details in db.StatsTBLs
                         where details.TeamTBL.TeamName == company
                         select details.TopForward);
            TopForward.Text = string.Format("{0}", string.Join(",", query1));

            var query2 = (from details in db.StatsTBLs
                          where details.TeamTBL.TeamName == company
                          select details.TopMid);
            TopMid.Text = string.Format("{0}", string.Join(",", query2));

            var query3 = (from details in db.StatsTBLs
                          where details.TeamTBL.TeamName == company
                          select details.TopDefender);
            TopDefender.Text = string.Format("{0}", string.Join(",", query3));

            var query4 = (from details in db.StatsTBLs
                          where details.TeamTBL.TeamName == company
                          select details.TopGk);
            TopGK.Text = string.Format("{0}", string.Join(",", query4));
        }

        private void forwardbutton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 win = new Window1();
            win.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
