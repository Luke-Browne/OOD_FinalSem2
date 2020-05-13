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
using System.Data.SqlClient;

namespace LukeBrowne_S00187306
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    // connects to the local db
    string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Owner\Desktop\College Work\OOD\LukeBrowne_S00187306\phoneDetails.mdf;Integrated Security=True;Connect Timeout=30";

    public List<Phone> phones = new List<Phone>();

    public BrushConverter bc = new BrushConverter(); // used for images 

    public MainWindow()
    {
      InitializeComponent();
    }

    private void Window_Loaded(object sender, RoutedEventArgs e)
    {
      lbxPhones.SelectedIndex = 0;

      using (SqlConnection sqlCon = new SqlConnection(connectionString))
      {
        string query = "SELECT * FROM details ORDER BY Id"; // queries the db

        sqlCon.Open();

        SqlCommand sqlCmd = new SqlCommand(query, sqlCon);

        SqlDataReader dr = sqlCmd.ExecuteReader();

        if(dr.HasRows)
        {
          while (dr.Read())
          {
            Phone newPhone = new Phone(dr[1].ToString(), Convert.ToDecimal(dr[2]), dr[3].ToString(), dr[4].ToString(), dr[5].ToString()); // fills the constrcutor requirements

            phones.Add(newPhone); // add the phone
          }
          if(phones != null)
          {
            var results = phones.Select(x => x.Name);

            lbxPhones.ItemsSource = results; // lists the names
          }
        }
        sqlCon.Close();
      }
    }

    private void LbxPhones_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
      string selectedPhone = lbxPhones.SelectedItem.ToString();

      if (selectedPhone != null)
      {
        var price = from p in phones
                    where selectedPhone == p.Name
                    select p.Price.ToString();

        foreach (string p in price)
        {
          textPrice.Text = $"€{p:C2}"; // displays price
        }

        var image = from p in phones
                    where selectedPhone == p.Name
                    select p.Phone_Image.ToString();

        foreach (string i in image)
        {
          phoneImg.Source = new BitmapImage(new Uri($@"C:\Users\Owner\Desktop\College Work\OOD\LukeBrowne_S00187306\images\{i}", UriKind.Absolute));
        }
      }
    }
  }
}
