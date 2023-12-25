using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatorAppForm
{
    public enum Direction
    {
        Up,
        Down,
        None
    }
    public class Elevator
    {
        public event EventHandler<int> LevelChanged;

        static private int currentLevel = 1;
        private Direction direction;
        private bool doorsOpen;
        private bool overloaded;
        static private uint capacity = 400;
        private int floorsNumber;


         public enum States
    {
        EmptyWaiting,
        EmptyClimbing,
        OpenDoorsWaiting
    }

    public event EventHandler<States> StateChanged;
    public int Level { get; private set; }
    public States State { get; private set; }

    public Elevator()
    {
        Level = 1;
    }

        public int CurrentLevel
        {
            get { return currentLevel; }
        }

        public Direction Direction
        {
            get { return direction; }
        }

        public bool Overloaded
        {
            get { return overloaded; }
        }

        public Elevator(int floorsNumber)
        {
            currentLevel = 1;
            direction = Direction.None;
           
            this.floorsNumber = floorsNumber;
        }
    }

}
