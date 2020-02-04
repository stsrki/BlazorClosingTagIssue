using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Components;

namespace RazorClassLibrary1
{
    public partial class Link : BaseComponent
    {
        [Parameter] public string Class { get; set; }

        [Parameter] public string To { get; set; }

        [Parameter] public string Title { get; set; }

        [Parameter] public RenderFragment ChildContent { get; set; }
    }
}
