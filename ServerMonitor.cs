using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Xml;

namespace Server_Monitor
{
    public class ServerMonitor
    {
        public static string host = string.Empty;
        public static string user = string.Empty;
        public static string password = string.Empty;
        public static string database = string.Empty;
        public static string processName = string.Empty;

        public static string table = string.Empty;
        public static string col = string.Empty;

        public static string connectionString = string.Empty;

        private static bool serverstatus { get; set; }

        private static Process server;

        
        public static void CreateConnectionString(string host, string user, string password, string database)
        {
            connectionString = $"SERVER={host}; DATABASE={database}; UID={user}; PASSWORD={password}; SSLMODE=none;";
        }

        public static void UpdateDatabaseServerStatus()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    MySqlCommand command = connection.CreateCommand();

                    command.CommandText = "UPDATE `"+table+"` SET `"+col+"` = @col1";
                    command.Parameters.AddWithValue("@col1", serverstatus);

                    command.ExecuteNonQuery();
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
        
        public static bool IsProcessRunning()
        {
            Process[] proc = Process.GetProcessesByName(processName);
            if (proc.Length > 0)
            {
                serverstatus = true;
            }
            else
            {
                serverstatus = false;
            }
            return serverstatus;
        }


        public static void StartServer()
        {
            if (processName == string.Empty)
            {
                throw new Exception("Bitte einen Prozessnamen eingeben!");
            }
            try
            {
                using (server = new Process())
                {
                    server.StartInfo.UseShellExecute = true;
                    // You can start any process, HelloWorld is a do-nothing example.
                    server.StartInfo.FileName = "C:\\Users\\Administrator\\Desktop\\GTA\\" + processName + ".exe";
                    server.StartInfo.CreateNoWindow = false;
                    server.Start();
                    // This code assumes the process you are starting will terminate itself. 
                    // Given that is is started without a window so you cannot terminate it 
                    // on the desktop, it must terminate itself or you can do it programmatically
                    // from this application using the Kill method.
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public static void StopServer()
        {
            if (IsProcessRunning())
            {
                //Alle Prozesse mit dem Namen in Array Speichern
                Process[] proc = Process.GetProcessesByName(processName);
                foreach (Process p in proc)
                {
                    //Alle Prozesse mit dem Namen schließen
                    p.Close();
                }
            }
        }
    }
}
