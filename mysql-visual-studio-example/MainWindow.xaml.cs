using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows;

namespace mysql_visual_studio_example {
    public partial class MainWindow : Window {
        private string connectionString = "server=127.0.0.1; user=YourUsername; password=YourPassword; database=YourDatabase; port=3306";

        public MainWindow() {
            InitializeComponent();
        }

        private void testConnectionButton_Click(object sender, RoutedEventArgs e) {
            MySqlConnection conn = null;
            MySqlCommand command = null;
            MySqlDataReader reader = null;
            
            try {
                conn = new MySqlConnection(connectionString);
                conn.Open();

                command = new MySqlCommand("SELECT * FROM `tableNameGoesHere`", conn);
                /*
                 * If you have to set parameters of a query, the proper way is to do the following:
                 * command = new MySqlCommand("SELECT * FROM `users` WHERE `username` = @username", conn);
                 * command.Parameters.AddWithValue("username", "joesmith");
                 * 
                 * Using Parameters.AddWithValue prevents SQL Injection attacks, so it is good to
                 * get in the habbit of using this approach instead of concatenating directly
                 * into your queries.
                */
                reader = command.ExecuteReader();
                /*
                 * If you are issuing an UPDATE or INSERT command, use:
                 * command.ExecuteNonQuery();
                 * instead of command.ExecuteReader(). ExecuteNonQuery() does not return anything,
                 * so you don't even have to use a MySqlDataReader.
                 */
                while (reader.Read()) {
                    /*
                     * Here, you can iterate through the rows that were returned. To get the first 
                     * value in the the current row, use reader.GetValue(0).ToString(). If it's 
                     * a number, use Convert.ToInt32(reader.GetValue(0)), or whatever other
                     * conversion corresponds to your data type.
                     * To get the 3rd value in the current row, use GetValue(2), and so forth.
                     */
                }

                // We made it to the end of our query without catching an exception!
                resultsLabel.Content = "Result: Success!"; 
            } catch (Exception ex) {
                // Handle errors here.
                resultsLabel.Content = "Result: Failure";
            } finally {
                // We must assure the connection gets closed, even in the event of an exception.
                if (conn != null && conn.State != ConnectionState.Closed) {
                    conn.Close();
                }
            }
        }
    }
}
