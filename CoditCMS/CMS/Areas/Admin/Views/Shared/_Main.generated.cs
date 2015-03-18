﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Net;
    using System.Text;
    using System.Web;
    using System.Web.Helpers;
    using System.Web.Mvc;
    using System.Web.Mvc.Ajax;
    using System.Web.Mvc.Html;
    using System.Web.Optimization;
    using System.Web.Routing;
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 3 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
    using CMS;
    
    #line default
    #line hidden
    using CMS.Mvc;
    using CMS.PagesSettings.Lists;
    using CMS.ViewModels;
    
    #line 1 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
    using DB;
    
    #line default
    #line hidden
    using DB.Entities;
    
    #line 2 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
    using Libs;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Shared/_Main.cshtml")]
    public partial class _Areas_Admin_Views_Shared__Main_cshtml : CMS.Mvc.AdminViewPage<dynamic>
    {

#line 63 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
public System.Web.WebPages.HelperResult RenderModulesTree(IEnumerable<SitemapElement> modules)
                    {
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 63 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
                

#line default
#line hidden

#line 64 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
                     
                    foreach (var child in modules)
                    {
                        if (child.Childs.Count > 0)
                        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                            <li><span");

WriteLiteralTo(__razor_helper_writer, " class=\"folder\"");

WriteLiteralTo(__razor_helper_writer, ">");


#line 69 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
                       WriteTo(__razor_helper_writer, child.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</span>\r\n                                <ul>\r\n");

WriteLiteralTo(__razor_helper_writer, "                                    ");


#line 71 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
      WriteTo(__razor_helper_writer, RenderModulesTree(child.Childs));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\r\n                                </ul>\r\n                            </li>\r\n");


#line 74 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
                        }
                        else
                        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "                            <li><a ");


#line 77 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
                                    if (child.Controller == (string)ViewContext.RouteData.Values["Controller"] && 
                                       (string.IsNullOrEmpty(child.Action) || child.Action == (string)ViewContext.RouteData.Values["action"])){

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " ");

WriteLiteralTo(__razor_helper_writer, "class=\"selected\"");

WriteLiteralTo(__razor_helper_writer, " ");


#line 78 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
                                                                                                                                                                              }

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, " href=\"");


#line 78 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
                                                                                                                                                        WriteTo(__razor_helper_writer, Url.Action(child.Action, child.Controller));


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "\">");


#line 78 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
                                                                                                                                                                                                     WriteTo(__razor_helper_writer, child.Title);


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "</a></li>\r\n");


#line 79 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
                        }
                    }
                

#line default
#line hidden
});

#line 81 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
}
#line default
#line hidden

        public _Areas_Admin_Views_Shared__Main_cshtml()
        {
        }
        public override void Execute()
        {
WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n<head>\r\n    <title>");

            
            #line 8 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
      Write(WebContext.HtmlPageTitle);

            
            #line default
            #line hidden
WriteLiteral("</title>        \r\n");

            
            #line 9 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
    
            
            #line default
            #line hidden
            
            #line 9 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
      
        var mediaRoot = "http://kobyb1988.github.io/CoditCMS/CoditCMS/CMS";/*"http://kobyb1988.github.io/CoditCMS/CoditCMS/CMS" "http://localhost:8000" */
    
            
            #line default
            #line hidden
WriteLiteral("\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 305), Tuple.Create("\"", 408)
            
            #line 12 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 312), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 312), false)
, Tuple.Create(Tuple.Create("", 322), Tuple.Create("/Areas/Admin/Scripts/Default/jqueryUI/development-bundle/themes/base/jquery.ui.al" +
"l.css", 322), true)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 456), Tuple.Create("\"", 531)
            
            #line 13 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 463), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 463), false)
, Tuple.Create(Tuple.Create("", 473), Tuple.Create("/Areas/Admin/Styles/Default/jquery-ui-timepicker-addon.css", 473), true)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 563), Tuple.Create("\"", 637)
            
            #line 14 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 570), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 570), false)
, Tuple.Create(Tuple.Create("", 580), Tuple.Create("/Areas/Admin/Styles/Default/fileuploader/fineuploader.css", 580), true)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 669), Tuple.Create("\"", 731)
            
            #line 15 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 676), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 676), false)
, Tuple.Create(Tuple.Create("", 686), Tuple.Create("/Areas/Admin/Styles/Default/toastr/toastr.css", 686), true)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 763), Tuple.Create("\"", 836)
            
            #line 16 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 770), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 770), false)
, Tuple.Create(Tuple.Create("", 780), Tuple.Create("/Areas/Admin/Styles/Default/toastr/toastr-responsive.css", 780), true)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 868), Tuple.Create("\"", 924)
            
            #line 17 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 875), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 875), false)
, Tuple.Create(Tuple.Create("", 885), Tuple.Create("/Areas/Admin/Styles/Default/Default.css", 885), true)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 974), Tuple.Create("\"", 1038)
            
            #line 18 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 980), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 980), false)
, Tuple.Create(Tuple.Create("", 990), Tuple.Create("/Areas/Admin/Scripts/Default/jquery-1.7.1.min.js", 990), true)
);

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1085), Tuple.Create("\"", 1193)
            
            #line 19 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 1091), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 1091), false)
, Tuple.Create(Tuple.Create("", 1101), Tuple.Create("/Areas/Admin/Scripts/Default/jqueryUI/development-bundle/ui/minified/jquery-ui.cu" +
"stom.min.js", 1101), true)
);

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1240), Tuple.Create("\"", 1347)
            
            #line 20 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 1246), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 1246), false)
, Tuple.Create(Tuple.Create("", 1256), Tuple.Create("/Areas/Admin/Scripts/Default/jqueryUI/development-bundle/ui/i18n/jquery.ui.datepi" +
"cker-ru.js", 1256), true)
);

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1394), Tuple.Create("\"", 1472)
            
            #line 21 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 1400), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 1400), false)
, Tuple.Create(Tuple.Create("", 1410), Tuple.Create("/Areas/Admin/Scripts/Default/drag/jquery.dragsort-0.5.1.min.js", 1410), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1496), Tuple.Create("\"", 1561)
            
            #line 22 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 1502), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 1502), false)
, Tuple.Create(Tuple.Create("", 1512), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/util.js", 1512), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1585), Tuple.Create("\"", 1652)
            
            #line 23 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 1591), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 1591), false)
, Tuple.Create(Tuple.Create("", 1601), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/button.js", 1601), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1676), Tuple.Create("\"", 1743)
            
            #line 24 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 1682), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 1682), false)
, Tuple.Create(Tuple.Create("", 1692), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/header.js", 1692), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1767), Tuple.Create("\"", 1834)
            
            #line 25 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 1773), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 1773), false)
, Tuple.Create(Tuple.Create("", 1783), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/header.js", 1783), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1858), Tuple.Create("\"", 1931)
            
            #line 26 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 1864), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 1864), false)
, Tuple.Create(Tuple.Create("", 1874), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/handler.base.js", 1874), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1955), Tuple.Create("\"", 2028)
            
            #line 27 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 1961), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 1961), false)
, Tuple.Create(Tuple.Create("", 1971), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/handler.form.js", 1971), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2052), Tuple.Create("\"", 2124)
            
            #line 28 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2058), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2058), false)
, Tuple.Create(Tuple.Create("", 2068), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/handler.xhr.js", 2068), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2148), Tuple.Create("\"", 2223)
            
            #line 29 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2154), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2154), false)
, Tuple.Create(Tuple.Create("", 2164), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/uploader.basic.js", 2164), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2247), Tuple.Create("\"", 2311)
            
            #line 30 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2253), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2253), false)
, Tuple.Create(Tuple.Create("", 2263), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/dnd.js", 2263), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2335), Tuple.Create("\"", 2404)
            
            #line 31 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2341), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2341), false)
, Tuple.Create(Tuple.Create("", 2351), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/uploader.js", 2351), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2428), Tuple.Create("\"", 2502)
            
            #line 32 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2434), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2434), false)
, Tuple.Create(Tuple.Create("", 2444), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/jquery-plugin.js", 2444), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2526), Tuple.Create("\"", 2608)
            
            #line 33 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2532), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2532), false)
, Tuple.Create(Tuple.Create("", 2542), Tuple.Create("/Areas/Admin/Scripts/Default/jqueryUI/js/jquery-ui-sliderAccess.js", 2542), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2632), Tuple.Create("\"", 2718)
            
            #line 34 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2638), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2638), false)
, Tuple.Create(Tuple.Create("", 2648), Tuple.Create("/Areas/Admin/Scripts/Default/jqueryUI/js/jquery-ui-timepicker-addon.js", 2648), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2742), Tuple.Create("\"", 2818)
            
            #line 35 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2748), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2748), false)
, Tuple.Create(Tuple.Create("", 2758), Tuple.Create("/Areas/Admin/Scripts/Default/jqueryUI/js/ui.datepicker-ru.js", 2758), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2842), Tuple.Create("\"", 2925)
            
            #line 36 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2848), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2848), false)
, Tuple.Create(Tuple.Create("", 2858), Tuple.Create("/Areas/Admin/Scripts/Default/jqueryUI/js/jquery-ui-timepicker-ru.js", 2858), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2949), Tuple.Create("\"", 3020)
            
            #line 37 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2955), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2955), false)
, Tuple.Create(Tuple.Create("", 2965), Tuple.Create("/Areas/Admin/Scripts/Default/knockout/knockout-2.2.1.js", 2965), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3044), Tuple.Create("\"", 3118)
            
            #line 38 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 3050), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 3050), false)
, Tuple.Create(Tuple.Create("", 3060), Tuple.Create("/Areas/Admin/Scripts/Default/knockout/knockout-sortable.js", 3060), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3142), Tuple.Create("\"", 3203)
            
            #line 39 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 3148), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 3148), false)
, Tuple.Create(Tuple.Create("", 3158), Tuple.Create("/Areas/Admin/Scripts/Default/toastr/toastr.js", 3158), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3227), Tuple.Create("\"", 3286)
            
            #line 40 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 3233), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 3233), false)
, Tuple.Create(Tuple.Create("", 3243), Tuple.Create("/Areas/Admin/Scripts/Default/autoNumeric.js", 3243), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3310), Tuple.Create("\"", 3365)
            
            #line 41 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 3316), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 3316), false)
, Tuple.Create(Tuple.Create("", 3326), Tuple.Create("/Areas/Admin/Scripts/Default/Default.js", 3326), true)
);

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3412), Tuple.Create("\"", 3466)
            
            #line 42 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 3418), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 3418), false)
, Tuple.Create(Tuple.Create("", 3428), Tuple.Create("/Areas/Admin/Scripts/Default/Mktree.js", 3428), true)
);

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3513), Tuple.Create("\"", 3562)
            
            #line 43 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 3519), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 3519), false)
, Tuple.Create(Tuple.Create("", 3529), Tuple.Create("/Areas/Admin/Ckeditor/ckeditor.js", 3529), true)
);

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3609), Tuple.Create("\"", 3667)
            
            #line 44 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 3615), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 3615), false)
, Tuple.Create(Tuple.Create("", 3625), Tuple.Create("/Areas/Admin/Scripts/Default/Myckconfig.js", 3625), true)
);

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3714), Tuple.Create("\"", 3773)
            
            #line 45 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 3720), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 3720), false)
, Tuple.Create(Tuple.Create("", 3730), Tuple.Create("/Areas/Admin/Scripts/Default/files-logic.js", 3730), true)
);

WriteLiteral("></script>\r\n</head>\r\n\r\n<body>\r\n\r\n    <table");

WriteLiteral(" id=\"logo-table\"");

WriteLiteral(">\r\n        <tr>\r\n            <td");

WriteLiteral(" id=\"logo-left\"");

WriteLiteral("><div");

WriteLiteral(" id=\"logo\"");

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 3900), Tuple.Create("\"", 3970)
            
            #line 52 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 3906), Tuple.Create<System.Object, System.Int32>(Url.Content(mediaRoot + "/Areas/Admin/Images/Default/logo.gif")
            
            #line default
            #line hidden
, 3906), false)
);

WriteLiteral(" alt=\"OziCms.cms 4.0\"");

WriteLiteral(" /><div");

WriteLiteral(" id=\"ozi-version\"");

WriteLiteral(">Версия — 4.0</div></div></td>\r\n            <td");

WriteLiteral(" id=\"logo-right\"");

WriteLiteral("><span");

WriteLiteral(" id=\"hello\"");

WriteLiteral(">Здравствуйте, ");

            
            #line 53 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
                                                          Write(Request.ServerVariables["AUTH_USER"]);

            
            #line default
            #line hidden
WriteLiteral(" <a");

WriteLiteral(" href=\"/account/logout\"");

WriteLiteral(">Выйти</a></span></td>\r\n        </tr>\r\n    </table>\r\n\r\n    <table");

WriteLiteral(" id=\"main-table\"");

WriteLiteral(">\r\n        <tr>\r\n            <td");

WriteLiteral(" id=\"main-left\"");

WriteLiteral(">\r\n                <div");

WriteLiteral(" class=\"root\"");

WriteLiteral(">Konig Labs</div>\r\n                \r\n                \r\n");

WriteLiteral("                \r\n                <ul");

WriteLiteral(" class=\"mktree\"");

WriteLiteral(" id=\"modules-ul\"");

WriteLiteral(">\r\n");

WriteLiteral("                    ");

            
            #line 84 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
               Write(RenderModulesTree(new Sitemap(@Url.Content("~/Modules.sitemap")).SitemapList));

            
            #line default
            #line hidden
WriteLiteral("\r\n                </ul>\r\n                \r\n                <div");

WriteLiteral(" id=\"left-menu\"");

WriteLiteral(">\r\n                    <div");

WriteLiteral(" class=\"header\"");

WriteLiteral(">Функции</div>\r\n                    <div");

WriteLiteral(" class=\"left-function\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create("  href=\"", 5780), Tuple.Create("\"", 5840)
            
            #line 89 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 5788), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Admin.Utils.ClearApplicationCache())
            
            #line default
            #line hidden
, 5788), false)
);

WriteLiteral(">Очистить кэш</a></div>\r\n                    <div");

WriteLiteral(" class=\"left-function\"");

WriteLiteral("><a");

WriteLiteral(" target=\"_blank\"");

WriteLiteral(" href=\"/\"");

WriteLiteral(">На главную</a></div>\r\n                </div>\r\n                \r\n            </td" +
">\r\n            \r\n            <td");

WriteLiteral(" id=\"main-right\"");

WriteLiteral(">\r\n");

WriteLiteral("                ");

            
            #line 96 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
           Write(RenderBody());

            
            #line default
            #line hidden
WriteLiteral("\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>\r\n");

        }
    }
}
#pragma warning restore 1591