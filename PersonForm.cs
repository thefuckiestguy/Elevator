using ElevatorAppForm;
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

    public partial class PersonForm : Form
    {
        private List<Person> people;
        private static int counter = 1;
        private int id = 0;
        public static event EventHandler<PersonEventArgs> PersonCreated;

        public int GenerateUniqueID()
        {
            return counter++;
        }
        public PersonForm(List<Person> people)
        {
            this.people = people;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Weight_Click(object sender, EventArgs e)
        {

        }

        private void PersonForm_Load(object sender, EventArgs e)
        {

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void WeightBox_TextChanged(object sender, EventArgs e)
        {

        }

        //public bool isPersonExist()
        //{
        //    DB db = new DB();

        //    DataTable table = new DataTable();

        //    MySqlDataAdapter adapter = new MySqlDataAdapter();

        //    MySqlCommand command = new MySqlCommand("SELECT * FROM `system` WHERE `login`=@UsL", db.getConnection());
        /// <summary>
        //   command.Parameters.Add("@UsL", MySqlDbType.VarChar).Value = loginFieldR.Text;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        //    adapter.SelectCommand = command;
        //    adapter.Fill(table);

        //    if (table.Rows.Count > 0)
        //    {
        //        MessageBox.Show("login use");
        //        return true;
        //    }
        //    else
        //        return false;

        //}

        private void Create_Click(object sender, EventArgs e)
        {
            id = GenerateUniqueID();

            if (NameBox.Text == "")
            {
                MessageBox.Show("fill in the field!");
                return;
            }
            if (WeightBox.Text == "" || !(int.TryParse(WeightBox.Text, out int res)))
            {
                MessageBox.Show("fill in the field!");
                return;
            }
            if (FloorBox.Text == "" || !(int.TryParse(FloorBox.Text, out int res2)))
            {
                MessageBox.Show("fill in the field!");
                return;
            }

            if (int.Parse(FloorBox.Text) < 1 || int.Parse(FloorBox.Text) > Lift.FloorsNumber)
            {
                MessageBox.Show("Введите корректный этаж");
                return;
            }

            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `people` (`id`, `name`, `currentfloor`, `weight`) VALUES (@id, @name, @currentfloor, @weight)", db.getConnection());

            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameBox.Text;
            command.Parameters.Add("@currentfloor", MySqlDbType.VarChar).Value = FloorBox.Text;
            command.Parameters.Add("@weight", MySqlDbType.VarChar).Value = WeightBox.Text;

            db.openConnection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Success!!!");
            else
                MessageBox.Show("Error");

            db.closeConnection();

            string name = NameBox.Text;
            int currentLevel = int.Parse(FloorBox.Text);
            int weight = int.Parse(WeightBox.Text);

            Person person = new Person(id, name, currentLevel, weight);

            people.Add(person);
            OnPersonCreated(new PersonEventArgs(person));
        }

        public void DeleteFromDatabase()
        {

            DB db = new DB();
            db.openConnection();

            MySqlCommand command = new MySqlCommand("DELETE FROM `people` WHERE `id`=@id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = this.id;

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Person deleted from the database!");
            else
                MessageBox.Show("Error deleting person from the database!");
            db.closeConnection();

        }
        public virtual void OnPersonCreated(PersonEventArgs e)
        {
            PersonCreated?.Invoke(this, e);
        }

        private void FloorBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
