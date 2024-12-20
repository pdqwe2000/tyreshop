//-----------------------------------------------------------------​
//    <copyright file="Person.cs" company="FujiSoft">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-12-2024</date>​
//    <time>23:00</time>​
//    <version>0.1</version>​
//    <author>Pedro Duarte</author>​
//-----------------------------------------------------------------

namespace Tyre_Shop.Classes
{
    // Abstract base class that represents a person in the system.  
    // This class serves as a foundation for other classes, such as User, that share common properties like Name and Phone.  
    public class Person
    {
        #region Private Properties  
        // Property to store the person's name.
        public string Name { get; set; }
        // Property to store the person's phone number.
        public string Phone { get; set; }
        #endregion

        #region Constructors
        // Constructor to initialize a Person object with a name and phone number.
        public Person(string name, string phone)
        {
            Name = name;      // Assigns the given name to the Name property.
            Phone = phone;    // Assigns the given phone number to the Phone property.
        }
        public Person() { }
        #endregion
    }
}
