// Include namespace system
using System;

namespace Mars.Rover.SpecFlowTest.Helper
{
    public class Rover
    {
        public const int N = 1;
        public const int E = 2;
        public const int S = 3;
        public const int W = 4;
        public int x = 0;
        public int y = 0;
        public int facing = N;
        
        public void setPosition(int x, int y, int facing)
        {
            this.x = x;
            this.y = y;
            this.facing = facing;
        }

        public string printPosition()
        {
            string position = string.Empty;
            var dir = 'N';
            if (this.facing == 1)
            {
                dir = 'N';
            }
            else if (this.facing == 2)
            {
                dir = 'E';
            }
            else if (this.facing == 3)
            {
                dir = 'S';
            }
            else if (this.facing == 4)
            {
                dir = 'W';
            }
            position = string.Join(", ", this.x) + " " + string.Join(", ", this.y) + " " + dir.ToString();
            return position;
            //Console.WriteLine(string.Join(", ", this.x) + " " + string.Join(", ", this.y) + " " + dir.ToString());
            //Console.ReadLine();
        }
        public void process(string commands)
        {
            for (int idx = 0; idx < commands.Length; idx++)
            {
                this.process(commands[idx]);
            }
        }
        private void process(char command)
        {
            if (command.Equals('L'))
            {
                this.turnLeft();
            }
            else if (command.Equals('R'))
            {
                this.turnRight();
            }
            else if (command.Equals('M'))
            {
                this.move();
            }
            else
            {
                throw new Exception("Speak in Mars language, please!");
            }
        }
        private void move()
        {
            if (this.facing == N)
            {
                this.y++;
            }
            else if (this.facing == E)
            {
                this.x++;
            }
            else if (this.facing == S)
            {
                this.y--;
            }
            else if (this.facing == W)
            {
                this.x--;
            }
        }
        private void turnLeft()
        {
            this.facing = (this.facing - 1) < N ? W : this.facing - 1;

        }
        private void turnRight()
        {
            this.facing = (this.facing + 1) > W ? N : this.facing + 1;
        }

    }
}