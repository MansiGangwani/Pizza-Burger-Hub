using System.ComponentModel;

namespace Pizza_Burger_Hub.Models
{
    public enum PaymentTypes
    {
        [Description("Cash On Delivery")]
        Cod = 1,

        [Description("Take Away")]
        Take = 2

        
      
    }
}
