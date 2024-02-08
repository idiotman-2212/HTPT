using System;

public class Product
{
    private int productID;
    private string productName;
    private decimal price;
    private DateTime manufactureDate;
    private bool isAvailable;

    public int ProductID
    {
        get { return productID; }
        set
        {
            if (value > 0)
            {
                productID = value;
            }
        }
    }

    public string ProductName
    {
        get { return productName; }
        set
        {
            if (!string.IsNullOrEmpty(value))
            {
                productName = value;
            }
        }
    }

    public decimal Price
    {
        get { return price; }
        set
        {
            if (value >= 0)
            {
                price = value;
            }
        }
    }

    public DateTime ManufactureDate
    {
        get { return manufactureDate; }
        set
        {
            if (value != DateTime.MinValue)
            {
                manufactureDate = value;
            }
        }
    }

    public bool IsAvailable
    {
        get { return isAvailable; }
        set { isAvailable = value; }
    }

    public Product()
    {
        ProductID = 1;
        ProductName = "null";
        Price = 0.0m;
        ManufactureDate = DateTime.MinValue;
        IsAvailable = false;
    }

    public Product(int productID, string productName, decimal price, DateTime manufactureDate, bool isAvailable)
    {
        ProductID = productID;
        ProductName = productName;
        Price = price;
        ManufactureDate = manufactureDate;
        IsAvailable = isAvailable;
    }
}
