using System;
using System.Collections.Generic;

#nullable disable

namespace Data.Models.Trading_system
{
    public partial class Parameter
    {
        public string CurrentYear { get; set; }
        public string CurrentMonth { get; set; }
        public string WelcomeMessage { get; set; }
        public bool? AutoCreateId { get; set; }
        public bool? ShowToolTipOnDataGrid { get; set; }
        public string DateFormat { get; set; }
        public string DoubleNumberFormat { get; set; }
        public string IntegerNumberFormat { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string ImagePathSaved { get; set; }
    }
}
