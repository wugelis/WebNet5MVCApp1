using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MingChi.Web.BlazorServerCRM.Components
{
    public class MyButton3: ComponentBase
    {
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            builder.AddMarkupContent(0, "<button class=\"btn btn-primary\">我是按鈕3</button>");

            base.BuildRenderTree(builder);
        }
    }
}
