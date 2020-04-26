using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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


namespace WpfProject_Part1
{
    public partial class RegScreen : Window
    {
        public RegScreen()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
       {
            using (SqlConnection connection = new SqlConnection(@"Data Source =HOME-PC\SQLEXPRESS; Initial Catalog=WPFprojectDB; Integrated Security=True;"))
            {
                 String login = txtUsername.Text;
                 String password = txtPassword.Password;
                 String lastName = txtLastName.Text;
                 String firstName = txtFirstName.Text;
                 String email = txtEmail.Text;



                using (SqlCommand command = new SqlCommand("INSERT INTO tdb(UserID, UserName, Password, Lastname, Firstname, Email) VALUES(@UserID, @UserName, @Password, @Lastname, @Firstname, @Email)", connection))
                {
                    command.Parameters.AddWithValue("@UserID", "1" );
                    command.Parameters.AddWithValue("@UserName", login);
                    command.Parameters.AddWithValue("@Password", password);
                    command.Parameters.AddWithValue("@Lastname", lastName);
                    command.Parameters.AddWithValue("@Firstname", firstName);
                    command.Parameters.AddWithValue("@Email", email);


                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
    }

