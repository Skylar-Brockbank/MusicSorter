#pragma checksum "C:\Users\Skylar\Desktop\MusicSorter.solutions\Views\Album\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7ace05fd9777a70904261239eb6f709a2844a2dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Album_Show), @"mvc.1.0.view", @"/Views/Album/Show.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Skylar\Desktop\MusicSorter.solutions\Views\Album\Show.cshtml"
using MusicSorter.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Skylar\Desktop\MusicSorter.solutions\Views\Album\Show.cshtml"
using SongLogic;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ace05fd9777a70904261239eb6f709a2844a2dd", @"/Views/Album/Show.cshtml")]
    public class Views_Album_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 4 "C:\Users\Skylar\Desktop\MusicSorter.solutions\Views\Album\Show.cshtml"
Write(Model.AlbumName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<ul>\r\n");
#nullable restore
#line 6 "C:\Users\Skylar\Desktop\MusicSorter.solutions\Views\Album\Show.cshtml"
 foreach(Song song in @Model.SongList)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <li>");
#nullable restore
#line 8 "C:\Users\Skylar\Desktop\MusicSorter.solutions\Views\Album\Show.cshtml"
 Write(song.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n  ");
#nullable restore
#line 9 "C:\Users\Skylar\Desktop\MusicSorter.solutions\Views\Album\Show.cshtml"
Write(song.RunTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 10 "C:\Users\Skylar\Desktop\MusicSorter.solutions\Views\Album\Show.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n<form");
            BeginWriteAttribute("action", " action=\"", 185, "\"", 210, 2);
            WriteAttributeValue("", 194, "/album/", 194, 7, true);
#nullable restore
#line 13 "C:\Users\Skylar\Desktop\MusicSorter.solutions\Views\Album\Show.cshtml"
WriteAttributeValue("", 201, Model.Id, 201, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" method=""post"">
  <label for=""title"">Song Title</label>
  <input id=""title"" name=""title"" type=""text"">
  <label for=""runtime"">Runtime</label>
  <input id=""runtime"" name=""runtime"" type=""text"">
  <button type=""submit"">Add Song to the Album</button>
</form>

<a href=""/album"">Home</a>




<p>placeholder text</p>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
