using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestIngWebApp.Client.Components
{
     
    public partial class PaginationStrip
    {
        [Parameter] public int TotalPages { get; set; }

        [Parameter] public int TotalRows { get; set; }

        private void UpdatePage(int currentIndex)
        {
            Value = currentIndex;
            ValueChanged.InvokeAsync(Value);
        }

    }
}
