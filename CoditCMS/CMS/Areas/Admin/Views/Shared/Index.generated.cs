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
    using CMS.Mvc;
    using CMS.PagesSettings.Lists;
    using CMS.ViewModels;
    
    #line 1 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
    using DB.Entities;
    
    #line default
    #line hidden
    
    #line 2 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
    using Libs;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Shared/Index.cshtml")]
    public partial class _Areas_Admin_Views_Shared_Index_cshtml : CMS.Mvc.AdminViewPage<ListViewModel>
    {

#line 125 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
public System.Web.WebPages.HelperResult Indents(IEntity row, ColSettings col)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 126 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
 
    if (!col.Levels)
    {
        return;
    }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    <span");

WriteLiteralTo(__razor_helper_writer, " class=\"list-levels\"");

WriteLiteralTo(__razor_helper_writer, ">\r\n");


#line 132 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
        

#line default
#line hidden

#line 132 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
         for (var i = 1; i < ((IPlainTreeItem)row).Level; i++)
        {


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "            <span");

WriteLiteralTo(__razor_helper_writer, " class=\"list-level\"");

WriteLiteralTo(__razor_helper_writer, "></span>\r\n");


#line 135 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
        }


#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "    </span>\r\n");


#line 137 "..\..\Areas\Admin\Views\Shared\Index.cshtml"

    if (((IPlainTreeItem)row).HasChilds)
    {

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<span");

WriteLiteralTo(__razor_helper_writer, " class=\"list-parent\"");

WriteLiteralTo(__razor_helper_writer, "></span>");


#line 139 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                                      }
    else
    {

#line default
#line hidden
WriteLiteralTo(__razor_helper_writer, "<span");

WriteLiteralTo(__razor_helper_writer, " class=\"list-child\"");

WriteLiteralTo(__razor_helper_writer, "></span>");


#line 141 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                                     }


#line default
#line hidden
});

#line 142 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
}
#line default
#line hidden

#line 144 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
public System.Web.WebPages.HelperResult OutputCollection(IEnumerable<string> collection)
{
#line default
#line hidden
return new System.Web.WebPages.HelperResult(__razor_helper_writer => {

#line 145 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
 
    foreach (var item in collection)
    {
    

#line default
#line hidden

#line 148 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
WriteTo(__razor_helper_writer, Html.Raw(item));


#line default
#line hidden

#line 148 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                   
    }


#line default
#line hidden
});

#line 150 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
}
#line default
#line hidden

        public _Areas_Admin_Views_Shared_Index_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 5 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
  
    ViewBag.HtmlPageTitle = "OziCms.cms — список объектов";    
    Func<string, bool> allowed = role =>true;

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n<script");

WriteLiteral(" type=\"text/javascript\"");

WriteLiteral(">\r\n    _sorlListActionUrl = \'");

            
            #line 11 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                     Write(Url.Action(Constants.SortListAction));

            
            #line default
            #line hidden
WriteLiteral("\';\r\n</script>\r\n<script");

WriteLiteral(" type=\"text/ecmascript\"");

WriteAttribute("src", Tuple.Create(" src=\"", 319), Tuple.Create("\"", 378)
            
            #line 13 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
, Tuple.Create(Tuple.Create("", 325), Tuple.Create<System.Object, System.Int32>(Url.Content("~/Areas/Admin/Scripts/Default/List.js")
            
            #line default
            #line hidden
, 325), false)
);

WriteLiteral("></script>\r\n\r\n<div");

WriteLiteral(" class=\"global-actions\"");

WriteLiteral(">\r\n");

            
            #line 16 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
    
            
            #line default
            #line hidden
            
            #line 16 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
     foreach (GlobalActionSettings globalAction in Model.Settings.ListSettings.GlobalActions)
    {
        if (!string.IsNullOrEmpty(globalAction.Control))
        {
            Html.RenderPartial("GlobalActions/" + globalAction.Control, new ViewDataDictionary(Model) {{"Settings", Model.Settings}, {"globalActionSettings", globalAction}});
        }
        else
        {
            
            
            #line default
            #line hidden
            
            #line 24 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
       Write(Html.ActionLink(globalAction.Text, globalAction.Action, null, new { @class="global-action"}));

            
            #line default
            #line hidden
            
            #line 24 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                                                                                                         
        }
    }

            
            #line default
            #line hidden
WriteLiteral("</div>\r\n\r\n");

            
            #line 29 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
 using (Html.BeginForm(null, null, FormMethod.Post, new { id = "list-form" }))
{

            
            #line default
            #line hidden
WriteLiteral("    <input");

WriteLiteral(" type=\"hidden\"");

WriteLiteral(" name=\"page\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1060), Tuple.Create("\"", 1084)
            
            #line 31 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
, Tuple.Create(Tuple.Create("", 1068), Tuple.Create<System.Object, System.Int32>(Request["page"]
            
            #line default
            #line hidden
, 1068), false)
);

WriteLiteral(" />\r\n");

WriteLiteral("    <table");

WriteLiteral(" class=\"list-table\"");

WriteLiteral(">\r\n        <colgroup>\r\n            <col ");

            
            #line 34 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
            Write(Html.Raw("width=\"24\""));

            
            #line default
            #line hidden
WriteLiteral(" />\r\n");

WriteLiteral("            ");

            
            #line 35 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
       Write(OutputCollection(Model.Settings.ListSettings.Cols.Where(s => allowed(s.RoleName)).Select(col => string.Format("<col {0} />", col.Width > 0 ? string.Format("width={0}", col.Width) : string.Empty))));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("            ");

            
            #line 36 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
       Write(OutputCollection(Model.Settings.ListSettings.ListActions.Select(settings => "<col width=\"24\" />")));

            
            #line default
            #line hidden
WriteLiteral("\r\n        </colgroup>\r\n        <tr>\r\n            <th>№</th>\r\n");

WriteLiteral("            ");

            
            #line 40 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
       Write(OutputCollection(Model.Settings.ListSettings.Cols.Where(settings => settings != null && allowed(settings.RoleName)).Select(settings =>
                                {
                                    var value = settings.HeaderValue();
                                    return string.Join(string.Empty, "<th>", Html.DisplayFor(model => value, settings.HeaderControl, new { ColSettings = settings, Model.Settings }), "</th>");
                                })));

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 46 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
            
            
            #line default
            #line hidden
            
            #line 46 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
             foreach (var listAction in Model.Settings.ListSettings.ListActions.Where(settings => settings != null))
            {
                if (listAction.Control == "sort")
                {

            
            #line default
            #line hidden
WriteLiteral("                    <th><input");

WriteLiteral(" id=\"sort-button\"");

WriteLiteral(" type=\"button\"");

WriteLiteral(" value=\"Применить\"");

WriteLiteral(" /></th>\r\n");

            
            #line 51 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <th>&nbsp;</th>\r\n");

            
            #line 55 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                }
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n");

            
            #line 58 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 58 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
          
            var number = 0;
            var hasEdit = Model.Settings.ListSettings.ListActions.Any(a => a.Control == "edit");
        
            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 63 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 63 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
         foreach (IEntity row in Model.ListData)
        {
            var action = Html.Raw(hasEdit ? string.Format("target=\"{0}\"", Url.Action(Constants.EditView, new { id = row.Id })) : string.Empty);
            var selectedRow = (bool)TypeHelpers.GetPropertyValue(row, Model.Settings.ListSettings.SelectRowProperty, false);

            
            #line default
            #line hidden
WriteLiteral("            <tr ");

            
            #line 67 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
           Write(Html.ByCondition(selectedRow, "class=\"selected\""));

            
            #line default
            #line hidden
WriteLiteral(">\r\n\r\n                <td");

WriteLiteral(" class=\"number\"");

WriteLiteral(">");

            
            #line 69 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                               Write(++number + (Model.FilterParameters.StartPosition));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 70 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 70 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                 foreach (var col in Model.Settings.ListSettings.Cols.Where(s => allowed(s.RoleName)))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td ");

            
            #line 72 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                   Write(action);

            
            #line default
            #line hidden
WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 73 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                   Write(Indents(row, col));

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 74 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 74 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                          
                            var propValue = TypeHelpers.GetPropertyValue(row, col.Name);
                            if (col.Localizable)
                            {
                                var key = (Guid?)propValue;
                                propValue = Lp.GetMessage(key);
                            }
                        
            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("                        ");

            
            #line 82 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                   Write(Html.DisplayFor(model => propValue, col.Control, new { ColSettings = col, Row = row }));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 84 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");

            
            #line 87 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                
            
            #line default
            #line hidden
            
            #line 87 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                 foreach (var listAction in Model.Settings.ListSettings.ListActions)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"list-action\"");

WriteLiteral(">\r\n");

            
            #line 90 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                        
            
            #line default
            #line hidden
            
            #line 90 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                          Html.RenderPartial("ListActions/" + listAction.Control, row, new ViewDataDictionary { { "Settings", Model.Settings }, { "listActionSettings", listAction }, { "listViewModel", Model } });
            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>    \r\n");

            
            #line 92 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 94 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("\r\n");

            
            #line 96 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
        
            
            #line default
            #line hidden
            
            #line 96 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
         if (Model.FilterParameters.ItemsCount == 0)
        {
            var colspan = Model.Settings.ListSettings.Cols.Count() + Model.Settings.ListSettings.ListActions.Count();

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n                <td");

WriteAttribute("colspan", Tuple.Create(" colspan=\"", 4570), Tuple.Create("\"", 4594)
            
            #line 100 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
, Tuple.Create(Tuple.Create("", 4580), Tuple.Create<System.Object, System.Int32>(colspan + 1
            
            #line default
            #line hidden
, 4580), false)
);

WriteLiteral(">Список пуст</td>\r\n            </tr>\r\n");

            
            #line 102 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </table>\r\n");

            
            #line 104 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
}

            
            #line default
            #line hidden
            
            #line 105 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
 if (Model.FilterParameters.HasPager())
{
    var count = Model.FilterParameters.GetPagesCount();

            
            #line default
            #line hidden
WriteLiteral("    <div");

WriteLiteral(" id=\"pager\"");

WriteLiteral(">\r\n        Страница:\r\n");

            
            #line 110 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
		
            
            #line default
            #line hidden
            
            #line 110 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
   for (var i = 1; i <= count; i++)
  {
      if (Model.FilterParameters.Page == i)
      {

            
            #line default
            #line hidden
WriteLiteral("            <span>");

            
            #line 114 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
             Write(i);

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n");

            
            #line 115 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
      }
      else
      {

            
            #line default
            #line hidden
WriteLiteral("            <a");

WriteLiteral(" class=\"list-action\"");

WriteAttribute("href", Tuple.Create(" href=\"", 4992), Tuple.Create("\"", 5046)
            
            #line 118 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
, Tuple.Create(Tuple.Create("", 4999), Tuple.Create<System.Object, System.Int32>(Request.Url.SetParameter("page", i.ToString())
            
            #line default
            #line hidden
, 4999), false)
);

WriteLiteral(">");

            
            #line 118 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
                                                                                     Write(i);

            
            #line default
            #line hidden
WriteLiteral("</a>\r\n");

            
            #line 119 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
      }
  }

            
            #line default
            #line hidden
WriteLiteral("\r\n    </div>\r\n");

            
            #line 123 "..\..\Areas\Admin\Views\Shared\Index.cshtml"
}

            
            #line default
            #line hidden
WriteLiteral("\r\n");

WriteLiteral("\r\n");

        }
    }
}
#pragma warning restore 1591
