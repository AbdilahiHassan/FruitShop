using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FruitShop.TagHelpers
{
    public class EmailTagHelper  :TagHelper
    {
        public string  Address { get; set; }
        public string  LinkText { get; set; }
        //This method it is speacialy it has two argumment one for Taghelper context
        //and one for taghelper output
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            base.Process(context, output);
            output.TagName = "a";
            output.Attributes.SetAttribute("href", "mailto:"+ Address);
            output.Content.SetContent(LinkText);
        }


    }
}
