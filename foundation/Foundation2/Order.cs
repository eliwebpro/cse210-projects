using System.Collections.Generic;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product) 
    {
        _products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetTotalCost(); // Correct method name
        }

        decimal shippingCost = _customer.LivesInUsa() ? 5 : 35;
        return totalCost + shippingCost;
    }

    public string GetPackLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"-- {product.GetPackLabel()}\n";
        }

        return label;
    }

    public string GetShipLabel()
    {
        return $"Shipping Label:\n{_customer.GetShipLabel()}";
    }
}
