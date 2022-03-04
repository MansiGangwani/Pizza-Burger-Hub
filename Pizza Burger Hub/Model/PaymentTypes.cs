using System.ComponentModel;

namespace GuniKichen.Models
{
    public enum PaymentTypes
    {
        [Description("Cash On Delivery")]
        Cod = 1,

        [Description("Take Away")]
        Take = 2

        
      
    }
}
