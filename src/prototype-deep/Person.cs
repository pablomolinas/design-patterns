﻿
namespace prototype_deep
{
    public class Person : DeepPrototype<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
    }
}