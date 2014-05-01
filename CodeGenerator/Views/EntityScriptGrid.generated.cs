﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Serenity.CodeGenerator.Views
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    public partial class EntityScriptGrid : RazorGenerator.Templating.RazorTemplateBase
    {
#line hidden

        #line 2 "..\..\Views\EntityScriptGrid.cshtml"
 public dynamic Model { get; set; } 
        #line default
        #line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");



            
            #line 2 "..\..\Views\EntityScriptGrid.cshtml"
                                                   
    var dotModule = Model.Module == null ? "" : ("." + Model.Module);
    var moduleDot = Model.Module == null ? "" : (Model.Module + ".");
    var moduleSlash = Model.Module == null ? "" : (Model.Module + "/");


            
            #line default
            #line hidden
WriteLiteral("namespace ");


            
            #line 7 "..\..\Views\EntityScriptGrid.cshtml"
      Write(Model.RootNamespace);

            
            #line default
            #line hidden

            
            #line 7 "..\..\Views\EntityScriptGrid.cshtml"
                            Write(dotModule);

            
            #line default
            #line hidden
WriteLiteral("\r\n{\r\n    using jQueryApi;\r\n    using Serenity;\r\n    using System;\r\n    using Syst" +
"em.Collections.Generic;\r\n    using System.Runtime.CompilerServices;\r\n\r\n    [IdPr" +
"operty(\"");


            
            #line 15 "..\..\Views\EntityScriptGrid.cshtml"
            Write(Model.Identity);

            
            #line default
            #line hidden

            
            #line 15 "..\..\Views\EntityScriptGrid.cshtml"
                                WriteLiteral("\")");

            
            #line default
            #line hidden
            
            #line 15 "..\..\Views\EntityScriptGrid.cshtml"
                                   if (Model.NameField != null){
            
            #line default
            #line hidden
WriteLiteral(", NameProperty(\"");


            
            #line 15 "..\..\Views\EntityScriptGrid.cshtml"
                                                                                 Write(Model.NameField);

            
            #line default
            #line hidden
WriteLiteral("\")");


            
            #line 15 "..\..\Views\EntityScriptGrid.cshtml"
                                                                                                               }
            
            #line default
            #line hidden

            
            #line 15 "..\..\Views\EntityScriptGrid.cshtml"
                                                                                                                 if (Model.IsActiveField != null) {
            
            #line default
            #line hidden
WriteLiteral(", IsActiveProperty(\"");


            
            #line 15 "..\..\Views\EntityScriptGrid.cshtml"
                                                                                                                                                                         Write(Model.IsActiveField);

            
            #line default
            #line hidden
WriteLiteral("\")");


            
            #line 15 "..\..\Views\EntityScriptGrid.cshtml"
                                                                                                                                                                                                            }
            
            #line default
            #line hidden
WriteLiteral("]\r\n    [DialogType(typeof(");


            
            #line 16 "..\..\Views\EntityScriptGrid.cshtml"
                   Write(Model.ClassName);

            
            #line default
            #line hidden
WriteLiteral("Dialog)), LocalTextPrefix(\"");


            
            #line 16 "..\..\Views\EntityScriptGrid.cshtml"
                                                                Write(moduleDot);

            
            #line default
            #line hidden

            
            #line 16 "..\..\Views\EntityScriptGrid.cshtml"
                                                                            Write(Model.ClassName);

            
            #line default
            #line hidden
WriteLiteral("\"), Service(\"");


            
            #line 16 "..\..\Views\EntityScriptGrid.cshtml"
                                                                                                           Write(moduleSlash);

            
            #line default
            #line hidden

            
            #line 16 "..\..\Views\EntityScriptGrid.cshtml"
                                                                                                                         Write(Model.ClassName);

            
            #line default
            #line hidden
WriteLiteral("\")]\r\n    public class ");


            
            #line 17 "..\..\Views\EntityScriptGrid.cshtml"
             Write(Model.ClassName);

            
            #line default
            #line hidden
WriteLiteral("Grid : EntityGrid<");


            
            #line 17 "..\..\Views\EntityScriptGrid.cshtml"
                                                 Write(Model.RowClassName);

            
            #line default
            #line hidden
WriteLiteral(">\r\n    {\r\n        public ");


            
            #line 19 "..\..\Views\EntityScriptGrid.cshtml"
           Write(Model.ClassName);

            
            #line default
            #line hidden
WriteLiteral("Grid(jQueryObject container)\r\n            : base(container)\r\n        {\r\n        }" +
"\r\n\r\n        protected override List<SlickColumn> GetColumns()\r\n        {\r\n      " +
"      var columns = base.GetColumns();\r\n\r\n            columns.Add(new SlickColum" +
"n { Field = \"");


            
            #line 28 "..\..\Views\EntityScriptGrid.cshtml"
                                               Write(Model.Identity);

            
            #line default
            #line hidden

            
            #line 28 "..\..\Views\EntityScriptGrid.cshtml"
                                                                    WriteLiteral("\", Width = 55, CssClass = \"align-right\", Title = Q.Text(\"Db.Shared.RecordId\") });" +
"");

            
            #line default
            #line hidden
            
            #line 28 "..\..\Views\EntityScriptGrid.cshtml"
                                                                                                                                                      if (Model.NameField != null) {
            
            #line default
            #line hidden
WriteLiteral("\r\n            columns.Add(new SlickColumn { Field = \"");


            
            #line 29 "..\..\Views\EntityScriptGrid.cshtml"
                                               Write(Model.NameField);

            
            #line default
            #line hidden
WriteLiteral("\", Width = 200, Format = ItemLink() });");


            
            #line 29 "..\..\Views\EntityScriptGrid.cshtml"
                                                                                                                   }

            
            #line default
            #line hidden

            
            #line 30 "..\..\Views\EntityScriptGrid.cshtml"
 foreach (var x in Model.Fields) { if (x.Ident != Model.NameField && x.Ident != Model.Identity) {
            
            #line default
            #line hidden
WriteLiteral("\r\n            columns.Add(new SlickColumn { Field = \"");


            
            #line 31 "..\..\Views\EntityScriptGrid.cshtml"
                                               Write(x.Ident);

            
            #line default
            #line hidden
WriteLiteral("\", Width = 80 });");


            
            #line 31 "..\..\Views\EntityScriptGrid.cshtml"
                                                                                     }}

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n            return columns;\r\n        }\r\n    }\r\n\r\n    public partial class ");


            
            #line 38 "..\..\Views\EntityScriptGrid.cshtml"
                     Write(Model.ClassName);

            
            #line default
            #line hidden
WriteLiteral("Row\r\n    {\r\n    }\r\n}");


        }
    }
}
#pragma warning restore 1591