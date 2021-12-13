using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Text;

using MySql.Data.MySqlClient;

namespace Sklad
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           


            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            MySqlConnectionStringBuilder db;
            db = new MySqlConnectionStringBuilder();
            db.Server = "localhost"; // ������� ��
            db.Database = "sklad"; // ��� ��
            db.UserID = "root"; // ��� ������������ ��
                                // db.Password = "ca8484adc89a"; // ������ ������������ ��
            db.CharacterSet = "utf8"; // ��������� ���� ������
            try
            {
                SQLClass.conn = new MySqlConnection(db.ConnectionString);
                SQLClass.conn.Open();
            Application.Run(new Form1());
            SQLClass.conn.Close();
            }
            catch
            {
                MessageBox.Show("������ � ����������� ��");
            }
             
        }
    }
}
