﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
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
    
    #line 6 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
    using System.Web.Mvc;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
    using System.Web.Mvc.Ajax;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
    using System.Web.Mvc.Html;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
    using System.Web.Routing;
    
    #line default
    #line hidden
    using System.Web.Security;
    using System.Web.UI;
    using System.Web.WebPages;
    
    #line 2 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
    using NewLife;
    
    #line default
    #line hidden
    using NewLife.Cube;
    using NewLife.Reflection;
    
    #line 3 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
    using NewLife.Web;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
    using XCode;
    
    #line default
    #line hidden
    
    #line 5 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
    using XCode.Configuration;
    
    #line default
    #line hidden
    using XCode.Membership;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    [System.Web.WebPages.PageVirtualPathAttribute("~/Areas/Admin/Views/Role/_List_Data.cshtml")]
    public partial class _Areas_Admin_Views_Role__List_Data_cshtml : System.Web.Mvc.WebViewPage<IList<XCode.Membership.Role>>
    {
        public _Areas_Admin_Views_Role__List_Data_cshtml()
        {
        }
        public override void Execute()
        {
            
            #line 10 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
  
    var fact = ViewBag.Factory as IEntityOperate;
    var page = ViewBag.Page as Pager;
    var fields = ViewBag.Fields as IList<FieldItem>;
    var set = ViewBag.PageSetting as PageSetting;
    var provider = ManageProvider.Provider;

            
            #line default
            #line hidden
WriteLiteral("\r\n<table");

WriteLiteral(" class=\"table table-bordered table-hover table-striped table-condensed\"");

WriteLiteral(">\r\n    <thead>\r\n        <tr>\r\n");

            
            #line 20 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 20 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
             if (set.EnableSelect)
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"width:10px;\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" id=\"chkAll\"");

WriteLiteral(" title=\"全选\"");

WriteLiteral(" /></th>\r\n");

            
            #line 23 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 802), Tuple.Create("\"", 841)
            
            #line 24 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 809), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("ID"))
            
            #line default
            #line hidden
, 809), false)
);

WriteLiteral(">编号</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 894), Tuple.Create("\"", 935)
            
            #line 25 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 901), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Name"))
            
            #line default
            #line hidden
, 901), false)
);

WriteLiteral(">名称</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" title=\"系统。系统角色用于业务系统开发使用，禁止修改名称或删除\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1024), Tuple.Create("\"", 1069)
            
            #line 26 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
 , Tuple.Create(Tuple.Create("", 1031), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("IsSystem"))
            
            #line default
            #line hidden
, 1031), false)
);

WriteLiteral(">系统</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1122), Tuple.Create("\"", 1165)
            
            #line 27 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1129), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("Remark"))
            
            #line default
            #line hidden
, 1129), false)
);

WriteLiteral(">说明</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1218), Tuple.Create("\"", 1267)
            
            #line 28 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1225), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("UpdateUserID"))
            
            #line default
            #line hidden
, 1225), false)
);

WriteLiteral(">更新用户</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1322), Tuple.Create("\"", 1367)
            
            #line 29 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1329), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("UpdateIP"))
            
            #line default
            #line hidden
, 1329), false)
);

WriteLiteral(">更新地址</a></th>\r\n            <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(" style=\"min-width:134px;\"");

WriteLiteral("><a");

WriteAttribute("href", Tuple.Create(" href=\"", 1447), Tuple.Create("\"", 1494)
            
            #line 30 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 1454), Tuple.Create<System.Object, System.Int32>(Html.Raw(page.GetSortUrl("UpdateTime"))
            
            #line default
            #line hidden
, 1454), false)
);

WriteLiteral(">更新时间</a></th>\r\n");

            
            #line 31 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
            
            
            #line default
            #line hidden
            
            #line 31 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
             if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
            {

            
            #line default
            #line hidden
WriteLiteral("                <th");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">操作</th>\r\n");

            
            #line 34 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");

            
            #line 38 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
        
            
            #line default
            #line hidden
            
            #line 38 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
         foreach (var entity in Model)
        {

            
            #line default
            #line hidden
WriteLiteral("            <tr>\r\n");

            
            #line 41 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 41 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
                 if (set.EnableSelect)
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral("><input");

WriteLiteral(" type=\"checkbox\"");

WriteLiteral(" name=\"keys\"");

WriteAttribute("value", Tuple.Create(" value=\"", 1938), Tuple.Create("\"", 1956)
            
            #line 43 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
      , Tuple.Create(Tuple.Create("", 1946), Tuple.Create<System.Object, System.Int32>(entity.ID
            
            #line default
            #line hidden
, 1946), false)
);

WriteLiteral(" /></td>\r\n");

            
            #line 44 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">");

            
            #line 45 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
                                   Write(entity.ID);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 46 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
               Write(entity.Name);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n                    <i");

WriteAttribute("class", Tuple.Create(" class=\"", 2146), Tuple.Create("\"", 2210)
, Tuple.Create(Tuple.Create("", 2154), Tuple.Create("glyphicon", 2154), true)
, Tuple.Create(Tuple.Create(" ", 2163), Tuple.Create("glyphicon-", 2164), true)
            
            #line 48 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 2174), Tuple.Create<System.Object, System.Int32>(entity.IsSystem ? "ok" : "remove"
            
            #line default
            #line hidden
, 2174), false)
);

WriteAttribute("style", Tuple.Create(" style=\"", 2211), Tuple.Create("\"", 2263)
, Tuple.Create(Tuple.Create("", 2219), Tuple.Create("color:", 2219), true)
            
            #line 48 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
                      , Tuple.Create(Tuple.Create(" ", 2225), Tuple.Create<System.Object, System.Int32>(entity.IsSystem ? "green" : "red"
            
            #line default
            #line hidden
, 2226), false)
, Tuple.Create(Tuple.Create("", 2262), Tuple.Create(";", 2262), true)
);

WriteLiteral("></i>\r\n                </td>\r\n                <td>");

            
            #line 50 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
               Write(entity.Remark);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteLiteral(" class=\"text-right\"");

WriteLiteral(">");

            
            #line 51 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
                                  Write(provider.FindByID(entity.UpdateUserID));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td");

WriteAttribute("title", Tuple.Create(" title=\"", 2439), Tuple.Create("\"", 2477)
            
            #line 52 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
, Tuple.Create(Tuple.Create("", 2447), Tuple.Create<System.Object, System.Int32>(entity.UpdateIP.IPToAddress()
            
            #line default
            #line hidden
, 2447), false)
);

WriteLiteral(">");

            
            #line 52 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
                                                      Write(entity.UpdateIP);

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n                <td>");

            
            #line 53 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
               Write(entity.UpdateTime.ToFullString(""));

            
            #line default
            #line hidden
WriteLiteral("</td>\r\n");

            
            #line 54 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
                
            
            #line default
            #line hidden
            
            #line 54 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
                 if (this.Has(PermissionFlags.Detail, PermissionFlags.Update, PermissionFlags.Delete))
                {

            
            #line default
            #line hidden
WriteLiteral("                    <td");

WriteLiteral(" class=\"text-center\"");

WriteLiteral(">\r\n");

WriteLiteral("                        ");

            
            #line 57 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
                   Write(Html.Partial("_List_Data_Action", (Object)entity));

            
            #line default
            #line hidden
WriteLiteral("\r\n                    </td>\r\n");

            
            #line 59 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </tr>\r\n");

            
            #line 61 "..\..\Areas\Admin\Views\Role\_List_Data.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </tbody>\r\n</table>");

        }
    }
}
#pragma warning restore 1591
