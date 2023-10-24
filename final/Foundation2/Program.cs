//Foundation 2, Encapsulation
class Program
{
    static void Main(string[] args)
    {
        //ORDER 1
        Customer cust1 = new("Alice","1337 Road Lane", "Sillyville", "TN", "USA");
        Order ord1 = new(cust1);
        ord1.AddProduct("Graphics Card","GP513",2000.37,2);
        ord1.AddProduct("Network Adapter","NA332",50.42,1);
        //ORDER 2
        Address addr2 = new("37 Lily Lane", "St. Johns", "Newfoundland", "Canada");
        Customer cust2 = new("Mark",addr2);
        Order ord2 = new(cust2);
        Product prod1 = new("Prebuilt PC", "PC110", 2005,1);
        Product prod2 = new("Prebuilt Laptop", "LP389", 1500,1);
        Product prod3 = new("Potato", "PO747", 5,2);
        ord2.AddProduct(prod1);
        ord2.AddProduct(prod2);
        ord2.AddProduct(prod3);
        //ORDER 3, CUSTOMER 2 MOVED
        Address newAddress = new("38 Rose Drive", "Yuba", "California", "United States");
        Order ord3 = new(cust2);
        ord3.AddProduct("Potato", "PO747", 1.31,100);
        ord3.AddProduct("Rice Grain", "RI633", 0.01,1);
        ord3.AddProduct("Corn Cob", "CO347", 0.61,4);

        Console.WriteLine("\n\nOrder 1"); //Spacing between each order for clarity.
        Console.WriteLine($"Final Cost: ${ord1.GetTotalCost()}");
        ord1.DisplayShippingLabel();
        ord1.DisplayPackingLabel();
        Console.WriteLine("\n\nOrder 2");
        Console.WriteLine($"Final Cost: ${ord2.GetTotalCost()}");
        ord2.DisplayShippingLabel();
        ord2.DisplayPackingLabel();
        
        //Third order is after customer 2 moved.
        cust2.SetAddress(newAddress);
        Console.WriteLine("\n\nOrder 3");
        Console.WriteLine($"Final Cost: ${ord3.GetTotalCost()}");
        ord3.DisplayShippingLabel();
        ord3.DisplayPackingLabel();
    }
}