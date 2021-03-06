#pragma checksum "C:\Development_local\CoreWebApp\CoreWebApp\CoreWebApp\Views\Components\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "207b7fd7958cce4b6c4bd508def544477c2f4c6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Components_Home_Index), @"mvc.1.0.view", @"/Views/Components/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Components/Home/Index.cshtml", typeof(AspNetCore.Views_Components_Home_Index))]
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
#line 1 "C:\Development_local\CoreWebApp\CoreWebApp\CoreWebApp\Views\_ViewImports.cshtml"
using CoreWebApp;

#line default
#line hidden
#line 2 "C:\Development_local\CoreWebApp\CoreWebApp\CoreWebApp\Views\_ViewImports.cshtml"
using CoreWebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"207b7fd7958cce4b6c4bd508def544477c2f4c6c", @"/Views/Components/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce38d043670142d3eeab9e7775e3d99906b8a926", @"/Views/_ViewImports.cshtml")]
    public class Views_Components_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Habufa_Extranet.Models.ViewModels.HomeIndexViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Development_local\CoreWebApp\CoreWebApp\CoreWebApp\Views\Components\Home\Index.cshtml"
  
    var jsonItems = Newtonsoft.Json.JsonConvert.SerializeObject(Model.Newsletters);

#line default
#line hidden
            BeginContext(153, 90, true);
            WriteLiteral("\r\n<template id=\"HomeIndex\">\r\n    <v-container grid-list-md>\r\n        <v-layout row wrap>\r\n");
            EndContext();
#line 9 "C:\Development_local\CoreWebApp\CoreWebApp\CoreWebApp\Views\Components\Home\Index.cshtml"
             if (Model.Notifications.Any())
            {

#line default
#line hidden
            BeginContext(303, 1424, true);
            WriteLiteral(@"                <v-flex md12 lg5>
                    <material-card color=""orange""
                                   title=""Notifications""
                                   text=""Notifications"">
                        <v-expansion-panel-content v-for=""(item,i) in 5""
                                                   :key=""i"">
                            <div slot=""header"">Item</div>
                            <v-card>
                                <v-card-text>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</v-card-text>
                            </v-card>
                        </v-expansion-panel-content>
                        <v-data-table :items="""" hide-actions>
                            <template slot=""items"" slot-scope=""{index, item}"">
                                <td>{{ item.concept }}</td>
");
            WriteLiteral(@"                                <td class=""text-xs-right"">{{ item.MessageNL }}</td>
                                <td class=""text-xs-right"">{{ item.TitleNL }}</td>
                                <td class=""text-xs-right"">{{ item.StartDate }}</td>
                            </template>
                        </v-data-table>
                    </material-card>
                </v-flex>
");
            EndContext();
#line 32 "C:\Development_local\CoreWebApp\CoreWebApp\CoreWebApp\Views\Components\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1742, 2370, true);
            WriteLiteral(@"            <v-flex md12 lg12 xl6>
                <material-card color=""blue""
                               title=""Comments""
                               text=""Comments submitted by users"">
                    Empty
                </material-card>

            </v-flex>

            <v-flex md12 lg12 xl6>
                <material-card color=""red""
                               title=""Newsletter""
                               text=""Recent newsletters"">
                    <v-data-table :headers=""headers""
                                  :items=""items"" hide-actions>
                        <template slot=""items"" slot-scope=""props"">
                            <row>
                                <cell>{{props.item.WeekNumber}}</cell>
                                <cell>{{props.item.Title}}</cell>
                                <cell>{{props.item.Concept}}</cell>
                                <cell>{{props.item.Country}}</cell>
                                <cell>{{props.item");
            WriteLiteral(@".Language}}</cell>
                                <cell class=""justify-center"">
                                    <v-icon small class=""mr-2"" v-on:click=""openNewsletter(props.item.Id)"">
                                        fa-eye
                                    </v-icon>
                                </cell>
                            </row>
                        </template>
                    </v-data-table>
                    <v-btn href=""/Newsletter/"">View all</v-btn>
                </material-card>
            </v-flex>

        </v-layout>
    </v-container>
</template>

<script>
var homeindex = Vue.component('home-index',
    {
        template: '#HomeIndex',
        data: function () {
            return {
                loading: false,
                rowsPerPage:[10, 25, 50, { ""text"": ""$vuetify.dataIterator.rowsPerPageAll"", ""value"": -1 }],
                headers:  [
                    {text: 'Week Number', align: 'left', value: 'WeekNumber'},
           ");
            WriteLiteral(@"         { text: 'Title', value: 'Title' },
                    { text: 'Concept', value: 'Concept' },
                    { text: 'Country', value: 'Country' },
                    { text: 'Language', value: 'Language' },
                    { text: 'Actions', value: '' }
                ],
                items: ");
            EndContext();
            BeginContext(4113, 19, false);
#line 87 "C:\Development_local\CoreWebApp\CoreWebApp\CoreWebApp\Views\Components\Home\Index.cshtml"
                  Write(Html.Raw(jsonItems));

#line default
#line hidden
            EndContext();
            BeginContext(4132, 240, true);
            WriteLiteral("\r\n            }\r\n        },\r\n        methods: {\r\n            openNewsletter: function (id) {\r\n                console.log(id);\r\n                window.location.href = \"/Newsletter/View/\"+id;\r\n            }\r\n        }\r\n\r\n    });\r\n</script>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Habufa_Extranet.Models.ViewModels.HomeIndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
