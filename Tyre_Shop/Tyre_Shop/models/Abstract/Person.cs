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
    /// <summary>
    /// This class serves as a foundation for other classes, such as User, that share common properties like Name and Phone.
    /// </summary>
    public class Person
    {
        #region Private Properties  
        // Property to store the person's name.
        public string Name { get; set; }
        // Property to store the person's phone number.
        public string Phone { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Constructor to initialize a Person object with a name and phone number.
        /// <param name="name">Property to store the person's name.</param>
        /// <param name="phone">Property to store the person's phone number.</param>
        /// </summary>
        public Person(string name, string phone)
        {
            Name = name;      // Assigns the given name to the Name property.
            Phone = phone;    // Assigns the given phone number to the Phone property.
        }
        /// <summary>
        /// Default constructor for creating a Person object with no initial data.
        /// <param name="">Empty constructer</param>
        /// </summary>
        public Person() { }
        #endregion
    }
}
