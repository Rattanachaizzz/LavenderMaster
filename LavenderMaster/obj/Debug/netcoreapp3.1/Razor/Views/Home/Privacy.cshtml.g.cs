#pragma checksum "C:\Users\ctoso\OneDrive\Desktop\New folder\LavenderMaster\LavenderMaster\Views\Home\Privacy.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "94f7490961eead9dd8472b67bf407de8582c2985a29d9afc2504a4166d88b506"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Privacy), @"mvc.1.0.view", @"/Views/Home/Privacy.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ctoso\OneDrive\Desktop\New folder\LavenderMaster\LavenderMaster\Views\_ViewImports.cshtml"
using LavenderMaster

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\ctoso\OneDrive\Desktop\New folder\LavenderMaster\LavenderMaster\Views\_ViewImports.cshtml"
using LavenderMaster.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"94f7490961eead9dd8472b67bf407de8582c2985a29d9afc2504a4166d88b506", @"/Views/Home/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c87e00d0712856719eb03c30a2fc5a6d6d6f4d2e93dd5b2170bf24bba6aa457d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Privacy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<button id=""btnLoad"">Load Data</button>
<ul id=""userList""></ul>

<script src=""https://code.jquery.com/jquery-3.6.0.min.js""></script>
<script>
    $(""#btnLoad"").click(function() {
        $.ajax({
            url: ""/api/users"",  // เรียก API
            type: ""GET"",
            dataType: ""json"",
            success: function(data) {
                $(""#userList"").empty(); // ล้างข้อมูลเก่า
                $.each(data, function(index, user) {
                    $(""#userList"").append(""<li>"" + user.name + "" ("" + user.age + "" ปี)</li>"");
                });
            },
            error: function(xhr) {
                console.error(xhr.responseText);
            }
        });
    });
</script>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
