﻿using _07FoodShortage.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07FoodShortage.Models
{
    class Rebel : IRebel, IBuyer
    {
        private string name;

        private int age;

        private string group;

        private int food;

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Group = group;
        }

        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public int Age
        {
            get { return age; }
            private set { age = value; }
        }

        public string  Group
        {
            get { return group; }
            private set { group = value; }
        }

        public int Food
        {
            get { return food; }

            private set
            {
                food = 0;
            }
        }
        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
