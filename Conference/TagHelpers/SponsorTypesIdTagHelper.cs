using Conference.Service;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.TagHelpers
{
   [HtmlTargetElement("sponsorTypeId", Attributes = ForAttributeName)]
   public class SponsorTypesIdTagHelper : TagHelper
   {
      private readonly ISponsorTypesService sponsorTypesServices;
      private const string ForAttributeName = "asp-for";
      [HtmlAttributeName(ForAttributeName)]
      public ModelExpression For { get; set; }

      public SponsorTypesIdTagHelper(ISponsorTypesService sponsorTypesServices)
      {
         this.sponsorTypesServices = sponsorTypesServices;
      }
      public override void Process(TagHelperContext context, TagHelperOutput output)
      {
         var allSponsorTypesId = sponsorTypesServices.GetAllSponsorTypes();
         output.TagName = "select";
         output.Attributes.SetAttribute("id", For.Name);
         output.Attributes.SetAttribute("name", For.Name);
         output.Attributes.Add("class", "form-control");
         foreach (var sponsorTypes in allSponsorTypesId)
         {
            TagBuilder myOption = new TagBuilder("option")
            {
               TagRenderMode = TagRenderMode.Normal
            };
            myOption.Attributes.Add("value", sponsorTypes.Id.ToString());
            myOption.InnerHtml.Append(sponsorTypes.Id.ToString());

            output.Content.AppendHtml(myOption);
         }
      }
   }
}
