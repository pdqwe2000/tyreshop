using Tyre_Shop.Classes;

public class TyreJson : Tyre
{
    #region Properties
    public int Quantity { get; set; }
    #endregion

    #region Constructor
    /// <summary>  
    /// Constructor  
    /// </summary>  
    /// <param name="name">Hereditary from de Person class. Value entered by the user.</param>  
    /// <param name="phone">Hereditary from de Person class. Value entered by the user.</param>
    /// <param name="pass">Value entered by the user.</param>  
    /// <param name="admin">Specifies whether the user is an admin (not currently validated in this method).</param>  
    /// <returns>It calls the base constructor from the Person class to initialize shared properties (name,phone,).</returns>  
    public TyreJson(int id, string brand, string model, string size, Quality quality, int price, int quantity) : base(id, brand, model, size, quality, price)
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