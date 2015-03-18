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
      
        var mediaRoot = "http://localhost:8000";/*"http://kobyb1988.github.io/CoditCMS/CoditCMS/CMS"*/
    
            
            #line default
            #line hidden
WriteLiteral("\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 253), Tuple.Create("\"", 356)
            
            #line 12 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 260), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 260), false)
, Tuple.Create(Tuple.Create("", 270), Tuple.Create("/Areas/Admin/Scripts/Default/jqueryUI/development-bundle/themes/base/jquery.ui.al" +
"l.css", 270), true)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 404), Tuple.Create("\"", 479)
            
            #line 13 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 411), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 411), false)
, Tuple.Create(Tuple.Create("", 421), Tuple.Create("/Areas/Admin/Styles/Default/jquery-ui-timepicker-addon.css", 421), true)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 511), Tuple.Create("\"", 585)
            
            #line 14 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 518), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 518), false)
, Tuple.Create(Tuple.Create("", 528), Tuple.Create("/Areas/Admin/Styles/Default/fileuploader/fineuploader.css", 528), true)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 617), Tuple.Create("\"", 679)
            
            #line 15 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 624), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 624), false)
, Tuple.Create(Tuple.Create("", 634), Tuple.Create("/Areas/Admin/Styles/Default/toastr/toastr.css", 634), true)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 711), Tuple.Create("\"", 784)
            
            #line 16 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 718), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 718), false)
, Tuple.Create(Tuple.Create("", 728), Tuple.Create("/Areas/Admin/Styles/Default/toastr/toastr-responsive.css", 728), true)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" />\r\n    <link");

WriteAttribute("href", Tuple.Create(" href=\"", 816), Tuple.Create("\"", 872)
            
            #line 17 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 823), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 823), false)
, Tuple.Create(Tuple.Create("", 833), Tuple.Create("/Areas/Admin/Styles/Default/Default.css", 833), true)
);

WriteLiteral(" rel=\"stylesheet\"");

WriteLiteral(" type=\"text/css\"");

WriteLiteral(" />\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 922), Tuple.Create("\"", 986)
            
            #line 18 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 928), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 928), false)
, Tuple.Create(Tuple.Create("", 938), Tuple.Create("/Areas/Admin/Scripts/Default/jquery-1.7.1.min.js", 938), true)
);

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1033), Tuple.Create("\"", 1141)
            
            #line 19 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 1039), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 1039), false)
, Tuple.Create(Tuple.Create("", 1049), Tuple.Create("/Areas/Admin/Scripts/Default/jqueryUI/development-bundle/ui/minified/jquery-ui.cu" +
"stom.min.js", 1049), true)
);

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1188), Tuple.Create("\"", 1295)
            
            #line 20 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 1194), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 1194), false)
, Tuple.Create(Tuple.Create("", 1204), Tuple.Create("/Areas/Admin/Scripts/Default/jqueryUI/development-bundle/ui/i18n/jquery.ui.datepi" +
"cker-ru.js", 1204), true)
);

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1342), Tuple.Create("\"", 1420)
            
            #line 21 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 1348), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 1348), false)
, Tuple.Create(Tuple.Create("", 1358), Tuple.Create("/Areas/Admin/Scripts/Default/drag/jquery.dragsort-0.5.1.min.js", 1358), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1444), Tuple.Create("\"", 1509)
            
            #line 22 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 1450), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 1450), false)
, Tuple.Create(Tuple.Create("", 1460), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/util.js", 1460), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1533), Tuple.Create("\"", 1600)
            
            #line 23 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 1539), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 1539), false)
, Tuple.Create(Tuple.Create("", 1549), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/button.js", 1549), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1624), Tuple.Create("\"", 1691)
            
            #line 24 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 1630), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 1630), false)
, Tuple.Create(Tuple.Create("", 1640), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/header.js", 1640), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1715), Tuple.Create("\"", 1782)
            
            #line 25 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 1721), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 1721), false)
, Tuple.Create(Tuple.Create("", 1731), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/header.js", 1731), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1806), Tuple.Create("\"", 1879)
            
            #line 26 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 1812), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 1812), false)
, Tuple.Create(Tuple.Create("", 1822), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/handler.base.js", 1822), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 1903), Tuple.Create("\"", 1976)
            
            #line 27 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 1909), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 1909), false)
, Tuple.Create(Tuple.Create("", 1919), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/handler.form.js", 1919), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2000), Tuple.Create("\"", 2072)
            
            #line 28 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2006), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2006), false)
, Tuple.Create(Tuple.Create("", 2016), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/handler.xhr.js", 2016), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2096), Tuple.Create("\"", 2171)
            
            #line 29 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2102), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2102), false)
, Tuple.Create(Tuple.Create("", 2112), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/uploader.basic.js", 2112), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2195), Tuple.Create("\"", 2259)
            
            #line 30 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2201), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2201), false)
, Tuple.Create(Tuple.Create("", 2211), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/dnd.js", 2211), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2283), Tuple.Create("\"", 2352)
            
            #line 31 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2289), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2289), false)
, Tuple.Create(Tuple.Create("", 2299), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/uploader.js", 2299), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2376), Tuple.Create("\"", 2450)
            
            #line 32 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2382), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2382), false)
, Tuple.Create(Tuple.Create("", 2392), Tuple.Create("/Areas/Admin/Scripts/Default/fileuploader/jquery-plugin.js", 2392), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2474), Tuple.Create("\"", 2556)
            
            #line 33 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2480), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2480), false)
, Tuple.Create(Tuple.Create("", 2490), Tuple.Create("/Areas/Admin/Scripts/Default/jqueryUI/js/jquery-ui-sliderAccess.js", 2490), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2580), Tuple.Create("\"", 2666)
            
            #line 34 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2586), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2586), false)
, Tuple.Create(Tuple.Create("", 2596), Tuple.Create("/Areas/Admin/Scripts/Default/jqueryUI/js/jquery-ui-timepicker-addon.js", 2596), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2690), Tuple.Create("\"", 2766)
            
            #line 35 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2696), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2696), false)
, Tuple.Create(Tuple.Create("", 2706), Tuple.Create("/Areas/Admin/Scripts/Default/jqueryUI/js/ui.datepicker-ru.js", 2706), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2790), Tuple.Create("\"", 2873)
            
            #line 36 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2796), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2796), false)
, Tuple.Create(Tuple.Create("", 2806), Tuple.Create("/Areas/Admin/Scripts/Default/jqueryUI/js/jquery-ui-timepicker-ru.js", 2806), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2897), Tuple.Create("\"", 2968)
            
            #line 37 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2903), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2903), false)
, Tuple.Create(Tuple.Create("", 2913), Tuple.Create("/Areas/Admin/Scripts/Default/knockout/knockout-2.2.1.js", 2913), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 2992), Tuple.Create("\"", 3066)
            
            #line 38 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 2998), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 2998), false)
, Tuple.Create(Tuple.Create("", 3008), Tuple.Create("/Areas/Admin/Scripts/Default/knockout/knockout-sortable.js", 3008), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3090), Tuple.Create("\"", 3151)
            
            #line 39 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 3096), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 3096), false)
, Tuple.Create(Tuple.Create("", 3106), Tuple.Create("/Areas/Admin/Scripts/Default/toastr/toastr.js", 3106), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3175), Tuple.Create("\"", 3234)
            
            #line 40 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 3181), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 3181), false)
, Tuple.Create(Tuple.Create("", 3191), Tuple.Create("/Areas/Admin/Scripts/Default/autoNumeric.js", 3191), true)
);

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3258), Tuple.Create("\"", 3313)
            
            #line 41 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 3264), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 3264), false)
, Tuple.Create(Tuple.Create("", 3274), Tuple.Create("/Areas/Admin/Scripts/Default/Default.js", 3274), true)
);

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3360), Tuple.Create("\"", 3414)
            
            #line 42 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 3366), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 3366), false)
, Tuple.Create(Tuple.Create("", 3376), Tuple.Create("/Areas/Admin/Scripts/Default/Mktree.js", 3376), true)
);

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3461), Tuple.Create("\"", 3510)
            
            #line 43 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 3467), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 3467), false)
, Tuple.Create(Tuple.Create("", 3477), Tuple.Create("/Areas/Admin/Ckeditor/ckeditor.js", 3477), true)
);

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3557), Tuple.Create("\"", 3615)
            
            #line 44 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 3563), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 3563), false)
, Tuple.Create(Tuple.Create("", 3573), Tuple.Create("/Areas/Admin/Scripts/Default/Myckconfig.js", 3573), true)
);

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral("></script>\r\n    <script");

WriteAttribute("src", Tuple.Create(" src=\"", 3662), Tuple.Create("\"", 3721)
            
            #line 45 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 3668), Tuple.Create<System.Object, System.Int32>(mediaRoot
            
            #line default
            #line hidden
, 3668), false)
, Tuple.Create(Tuple.Create("", 3678), Tuple.Create("/Areas/Admin/Scripts/Default/files-logic.js", 3678), true)
);

WriteLiteral("></script>\r\n</head>\r\n\r\n<body>\r\n\r\n    <table");

WriteLiteral(" id=\"logo-table\"");

WriteLiteral(">\r\n        <tr>\r\n            <td");

WriteLiteral(" id=\"logo-left\"");

WriteLiteral("><div");

WriteLiteral(" id=\"logo\"");

WriteLiteral("><img");

WriteAttribute("src", Tuple.Create(" src=\"", 3848), Tuple.Create("\"", 3918)
            
            #line 52 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 3854), Tuple.Create<System.Object, System.Int32>(Url.Content(mediaRoot + "/Areas/Admin/Images/Default/logo.gif")
            
            #line default
            #line hidden
, 3854), false)
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

WriteAttribute("href", Tuple.Create("  href=\"", 5728), Tuple.Create("\"", 5788)
            
            #line 89 "..\..\Areas\Admin\Views\Shared\_Main.cshtml"
, Tuple.Create(Tuple.Create("", 5736), Tuple.Create<System.Object, System.Int32>(Url.Action(MVC.Admin.Utils.ClearApplicationCache())
            
            #line default
            #line hidden
, 5736), false)
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
