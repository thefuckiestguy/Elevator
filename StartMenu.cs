using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorAppForm
{
    public partial class StartMenu : Form
    {
        private bool systemStopped = false;
        Random rand;
        private List<Elevator> elevators;
       
        public StartMenu()
        {
            InitializeComponent();
            //InitializeElevator(int.Parse(AmountFloors.Text));
            //rand = new Random();
        }
     
        private void InitializeElevator(int floorsNumber)
        {
            elevators = new List<Elevator>();
            Elevator elevator = new Elevator(floorsNumber);
            elevators.Add(elevator);
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {

        }

        private void CreateSession_Click(object sender, EventArgs e)
        {
            if (AmountFloors.Text == "" && !(int.TryParse(AmountFloors.Text, out int amount)))
            {
                
                MessageBox.Show("fill in the field!");
                return;
            }

            if(int.Parse(AmountFloors.Text) <= 0)
            {
                MessageBox.Show("fill correct value in the field!");
                return;
            }
            Lift lift = new Lift(int.Parse(AmountFloors.Text));
            this.Hide();
            lift.Show();
        }

        private void StopSystem_Click(object sender, EventArgs e)
        {
            DB db = new DB();

            db.openConnection();

            MySqlCommand command = new MySqlCommand("DELETE FROM `people`", db.getConnection());

            if (command.ExecuteNonQuery() >= 1)
                MessageBox.Show("All persons deleted from the database!");
            else
                MessageBox.Show("No persons found in the database!");

            
            db.closeConnection();
            MessageBox.Show("Система остановлена");
            systemStopped = true;
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            if (systemStopped)
            {
                this.Hide();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Please stop the system before exiting.");
            }
        }

        private void AmountFloors_Click(object sender, EventArgs e)
        {

        }
    }
}