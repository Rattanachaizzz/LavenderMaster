#pragma checksum "C:\Users\ctoso\OneDrive\Desktop\New folder\LavenderMaster\LavenderMaster\Views\Home\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bdc0995b71b1566e2d03c152e46a2e86c98714971c1ad488a62a572f6f087ca7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bdc0995b71b1566e2d03c152e46a2e86c98714971c1ad488a62a572f6f087ca7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c87e00d0712856719eb03c30a2fc5a6d6d6f4d2e93dd5b2170bf24bba6aa457d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
    <style>
        body {
            font-family: 'Kanit', sans-serif;
            background-color: #f8f9fa;

            background-image: url('/images/backgrund.jpg');
            background-size: cover;
            /* background-repeat: no-repeat; */

        }

        .custom-card {
            border-radius: 10px;
            box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
            transition: transform 0.3s ease, box-shadow 0.3s ease;
            border: 1px solid #dee2e6; /* เพิ่มเส้นขอบ */
        }

        .custom-card:hover {
            transform: translateY(-10px);
            box-shadow: 0 8px 16px rgba(0, 0, 0, 0.2);
        }

        .custom-card h3 {
            color: #333333;
            font-weight: 500;
        }

        .custom-card p {
             color: #666666;
        }

        .small-table {
            display: inline-table; /* ทำให้ตารางแสดงผลแบบ inline */
        }

        .small-table td, .small-table th {
            font-size: 12px;");
            WriteLiteral(@"
            padding: 0.5rem;
        }

        .full-screen {
             height: 100vh; /* 100vh = 100% ของ viewport height */
        }

        .no-padding-margin {
            padding: 0;
            margin: 0;
        }

        .flip-card {
          background-color: transparent;
          border-radius: 10px;
          width: 360px;
          height: 150px;
          perspective: 1000px;
        }

        .flip-card-inner {
          position: relative;
          width: 100%;
          height: 100%;
          border-radius: 10px;
          text-align: center;
          transition: transform 0.6s;
          transform-style: preserve-3d;
          box-shadow: 0 4px 8px 0 rgba(0,0,0,0.2);
        }

        .flip-card:hover .flip-card-inner {
          transform: rotateY(180deg);
        }

        .flip-card-front, .flip-card-back {
          position: absolute;
          width: 100%;
          height: 100%;
          border-radius: 10px;
          -webkit-ba");
            WriteLiteral(@"ckface-visibility: hidden;
          backface-visibility: hidden;
        }

        .flip-card-front {
          background-color: #bbb;
          color: black;
        }

        .flip-card-back {
          /* background-color: #2980b9; */
          background-color:white;
          color: white;
          transform: rotateY(180deg);
        }
    </style>

");
            WriteLiteral(@"
      <div class=""container-fluid full-screen no-padding-margin"" style=""padding-top: 5%"">
         <div class=""row"">
           <div class=""col-md-4 mb-4"">
             <div class=""flip-card"">
              <div class=""flip-card-inner"">
                 <div class=""flip-card-front custom-card p-4 text-center h-100"">
                        <p style=""font-weight: bold; font-size: 55px"">");
            Write(
#nullable restore
#line 112 "C:\Users\ctoso\OneDrive\Desktop\New folder\LavenderMaster\LavenderMaster\Views\Home\Index.cshtml"
                                                                       ViewData["stations_all"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</p>
                 </div>
                <div class=""flip-card-back"">
                    <img src=""/images/good.jpg"" alt=""Avatar"" style=""width:170px;height:150px;"">
                </div>
              </div>
            </div>
         </div>


         <div class=""col-md-4 mb-4"">
             <div class=""flip-card"">
              <div class=""flip-card-inner"">
                 <div class=""flip-card-front custom-card p-4 text-center h-100"">
                        <p style=""font-weight: bold; font-size: 55px"">");
            Write(
#nullable restore
#line 126 "C:\Users\ctoso\OneDrive\Desktop\New folder\LavenderMaster\LavenderMaster\Views\Home\Index.cshtml"
                                                                       ViewData["stations_good"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</p>
                 </div>
                <div class=""flip-card-back"">
                    <img src=""/images/good.jpg"" alt=""Avatar"" style=""width:170px;height:150px;"">
                </div>
              </div>
            </div>
         </div>

         <div class=""col-md-4 mb-4"">
             <div class=""flip-card"">
              <div class=""flip-card-inner"">
                 <div class=""flip-card-front custom-card p-4 text-center h-100"">
                        <p style=""font-weight: bold; font-size: 55px"">");
            Write(
#nullable restore
#line 139 "C:\Users\ctoso\OneDrive\Desktop\New folder\LavenderMaster\LavenderMaster\Views\Home\Index.cshtml"
                                                                       ViewData["stations_bad"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</p>
                 </div>
                <div class=""flip-card-back"">
                    <img src=""/images/bad.jpg"" alt=""Avatar"" style=""width:170px;height:150px;"">
                </div>
              </div>
            </div>
         </div>


         </div>

         <table class=""table table-striped table-bordered table-hover table-responsive"" style=""text-align: center;"">
             <thead style=""background-color: #2980b9;"">
                 <tr style=""font-size: 14px;padding: 0.5rem;"">
                    <th>ID</th>
                    <th>PBL</th>
                    <th>PLANT</th>
                    <th>BU</th>
                    <th>NAME</th>
                    <th>IP SIM</th>
                    <th>IP BO</th>
                    <th>CREATE DATE</th>
                    <th>ACTION</th>
                </tr>
            </thead>
            <tbody style=""background-color: white;"">
");
#nullable restore
#line 166 "C:\Users\ctoso\OneDrive\Desktop\New folder\LavenderMaster\LavenderMaster\Views\Home\Index.cshtml"
             foreach (var station in ViewBag.stations)
                {

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <tr style=\"font-size: 12px;padding: 0.5rem;\">\r\n                        <td>");
            Write(
#nullable restore
#line 169 "C:\Users\ctoso\OneDrive\Desktop\New folder\LavenderMaster\LavenderMaster\Views\Home\Index.cshtml"
                             station.Id

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td>");
            Write(
#nullable restore
#line 170 "C:\Users\ctoso\OneDrive\Desktop\New folder\LavenderMaster\LavenderMaster\Views\Home\Index.cshtml"
                              station.Pbl ?? "-"

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td>");
            Write(
#nullable restore
#line 171 "C:\Users\ctoso\OneDrive\Desktop\New folder\LavenderMaster\LavenderMaster\Views\Home\Index.cshtml"
                              station.Plant ?? "-"

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td>");
            Write(
#nullable restore
#line 172 "C:\Users\ctoso\OneDrive\Desktop\New folder\LavenderMaster\LavenderMaster\Views\Home\Index.cshtml"
                             station.Bu

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td style=\"width:20%;text-align: left;\">");
            Write(
#nullable restore
#line 173 "C:\Users\ctoso\OneDrive\Desktop\New folder\LavenderMaster\LavenderMaster\Views\Home\Index.cshtml"
                                                                 station.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td>");
            Write(
#nullable restore
#line 174 "C:\Users\ctoso\OneDrive\Desktop\New folder\LavenderMaster\LavenderMaster\Views\Home\Index.cshtml"
                             station.IpSim

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td>");
            Write(
#nullable restore
#line 175 "C:\Users\ctoso\OneDrive\Desktop\New folder\LavenderMaster\LavenderMaster\Views\Home\Index.cshtml"
                              station.IpBo ?? "-"

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td>");
            Write(
#nullable restore
#line 176 "C:\Users\ctoso\OneDrive\Desktop\New folder\LavenderMaster\LavenderMaster\Views\Home\Index.cshtml"
                             station.CreateDate

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td class=\"text-center\">\r\n                            <div class=\"row gx-1\">\r\n                                <div class=\"col\" style=\"width: 100px;\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 5993, "\"", 6056, 1);
            WriteAttributeValue("", 6000, 
#nullable restore
#line 180 "C:\Users\ctoso\OneDrive\Desktop\New folder\LavenderMaster\LavenderMaster\Views\Home\Index.cshtml"
                                              Url.Action("download", new { station_id = station.Id })

#line default
#line hidden
#nullable disable
            , 6000, 56, false);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-sm w-100\">download</a>\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 185 "C:\Users\ctoso\OneDrive\Desktop\New folder\LavenderMaster\LavenderMaster\Views\Home\Index.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js\"></script>");
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
