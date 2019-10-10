#pragma checksum "C:\Development_local\CoreWebApp\CoreWebApp\CoreWebApp\Views\Components\tinymce_editor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a91be8aa8f9de6c54be379cebfd5415c13ceb911"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Components_tinymce_editor), @"mvc.1.0.view", @"/Views/Components/tinymce_editor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Components/tinymce_editor.cshtml", typeof(AspNetCore.Views_Components_tinymce_editor))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a91be8aa8f9de6c54be379cebfd5415c13ceb911", @"/Views/Components/tinymce_editor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce38d043670142d3eeab9e7775e3d99906b8a926", @"/Views/_ViewImports.cshtml")]
    public class Views_Components_tinymce_editor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 2085, true);
            WriteLiteral(@"
<template id=""TinyMceEditor"">
    <v-text-field id=""tinymce-editor""
                  :value=""value""
                  class=""form-control textarea-editor""
                  ref=""icontent"">

    </v-text-field>
</template>

<script>
    var tinymcevue = Vue.component('tinymce-editor',
        {
            template: '#TinyMceEditor',
            data: function () {
                return {
                }
            },
            props: {

                value: {
                    type: String,
                    default: ''
                },
                content: {
                    type: String,
                    default: ''
                }
            },
            mounted: function () {
                this.initialize();
            },
            methods: {
                initialize: function () {
                    var self = this;
                    tinymce.init({
                        selector: '#tinymce-editor', // change this value accordi");
            WriteLiteral(@"ng to your HTML
                        branding: false,
                        menubar: false,
                        height: ""480"",
                        paste_as_text: true,
                        entity_encoding: ""named"",
                        plugins: tinyMCEPlugins,
                        toolbar1: tinyMCEToolbar1,
                        toolbar2: tinyMCEToolbar2,

                        forced_root_block: 'p',
                        init_instance_callback: function (editor) {
                            this.on('change', function (e) {
                                self.updateValue(e.level.content);
                            });
                            this.on('keyup', function (e) {
                                self.updateValue(e.srcElement.innerHTML);
                            });
                        }
                    });
                },
                updateValue: function (e) {
                    this.$emit('input', e);
                }
");
            WriteLiteral("            }\r\n        });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591