public class Cashier {
    private int lucky_bill = 0;
    private int number_of_customers = 0;
    private int discount = 0;
    Dictionary<int, int> prices_of_products = new Dictionary<int, int>();
    public Cashier(int n, int discount, int[] products, int[] prices) {
        this.lucky_bill = n;
        this.discount = discount;
        for(int i = 0 ; i < products.Length; i++)
        {
            prices_of_products.Add(products[i], prices[i]);
        }
    }
    
    public double GetBill(int[] product, int[] amount) {
        number_of_customers ++;
        double bill = 0.0 ;
        for(int i = 0 ; i < product.Length; i++)
        {
            bill += amount[i] * prices_of_products[product[i]];
        }
        if(number_of_customers % lucky_bill == 0 )
        {
            bill = bill *  (100 - discount) / 100 ; 
        }
        return bill;
    }
}
