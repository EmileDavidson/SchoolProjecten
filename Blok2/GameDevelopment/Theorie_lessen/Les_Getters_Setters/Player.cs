using System;

namespace Les_Getters_Setters
{
    class Player
    {
        private string _name = "Mario";

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }


        private int _lives = 10;

        public int lives
        {
            get
            {
                return _lives;
            }
            set
            {
                if (value > _livesMaximum) { value = livesMaximum; }
                else if (value < 0) { value = 0; }

                _lives = value;
            }
        }

        public bool isDead
        {
            get
            {
                if (_lives <= 0)
                {
                    return true;
                }
                return false;
            }
        }


        public int _livesMaximum = 99;
        public int livesMaximum
        {
            get
            {
                return _livesMaximum;
            }
        }

        private int _points = 0;
        public int points
        {
            get
            {
                return _points;
            }
            set
            {
                if (value >= 100)
                {
                    lives += 1;
                    value %= 100;
                }
                else if (value <= 0)
                {
                    value = 0;
                }
                _points = value;
            }
        }
    }
}