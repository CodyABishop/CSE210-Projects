public class Order //Class for the Order
{
    private Customer _customer;
    List<Product> _allProducts = new List<Product>();
    public Order(Customer customer) //Simple constructor to set the info
    {
        _customer = customer;
    }
    //Getters
    public Customer GetCustomer() 
    {
        return _customer;
    }
    //End Getters
    //Setters
    public void SetCustomer(Customer customer) 
    {
        _customer = customer;
    }
    //End Setters
    public void AddProduct(Product newProd) 
    {
        _allProducts.Add(newProd);
    }
    public void AddProduct(string name, string id, double price, int quantity) //Alternate add method for directly making a product.
    {
        Product newProd = new(name, id, price, quantity);
        _allProducts.Add(newProd);
    }
    public double GetTotalCost() //Calls the SalePrice method on every product added.
    {
        double TotalCost = 0;
        foreach (Product p in _allProducts){
            TotalCost = TotalCost + p.GetSalePrice();
        }
        if(_customer.GetUSAStatus() == true){
            TotalCost = TotalCost + 5; //5$ shipping if customer is within the US.
        } else {
            TotalCost = TotalCost + 35; //35$ otherwise
        }
        return Math.Round(TotalCost,2); //Rounds total cost to nearest cent.

    }
    public void DisplayPackingLabel(){
        Console.WriteLine("\n==Packing Label==");
        foreach (Product p in _allProducts){
            Console.WriteLine($"Product {p.GetID()} | {p.GetName()}");
        }
    }
    public void DisplayShippingLabel(){
        Console.WriteLine("\n--Shipping Label--");
        Console.WriteLine($"{_customer.GetCustomerName()}\n{_customer.GetCustomerAddress()}");
    }
}