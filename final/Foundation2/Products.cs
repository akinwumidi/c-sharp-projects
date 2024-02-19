public class Products{

    private string _productName;
    private string _productId;
    private int _price;
    private int _productQty;

    public Products(string name, string id,int price, int qty){
        _productName = name;
        _productId = id;
        _price = price;
        _productQty = qty;
    }
    public string packingLabel(){
        return $"Product Name: {_productName}\nProduct Id: {_productId}";
    }
    public int getPrice(){
        int price = _price * _productQty;
        return price;
    }
}