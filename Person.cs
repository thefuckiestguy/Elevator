using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElevatorAppForm
{
    public class Person
    {
        
        private int id;
        public event EventHandler WaitingForElevator;
        public event EventHandler InElevator;
        public event EventHandler ArrivedAtDestination;


        private string name { get; }
        private int currentLevel { get;  }
        private int destinationLevel;
        private int weight { get; }

        public int GetID()
        {
            return this.id;
        }

        public string GetName()
        {
            return this.name;
        }

        public int GetCurrentLevel()
        {
            return this.currentLevel;
        }
        public int GetWeight()
        {
            return this.weight;
        }

        public int CurrentLevel
        {
            get { return currentLevel; }
        }

    
        public int DestinationLevel
        {
            get { return destinationLevel; }
        }

        public Person(int id, string name, int currentLevel, int weight)
        {
          

            this.id = id;
          this.name = name;
          this.weight = weight;
          this.currentLevel = currentLevel;

        }

        //public async void CallElevator(Elevator elevator)
        //{
        //    OnWaitingForElevator();

        //    // Имитация ожидания лифта
        //    await Task.Delay(3000);

        //    if (elevator.Overloaded)
        //    {
        //        // Лифт перегружен, не могу вызвать
        //        return;
        //    }

        //    // Перемещение к вызванному лифту
        //    while (currentLevel != elevator.CurrentLevel)
        //    {
        //        await Task.Delay(1000);
        //        currentLevel += (currentLevel < elevator.CurrentLevel) ? 1 : -1;
        //    }

        //    // Вход в лифт
        //    OnInElevator();

        //    // Вызов лифта на нужный этаж
        //    await elevator.GoTo(destinationLevel);

        //    // Выход из лифта
        //    OnArrivedAtDestination();
        //}

        protected virtual void OnWaitingForElevator()
        {
            WaitingForElevator?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnInElevator()
        {
            InElevator?.Invoke(this, EventArgs.Empty);
        }

        protected virtual void OnArrivedAtDestination()
        {
            ArrivedAtDestination?.Invoke(this, EventArgs.Empty);
        }
    }
}
