//-----------------------------------------------------------------​
//    <copyright file="TyreJson.cs" company="FujiSoft">​
//     Copyright IPCA-EST. All rights reserved.​
//    </copyright>​
//    <date>19-12-2024</date>​
//    <time>23:00</time>​
//    <version>0.1</version>​
//    <author>Pedro Duarte</author>​
//-----------------------------------------------------------------

using Tyre_Shop.Classes;

/// <summary>
/// This class represents a TyreJson in the Tyre Shop system.
/// It inherits from the Tyre class and adds specific properties related to tyres.
/// </summary>
public class TyreJson : Tyre
{
    #region Properties
    public int Quantity { get; set; }
    #endregion

    #region Constructor
    /// <summary>
    /// Parameterized constructor to create a Tyre object with specific details.
    /// <param name="id"> Unique identifier for the tyre.</param>
    /// <param name="brand">Brand of the tyre (e.g., Michelin, Bridgestone).</param>
    /// <param name="model">Model of the tyre (e.g., Pilot Sport 4, Turanza T005).</param>
    /// <param name="size">Size of the tyre (e.g., 205/55 R16).</param>
    /// <param name="quality">Quality of the tyre, represented by an enum (e.g., AAA, AA, etc.).</param>
    /// <param name="price">Price of the tyre in the system.</param>
    /// <param name="quantity">Quantity of tyres in stock</param>
    /// </summary>
    public TyreJson(int id, string brand, string model, string size, Quality quality, decimal price, int quantity) : base(id, brand, model, size, quality, price)
    {
        Quantity = quantity;       // Assigns quantity.
    }

    /// <summary>  
    /// Constructor  
    /// </summary>  
    /// <param name="">Empty constructer</param>
    /// <
    /// <returns></returns>  
    public TyreJson() { }
    #endregion
}