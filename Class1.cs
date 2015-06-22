using System;

namespace MinimalDroolsForm
{
    public class CustomerRecord
    {

        public String Id { get; set; }
        public String Status { get; set; }
        public int Value { get; set; }
        public int DaysSinceLastOrder { get; set; }
        public int TotalOrders { get; set; }


        public CustomerRecord()
        {
            // Value = _value;
        }
    }
} 

