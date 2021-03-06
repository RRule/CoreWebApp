#pragma checksum "C:\Development_local\CoreWebApp\CoreWebApp\CoreWebApp\Views\Components\MaterialCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a1e8c52655f509a229c72a92a14c20a3cb8d668"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Components_MaterialCard), @"mvc.1.0.view", @"/Views/Components/MaterialCard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Components/MaterialCard.cshtml", typeof(AspNetCore.Views_Components_MaterialCard))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1e8c52655f509a229c72a92a14c20a3cb8d668", @"/Views/Components/MaterialCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce38d043670142d3eeab9e7775e3d99906b8a926", @"/Views/_ViewImports.cshtml")]
    public class Views_Components_MaterialCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 2314, true);
            WriteLiteral(@"


<template id=""MaterialCard"">
    <v-card v-bind=""$attrs""
            :style=""styles""
            v-on=""$listeners"">

        <helper-offset :inline=""inline""
                       :full-width=""fullWidth""
                       :offset=""offset"">

            <v-card :color=""color""
                    class=""v-card--material__header m-1""
                    dark>
                <h3 class=""title font-weight-light mb-2""
                    v-text=""title""></h3>
                <h4 class=""text font-weight-light mb-2""
                    v-text=""text""></h4>
            </v-card>
        </helper-offset>

        <!-- 3-->
        <v-card-text>
            <slot />
        </v-card-text>


    </v-card>
</template>

<script>
    Vue.component('material-card',
        {
            template: ""#MaterialCard"",
            inheritAttrs: false,
            props: {
                color: {
                    type: String,
                    default: 'secondary'
               ");
            WriteLiteral(@" },
                inline: {
                    type: Boolean,
                    default: false
                },
                fullWidth: {
                    type: Boolean,
                    default: false
                },
                offset: {
                    type: [Number, String],
                    default: 24
                },
                title: {
                    type: String,
                    default: undefined
                },
                text: {
                    type: String,
                    default: undefined
                }
            },

            computed: {
                hasOffset() {
                    return this.$slots.header ||
                        this.$slots.offset ||
                        this.title ||
                        this.text;
                },
                styles() {
                    if (!this.hasOffset) return null

                    return {
                        marginBot");
            WriteLiteral(@"tom: `${this.offset}px`,
                        marginTop: `${this.offset * 2}px`
                    }
                }
            }
        });
</script>

<style>

    .v-card--material .header .v-card {
        border-radius: 4px;
    }
</style>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
