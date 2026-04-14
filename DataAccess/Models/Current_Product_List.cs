using System;
using System.Collections.Generic;

namespace DataAccess.Models;

public partial class Current_Product_List
{
    public int ProductID { get; set; }

    public string ProductName { get; set; } = null!;
}
