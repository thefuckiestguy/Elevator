using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorAppForm
{
    public partial class Lift : Form
    {
        private static List<Person> people;

        private Dictionary<int, Image> floorImages; // Ваши изображения этажей

        private bool isLiftOpen = false;

        private bool liftWasEmpty = true;

        private Dictionary<int, Image> moveFloorImages;
        private void InitializeMoveFloorImages()
        {
            moveFloorImages = new Dictionary<int, Image>();

            string moveDirectoryPath = @"D:\c#\ElevatorAppForm\ElevatorAppForm\MoveFloors";

            for (int i = 1; i <= 5; i++)
            {
                string imageName = $"fl{i}.png";
                Image moveFloorImage = LoadImageFromPath(moveDirectoryPath, imageName);
                moveFloorImages.Add(i, moveFloorImage);
            }

            // Присваиваем изображение первого этажа по умолчанию
            //CurrentFloor.Image = moveFloorImages[1];
        }

        private int currentWeight = 0;

        private bool isEmpty = true;

        private int counterPeople = 0;

        private int counterWeight = 0;

        private int counterTrips = 0;

        private int counterEmptyTrips = 0;

        private int totalCalls = 0;

        int directionPrevious = 0;

        public static int FloorsNumber { get; set; }
            

        private void LoadElevatorStateImage()
        {
            string stateImagePath = isLiftOpen ? @"D:\c#\ElevatorAppForm\ElevatorAppForm\ElevatorStates\open.png" : @"D:\c#\ElevatorAppForm\ElevatorAppForm\ElevatorStates\closed.png";

            try
            {
                using (FileStream stream = new FileStream(stateImagePath, FileMode.Open, FileAccess.Read))
                {
                    LiftPicture.Image = Image.FromStream(stream); // Замените YourStateImageControl на ваш элемент управления изображением
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при загрузке изображения состояния лифта: {ex.Message}");
            }
        }

        // В конструкторе Lift или другом подходящем месте инициализируйте floorImages

        private int currentLevel;
        private int moveFloor;

        public int CurrentLevel
        {
            get { return currentLevel; }
            set
            {
                currentLevel = value;
            }
        }

        private Image LoadImageFromPath(string directoryPath, string fileName)
        {
            string fullPath = Path.Combine(directoryPath, fileName);

            if (File.Exists(fullPath))
            {
                try
                {
                    using (FileStream stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        return Image.FromStream(stream);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при загрузке изображения: {ex.Message}");
                    return null; // или другое изображение по умолчанию
                }
            }
            else
            {
                MessageBox.Show($"Файл не найден: {fullPath}");
                return null; // или другое изображение по умолчанию
            }
        }

        private Image LoadImageFromPath(string fileName)
        {
            string directoryPath = @"D:\c#\ElevatorAppForm\ElevatorAppForm\Floors";
            string fullPath = Path.Combine(directoryPath, fileName);

            if (File.Exists(fullPath))
            {
                try
                {
                    using (FileStream stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read))
                    {
                        return Image.FromStream(stream);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при загрузке изображения: {ex.Message}");
                    return null; // или другое изображение по умолчанию
                }
            }
            else
            {
                MessageBox.Show($"Файл не найден: {fullPath}");
                return null; // или другое изображение по умолчанию
            }
        }

        private void InitializeFloorImages()
        {
            floorImages = new Dictionary<int, Image>();

            for (int i = 1; i <= 5; i++)
            {
                string imageName = $"Floor{i}.png";
                Image floorImage = LoadImageFromPath(imageName);
                floorImages.Add(i, floorImage);
            }

            //CurrentLiftFloor.Image = floorImages[1];
            CurrentLevel = 1;
            moveFloor = CurrentLevel;
            BuildingFloor.Text = CurrentLevel.ToString();
            ElevatorLevel.Text = CurrentLevel.ToString();
        }

        public Lift(int floorsNumber)
        {
            FloorsNumber = floorsNumber;

            InitializeComponent();
            InitializeFloorImages();
            InitializeMoveFloorImages();
            currentLiftWeight.AppendText(currentWeight.ToString());
            countTrips.Text = counterTrips.ToString();
            countEmptyTrips.Text = counterEmptyTrips.ToString();

            Floors.Items.Clear();
            TargetFloor.Items.Clear();  

            for (int i = 1; i <= floorsNumber;i++) 
            {
                Floors.Items.Add(i);
                TargetFloor.Items.Add(i);
            }

        }

        private async Task ChangeMoveFloorImage(int targetFloor)
        {
            if (targetFloor < 1 || targetFloor > FloorsNumber)
            {
                MessageBox.Show("Выберите корректный этаж.");
                return;
            }

            int current = moveFloor;
            bool hasDirectionChanged = false; // Флаг для отслеживания изменения направления
            bool isFirstCall = (totalCalls == 0); // Проверка первого вызова


            int directionNow = Math.Sign(targetFloor - current); // Определение направления до входа в цикл

            if (directionNow < 0)
            {
                Down.BackColor = Color.Red;
            }
            else
            {
                Up.BackColor = Color.Red;
            }

            while (current != targetFloor)
            {
                await Task.Delay(1000); // Интервал в 1 секунду

                directionNow = Math.Sign(targetFloor - current);

                current += directionNow;

                    //CurrentFloor.Image = moveFloorImage;
                    ElevatorLevel.Text = current.ToString();
                
           

                // Проверяем, если лифт находится в ожидании нового вызова
                if (isFirstCall)
                {
                    directionPrevious = directionNow; // Первый вызов - устанавливаем направление
                    isFirstCall = false;
                    totalCalls++;
                    continue; // Пропускаем проверки при первой поездке
                }

                // Проверяем, изменилось ли направление движения
                if (directionNow != directionPrevious)
                {
                    hasDirectionChanged = true;
                    directionPrevious = directionNow; // Обновляем предыдущее направление
                    counterTrips++;
                    countTrips.Text = counterTrips.ToString();
                    if (liftWasEmpty && hasDirectionChanged)
                    {
                        counterEmptyTrips++;
                        countEmptyTrips.Text = counterEmptyTrips.ToString();
                    }
                }
            }

            CurrentLevel = current;
            moveFloor = current;
            Up.BackColor = Color.PowderBlue;
            Down.BackColor = Color.PowderBlue;

            // Увеличиваем общее количество вызовов
            totalCalls++;
        }





        private void InitializePerson()
        {
            people = new List<Person>();
        }
        private void Lift_Load(object sender, EventArgs e)
        {
            PersonForm.PersonCreated += PersonForm_PersonCreated;
        }



        private async void Call_Click(object sender, EventArgs e)
        {
            isLiftOpen = false;
            LoadElevatorStateImage();

            if (isEmpty)
            {
                EmptyLift.ForeColor = Color.Red;
            }


            Button clickedButton = sender as Button;

            if (clickedButton != null)
            {
                clickedButton.ForeColor = Color.Red;
            }

            if (People.SelectedItem != null)
            {
                int selectedPersonID = int.Parse(People.SelectedItem.ToString().Split(' ')[0]);
                Person selectedPerson = people.Find(person => person.GetID() == selectedPersonID);

                if (selectedPerson.GetCurrentLevel() == CurrentLevel)
                {
                    MessageBox.Show($"{selectedPerson.GetName()} нажал кнопку вызова на этаже {CurrentLevel}");

                    if (selectedPerson.GetCurrentLevel() == moveFloor)
                    {
                        isLiftOpen = true;
                        totalCalls++;
                        counterTrips--;
                        //counterEmptyTrips--;
                        liftWasEmpty = false;
                        LoadElevatorStateImage();
                    }
                    else if(selectedPerson.GetCurrentLevel() != moveFloor && !isEmpty)
                    {
                       
                        await ChangeMoveFloorImage(CurrentLevel);

                        isLiftOpen = true;
                        LoadElevatorStateImage();
                    }
                    else if (selectedPerson.GetCurrentLevel() != moveFloor && isEmpty)
                    {
                        liftWasEmpty = true;
                        await ChangeMoveFloorImage(CurrentLevel);

                        isLiftOpen = true;
                        LoadElevatorStateImage();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Выбранный человек находится не на текущем этаже лифта.");
                }
            }
            else
            {
                MessageBox.Show("Выберите человека из списка.");
            }

            clickedButton.ForeColor = Color.Black;
        }


        private async void Enter_Click(object sender, EventArgs e)
        {
            int countItems = People.Items.Count;
            int count = 0;
            if (isLiftOpen)
            {
                if (People.SelectedItem != null && int.TryParse(People.SelectedItem.ToString().ToCharArray()[0].ToString(), out int selectedPersonIndex))
                {
                    int selectedPersonID = int.Parse(People.SelectedItem.ToString().Split(' ')[0]);

                    // Поиск человека в списке people по ID
                    Person selectedPerson = people.Find(person => person.GetID() == selectedPersonID);

                    // Проверка этажа человека и этажа лифта
                    if (selectedPerson.GetCurrentLevel() == CurrentLevel)
                    {
                        // Проверка на максимальную массу в лифте
                        if (currentWeight + selectedPerson.GetWeight() <= 400)
                        {
                            // Обновление данных в системе
                            UpdateSystem(selectedPerson);

                            // Обновление информации в лифте
                            UpdateElevator(selectedPerson);

                            EmptyLift.ForeColor = Color.Black;

                            count++;

                            MessageBox.Show(selectedPerson.GetName() + " вошёл в лифт");

                            isEmpty = false;

                            if (totalCalls > 2)
                                liftWasEmpty = false;

                            await Task.Delay(3000);
                            if (count == countItems)
                            {
                                isLiftOpen = false;
                                People.Items.Clear();
                                LoadElevatorStateImage();
                            }
                        }
                        else
                        {
                            Warning.ForeColor = Color.Red;
                            MessageBox.Show("Максимальная масса в лифте достигнута. Человек не может войти.");

                            await Task.Delay(1000);
                            Warning.ForeColor = Color.Black;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Человек находится не на текущем этаже лифта.");
                    }
                }
                else
                {
                    MessageBox.Show("Выберите человека для входа в лифт.");
                }
            }
            else
            {
                MessageBox.Show("Лифт закрыт. Нельзя войти.");
            }
        }

        private void UpdateSystem(Person selectedPerson)
        {
            string text = selectedPerson.GetID().ToString() + " " +
                          selectedPerson.GetName() + " " +
                          selectedPerson.GetCurrentLevel().ToString() + " " +
                          selectedPerson.GetWeight().ToString();

            // Преобразуйте объект Person в строку и проверьте наличие этой строки
            string selectedPersonString = selectedPerson.GetID().ToString(); // Здесь используйте нужные вам данные объекта Person
            if (People.Items.Cast<string>().Any(item => item.StartsWith(selectedPersonString)))
            {
                People.Items.Remove(text);
                PeopleInLift.Items.Add(text);
            }

        }

        private void UpdateElevator(Person selectedPerson)
        {
            currentWeight += selectedPerson.GetWeight();
            currentLiftWeight.Text = currentWeight.ToString();
            counterWeight += selectedPerson.GetWeight();
            // Обновите данные в интерфейсе лифта, например, обновите список людей
        }

        private async void GoOut_Click(object sender, EventArgs e)
        {
            int countItems = PeopleInLift.Items.Count;
            //int countPeople = 0;

            if (isLiftOpen)
            {

                if (PeopleInLift.SelectedItem != null && int.TryParse(PeopleInLift.SelectedItem.ToString().ToCharArray()[0].ToString(), out int selectedPersonIndex))
                {
                    int selectedPersonID = int.Parse(PeopleInLift.SelectedItem.ToString().Split(' ')[0]);

                    // Поиск человека в списке people по ID
                    Person selectedPerson = people.Find(person => person.GetID() == selectedPersonID);

                    string text = selectedPerson.GetID().ToString() + " " +
                       selectedPerson.GetName() + " " +
                       selectedPerson.GetCurrentLevel().ToString() + " " +
                       selectedPerson.GetWeight().ToString();

                    currentWeight -= selectedPerson.GetWeight();

                    currentLiftWeight.Text = currentWeight.ToString();

                    if (currentWeight == 0)
                    {
                        liftWasEmpty = true;
                        EmptyLift.ForeColor = Color.Red;
                    }

                    // Удаление из списка людей и ComboBox PeopleInLift

                    countItems--;
                    counterPeople++;

                    CountPeopleLift.Text = counterPeople.ToString();


                    people.Remove(selectedPerson);
                    PeopleInLift.Items.Remove(text);

                    // Удаление из базы данных (пример)

                    MessageBox.Show(selectedPerson.GetName() + "вышел из лифта");
                    DeletePersonFromDatabase(selectedPerson.GetID());

                    await Task.Delay(3000);

                    if (countItems == 0)
                    {
                        PeopleInLift.Items.Clear();
                        isLiftOpen = false;
                        LoadElevatorStateImage();
                    }
                    // Дополнительные действия, если необходимо
                }
                else
                {
                    MessageBox.Show("Выберите человека для выхода из лифта.");
                }
            }
            else
            {
                MessageBox.Show("Лифт закрыт или в пути");
                return;
            }
        }

        // Пример метода удаления из базы данных
        private void DeletePersonFromDatabase(int personID)
        {
            //Ваш код для удаления данных из базы данных
            // Пример:
            DB db = new DB();
            MySqlCommand command = new MySqlCommand("DELETE FROM `people` WHERE `id`=@id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = personID;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show("Deleted!");
            else
                MessageBox.Show("Error");
            db.closeConnection();
        }

        public bool isUserExist1()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `system` WHERE `id`=@id", db.getConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = people.ToArray()[1];


            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                return false;
            }
            else
                MessageBox.Show("human not found");
            return true;

        }

        private void PersonForm_PersonCreated(object sender, PersonEventArgs e)
        {
            // Получить созданный экземпляр Person
            Person newPerson = e.CreatedPerson;
            string text = newPerson.GetID().ToString() + " " + newPerson.GetName() + " " + newPerson.GetCurrentLevel().ToString() + " " + newPerson.GetWeight().ToString();
            People.Items.Add(text);
            // Ваш код для обработки созданного Person
        }
        private void CreatePerson_Click(object sender, EventArgs e)
        {
            InitializePerson();
            PersonForm personForm = new PersonForm(people);
            personForm.Show();
        }

        private async void GoTargetFloor_Click(object sender, EventArgs e)
        {
            isLiftOpen = false;
            LoadElevatorStateImage();

            if (this.isEmpty)
            {
                MessageBox.Show("Лифт пустой!");
                return;
            }
            else
            {

                Button clickedButton = sender as Button;

                if (clickedButton != null)
                {
                    clickedButton.ForeColor = Color.Red;
                }

                if (TargetFloor.SelectedItem != null && int.TryParse(TargetFloor.SelectedItem.ToString(), out int selectedFloor))
                {
                    string text = "";
                    foreach (var item in PeopleInLift.Items)
                    {
                        text += item.ToString() + " ";
                    }
                    MessageBox.Show(text + "едет(ут на " + TargetFloor.SelectedItem + "этаж");

                    await ChangeMoveFloorImage(selectedFloor);

                    MessageBox.Show(text + "доставлен(ы) на " + TargetFloor.SelectedItem + "этаж");
                    // Вызовется по завершении ChangeMoveFloorImage

                    isLiftOpen = true;
                    LoadElevatorStateImage();

                    clickedButton.ForeColor = Color.Black;
                }
                else
                {
                    MessageBox.Show("Выберите корректный этаж.");
                }
            }
        }


        private void TargetFloor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Exit_Click(object sender, EventArgs e)
        {

            this.Hide();
            StartMenu startMenu = new StartMenu();
            startMenu.Show();
        }

        private void Floors_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CurrentLiftFloor_Click(object sender, EventArgs e)
        {

        }

        private void Ok_Click(object sender, EventArgs e)
        {
            try
            {
                int.TryParse(Floors.SelectedItem.ToString(), out int selectedFloor);

                ChangeFloorImage(selectedFloor);
                BuildingFloor.Text = selectedFloor.ToString();
                CurrentLevel = selectedFloor;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Выберите корректный этаж. + {ex.Message}");
            }
        }

        private void ChangeFloorImage(int targetFloor)
        {
            CurrentLevel = targetFloor;
        }

        private void CurrentFloor_Click(object sender, EventArgs e)
        {

        }

        private void People_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PeopleInLift_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChooseLevel_Click(object sender, EventArgs e)
        {

        }

        private void currentLiftWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void burden_Click(object sender, EventArgs e)
        {

        }

        private void countTrips_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lift_Click(object sender, EventArgs e)
        {

        }

        private void CountPeopleLift_TextChanged(object sender, EventArgs e)
        {

        }

        private void ElevatorLevel_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmptyLift_Click(object sender, EventArgs e)
        {

        }
    }
}
