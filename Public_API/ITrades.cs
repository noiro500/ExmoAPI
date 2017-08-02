using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExmoAPI.Public_API
{
    // Список сделок по валютной паре
    public interface ITrades
    {
        int TradeId { get; set; }
        string Type { get; set; }
        decimal Price { get; set; }
        decimal Quantity { get; set; }
        decimal Amount { get; set; }
        int Date { get; set; }
    }
    
}
