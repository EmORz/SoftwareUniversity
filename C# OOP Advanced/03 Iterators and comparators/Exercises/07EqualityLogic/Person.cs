﻿using System;

namespace _07EqualityLogic
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            int result = this.Name.CompareTo(other.Name);

            if (result == 0)
            {
                result = this.Age.CompareTo(other.Age);
            }
            return result;
            
        }

        public override bool Equals(object obj) //Override of Equals() used for the SortedSet
        {
            if (obj is Person other)
            {
                return this.Name == other.Name && this.Age == other.Age;
            }

            return false;
        }

        public override int GetHashCode() //Override of GetHashCode() Used for the HashSet
        {
            return this.Name.GetHashCode() + this.Age.GetHashCode(); 
        }
    }
}