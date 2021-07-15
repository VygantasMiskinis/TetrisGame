using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Tetris
{
    class mySqlFunctions
    {
        static public string vardas;
        static private MySqlConnection connection = new MySqlConnection("SERVER=sql11.freemysqlhosting.net;PORT=3306;DATABASE=sql11170131;UID=sql11170131;PWD=m13MhqkmBX");
        static public void saveGameData(string _playerName, int _score)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                    connection.Open();
                string date = DateTime.Now.ToString();
                string saveData = "INSERT INTO tetrisScores(playerName,gameScore) VALUES(@playerName,@gameScore)";
                MySqlCommand cmd = new MySqlCommand(saveData, connection);
                cmd.Parameters.AddWithValue("@playerName", _playerName);
                cmd.Parameters.AddWithValue("@gameScore", _score);
                cmd.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                MessageBox.Show(string.Format("Error: {0}", exception));
            }
            finally
            {
                connection.Close();
            }
        }
        static public void refreshData(DataGridView dataGridView)
        {
            {
                try
                {
                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    string refreshData = "SELECT Spot,playerName,gameScore FROM tetrisScores ORDER BY gameScore DESC LIMIT 10";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(refreshData, connection);
                    
                    DataTable datatable = new DataTable();

                    adapter.Fill(datatable);
                   

                    dataGridView.DataSource = datatable;
                    
                    for (int i=0;i<dataGridView.Rows.Count;i++)
                    {
                        dataGridView.Rows[i].Cells[0].Value = string.Format("{0}.",i+1);

                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(string.Format("Error: {0}", exception));
                }
                finally
                {
                    connection.Close();
                }
            }
        }  
    }
}
