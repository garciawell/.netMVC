#pragma checksum "C:\Users\well_\Desktop\NET\demoMVC\demoMVC\demoMVC\Views\Shared\Components\Carrinho\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1ded439693629921b9c5a6b98b8619cceec7ebb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Carrinho_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Carrinho/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Carrinho/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Carrinho_Default))]
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
#line 1 "C:\Users\well_\Desktop\NET\demoMVC\demoMVC\demoMVC\Views\_ViewImports.cshtml"
using demoMVC;

#line default
#line hidden
#line 2 "C:\Users\well_\Desktop\NET\demoMVC\demoMVC\demoMVC\Views\_ViewImports.cshtml"
using demoMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1ded439693629921b9c5a6b98b8619cceec7ebb", @"/Views/Shared/Components/Carrinho/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f5af619bd0628b09c1d8847eb87900b6c24f26b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Carrinho_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 45, true);
            WriteLiteral("\r\n<span class=\"fade fa-shopping-cart fa-2x\"> ");
            EndContext();
            BeginContext(58, 5, false);
#line 3 "C:\Users\well_\Desktop\NET\demoMVC\demoMVC\demoMVC\Views\Shared\Components\Carrinho\Default.cshtml"
                                      Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(63, 7, true);
            WriteLiteral("</span>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
