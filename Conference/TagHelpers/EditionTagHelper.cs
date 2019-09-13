﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conference.Service;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Conference.TagHelpers
{
    // You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
    [HtmlTargetElement("editions", Attributes = ForAttributeName)]
    public class EditionTagHelper : TagHelper
    {
        private readonly IEditionService editionService;
        private const string ForAttributeName = "asp-for";
        public EditionTagHelper(IEditionService editionService)
        {
            this.editionService = editionService;
        }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            var allEditions = editionService.GetAllEditions();
            output.TagName = "select";
            output.Attributes.Add("class", "form-control");
            foreach (var edition in allEditions)
            {
                TagBuilder myOption = new TagBuilder("option")
                {
                    TagRenderMode = TagRenderMode.Normal
                };
                myOption.Attributes.Add("value", edition.Id.ToString());
                myOption.InnerHtml.Append(edition.Name);
                output.Content.AppendHtml(myOption);
            }
        }
    }
}