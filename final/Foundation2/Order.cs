public class Order{

    //All the names of the customer
    private string _customer;

    //gets the customers address
    private string _cusAddr;

    //Ceck if the customer is in the USA or not
    private string _checkUSA;

    //Initialized the total cost so it will be used to harvest the total and will be printed.
    private int totalCost;

    //Initialized the product list so as to save lists of products and call a function on each of them later.
    public List<Products> _products = new List<Products>();

    //Saves all the item prices here so as to calculate the total.
    private List<int> _prices = new List<int>();

    //Sets the customer details.
    public void setCustomer(string cus){
        _customer = cus;
    }

    public string getCustomer(){
        return _customer;
    }

    public void setCustAdd(string cusAdd){
        _cusAddr = cusAdd;
    }
    private string getCusAddr(){
        return _cusAddr;
    }
    public void checkAdd(string add){
        _checkUSA = add;
    }

    private string us(){
        return _checkUSA;
    }
    //Takes the Address as an argument and check if it's usa or not
    public void calculateTotalOrderCost(string add){
        //Check if a customer is living in the USA or not to determine the cost of shipping.
        //if customer is living in the USA
        //Calculate the total
        int shippingCost;
        if(add.ToLower() == "usa"){
            shippingCost = 5;
            //Print the amount of the items in the customer's cart.
            Console.WriteLine($"You have {_products.Count()} Items in your cart");
            foreach (var product in _products)
            {
                _prices.Add(product.getPrice());
                /*Loop through all the items in the Product list and call a function to calculate price on each
                of them then return the values.*/

                //Print the product details to the console
                Console.WriteLine(product.packingLabel());
                //Print the products price with the shipping fee to the console
                Console.WriteLine($"Price: ${product.getPrice()+shippingCost}");
                Console.WriteLine();
            }
            Console.WriteLine($"Shipping fee for USA customer is: ${shippingCost}");
            //then the shipping cost will be $5


        }else{


            shippingCost = 35;
            //shipping cost will be $35
            //Print the amount of the items in the customer's cart.
            Console.WriteLine($"You have {_products.Count()} Items in your cart");
            foreach (var product in _products)
            {
                _prices.Add(product.getPrice());
                /*Loop through all the items in the Product list and call a function to calculate price on each
                of them then return the values.*/
                Console.WriteLine(product.packingLabel());
                Console.WriteLine($"Price: ${product.getPrice()}");
                Console.WriteLine();
            }
            Console.WriteLine($"Shipping fee for customer outside USA is: ${shippingCost}");
        }
        foreach (int amount in _prices)
        {
            totalCost +=amount;
        }
        Console.WriteLine($"Total price of goods: ${totalCost}, shipping fee: ${shippingCost}\nAmount due: {totalCost+shippingCost}");
    }

    public void order(){
        Console.WriteLine(getCustomer());
        Console.WriteLine(getCusAddr());
        Console.WriteLine();
        //check if the customer is in usa
        calculateTotalOrderCost(us());
    }
}