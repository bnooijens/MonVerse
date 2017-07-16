using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonVerse
{
    class Monster
    {
        private string _name;
        private int    _hp;
        private int    _mp;
        private int    _attack;
        private int    _defense;
        private int    _dodge;
        private int    _exp;
        private int    _expToNextLevel;
        private int    _expToNextLevel2;
        private int    _level;



        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }

        public int MP
        {
            get { return _mp; }
            set { _mp = value; }
        }

        public int Attack
        {
            get { return _attack; }
            set { _attack = value; }
        }

        public int Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }

        public int Dodge
        {
            get { return _dodge; }
            set { _dodge = value; }
        }

        public int Exp
        {
            get { return _exp; }
            set { _exp = value; }
        }

        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }
    }
}
