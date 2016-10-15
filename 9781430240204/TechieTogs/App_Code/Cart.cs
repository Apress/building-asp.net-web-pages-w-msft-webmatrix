using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// TechieTogs shopping cart
/// </summary>
public class Cart
{
    private List<CartItem> _Items = new List<CartItem>();
    
    public List<CartItem> Items { get { return _Items; } }
    
    public decimal TotalValue { get { return _Items.Sum(p => p.Price); } }
    
    public void AddItem(int productID, string size, decimal price)
    {
        _Items.Add( new CartItem { ProductID = productID, Size = size, Price = price } );
    }
    
    public void Clear()
    {
        _Items.Clear();
    }
    
    public void RemoveItem(int index)
    {
        _Items.RemoveAt(index);
    }
    
}

/// <summary>
/// TechieTogs shopping cart line item
/// </summary>
public class CartItem
{
    public int ProductID { get; set; }
    public string Size { get; set; }
    public decimal Price { get; set; }
}
