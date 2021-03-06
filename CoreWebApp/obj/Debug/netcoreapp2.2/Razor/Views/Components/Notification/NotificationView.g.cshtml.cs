#pragma checksum "C:\Development_local\CoreWebApp\CoreWebApp\CoreWebApp\Views\Components\Notification\NotificationView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cf420eaa72d73161b4ad5320cfd8882d5f72e92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Components_Notification_NotificationView), @"mvc.1.0.view", @"/Views/Components/Notification/NotificationView.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Components/Notification/NotificationView.cshtml", typeof(AspNetCore.Views_Components_Notification_NotificationView))]
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
#line 1 "C:\Development_local\CoreWebApp\CoreWebApp\CoreWebApp\Views\Components\Notification\NotificationView.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Development_local\CoreWebApp\CoreWebApp\CoreWebApp\Views\Components\Notification\NotificationView.cshtml"
using Microsoft.SqlServer.Server;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cf420eaa72d73161b4ad5320cfd8882d5f72e92", @"/Views/Components/Notification/NotificationView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce38d043670142d3eeab9e7775e3d99906b8a926", @"/Views/_ViewImports.cshtml")]
    public class Views_Components_Notification_NotificationView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataGridViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "C:\Development_local\CoreWebApp\CoreWebApp\CoreWebApp\Views\Components\Notification\NotificationView.cshtml"
  
    var jsonFields = Newtonsoft.Json.JsonConvert.SerializeObject(Model.Headers);
    var jsonItems = Newtonsoft.Json.JsonConvert.SerializeObject(Model.Items);
    bool isEditor = User.IsInRole("Admin");

#line default
#line hidden
            BeginContext(312, 1131, true);
            WriteLiteral(@"
<template id=""DataGridNotification"">
    <div>
        <v-text-field v-model=""search""
                      append-icon=""search""
                      label=""Search""
                      single-line
                      hide-details></v-text-field>

        <v-data-table :headers=""headers""
                      :items=""items""
                      :loading=""loading""
                      :rows-per-page-items=""rowsPerPage""
                      :search=""search""
                      class=""elevation-1"">
            <v-progress-linear slot=""progress"" color=""blue"" indeterminate></v-progress-linear>
            <v-spacer></v-spacer>
            <template slot=""items"" slot-scope=""props"">
                <row>
                    <cell>{{props.item.Name}}</cell>

                    <cell>{{props.item.Concept}}</cell>
                    <cell>{{props.item.StartDate}}</cell>
                    <cell>{{props.item.EndDate}}</cell>
                    <cell>{{props.item.Country}}</cell>
  ");
            WriteLiteral("                  <cell>{{props.item.Language}}</cell>\r\n                    <cell class=\"justify-center\">\r\n");
            EndContext();
#line 36 "C:\Development_local\CoreWebApp\CoreWebApp\CoreWebApp\Views\Components\Notification\NotificationView.cshtml"
                         if (isEditor)
                        {

#line default
#line hidden
            BeginContext(1510, 266, true);
            WriteLiteral(@"                            <v-btn flat icon v-on:click=""editNotification(props.item.Id)"">
                                <v-icon small>
                                    fa-edit
                                </v-icon>
                            </v-btn>
");
            EndContext();
#line 43 "C:\Development_local\CoreWebApp\CoreWebApp\CoreWebApp\Views\Components\Notification\NotificationView.cshtml"
                        }

#line default
#line hidden
            BeginContext(1803, 1190, true);
            WriteLiteral(@"                    </cell>
                </row>
            </template>
            <template slot=""no-data"">
                <v-alert :value=""!loading"" color=""error"" icon=""warning"">
                    Sorry, nothing to display here
                </v-alert>
            </template>
        </v-data-table>
    </div>
</template>

<script>
    var dataGridDemo = Vue.component('datagridnotification',
    {
        template: '#DataGridNotification',
        data: function () {
            return {
                loading: false,
                search: '',
                rowsPerPage:[10, 25, 50, { ""text"": ""$vuetify.dataIterator.rowsPerPageAll"", ""value"": -1 }],
                headers:  [
                    { text: 'name', align: 'left', value: 'name'},
                    { text: 'concept', value: 'concept' },
                    { text: 'StartDate', value: 'StartDate' },
                    { text: 'EndDate', value: 'EndDate' },
                    { text: 'Language', value: 'Lan");
            WriteLiteral("guage\' },\r\n                    { text: \'Country\', value: \'Country\' },\r\n                    { text: \'Actions\', value: \'\' }\r\n                ],\r\n                items: ");
            EndContext();
            BeginContext(2994, 19, false);
#line 74 "C:\Development_local\CoreWebApp\CoreWebApp\CoreWebApp\Views\Components\Notification\NotificationView.cshtml"
                  Write(Html.Raw(jsonItems));

#line default
#line hidden
            EndContext();
            BeginContext(3013, 734, true);
            WriteLiteral(@",
                customFilter: {
                    type: Function,
                    default: (items, search, filter) => {
                        search = search.toString().toLowerCase()
                        return items.filter(i => (
                            Object.keys(i).some(j => filter(i[j], search))
                        ))
                    }
                },
            }
        },
        methods: {
            openNotification: function (id) {
                window.location.href = ""/Notification/View/""+id;
            },
            editNotification: function (id) {
                window.location.href = ""/Notification/Edit/""+id;
            }
        }

    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataGridViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
