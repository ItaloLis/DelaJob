#pragma checksum "C:\Users\Usuario\source\repos\WebApplicationDelaJob\WebApplicationDelaJob\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3facb0809b9591c29ecfd3fa6d2729380434cbab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Usuario\source\repos\WebApplicationDelaJob\WebApplicationDelaJob\Views\_ViewImports.cshtml"
using WebApplicationDelaJob;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Usuario\source\repos\WebApplicationDelaJob\WebApplicationDelaJob\Views\_ViewImports.cshtml"
using WebApplicationDelaJob.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3facb0809b9591c29ecfd3fa6d2729380434cbab", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"613b94a2de0729b8c0d1c350ab697dc2ec950add", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3facb0809b9591c29ecfd3fa6d2729380434cbab3297", async() => {
                WriteLiteral(@"
    <title>DelaJob</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <!-- Link CSS do Bootstrap: -->
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"">
    <!-- Links JavaScript do Bootstrap: -->
    <script src=""https://code.jquery.com/jquery-3.5.1.slim.min.js"" integrity=""sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js"" integrity=""sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN"" crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.5.3/dist/js/bootstrap.min.js"" integrity=""sha384-w1Q4orYjBQndcko6MimVbzY0tgp4pWB4lZ7lr30WKz0vr/aWKhXdBNmNb5D92v7s"" crossorigin=""anonymous""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3facb0809b9591c29ecfd3fa6d2729380434cbab5211", async() => {
                WriteLiteral(@"
    <!-- Carrossel de imagens: -->
    <div class=""carousel slide"" id=""carouselSite"" data-ride=""carousel"">
        <ol class=""carousel-indicators"">
            <li data-target=""#carouselSite"" data-slide-to=""0"" class=""active"" aria-label=""Slide 1""></li>
            <li data-target=""#carouselSite"" data-slide-to=""1"" aria-label=""Slide 2""></li>
            <li data-target=""#carouselSite"" data-slide-to=""2"" aria-label=""Slide 3""></li>
        </ol>

        <div class=""carousel-inner"">

            <div class=""carousel-item active"">
                <img src=""../Views/Images/Foto1(1).jpeg"" class=""img-fluid d-block w-100"" alt=""Simone de Beauvoir"" />
            </div>
            <div class=""carousel-item"">
                <img src=""../Views/Images/Foto4.jpeg"" class=""img-fluid d-block w-100"" alt=""Estee Lauder"" />
            </div>
            <div class=""carousel-item"">
                <img src=""../Views/Images/Foto1(3).jpeg"" class=""img-fluid d-block w-100"" alt=""Oprah Winfrey"" />
            </div>");
                WriteLiteral(@"

        </div>
        <a class=""carousel-control-prev"" href=""#carouselSite"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon""></span>
            <span class=""sr-only"">Voltar</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselSite"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon""></span>
            <span class=""sr-only"">Avançar</span>
        </a>
    </div>

    <!-- Texto e imagem (Quem Somos): -->
    <div class=""row mt-5"">

        <div class=""col-5 ml-5 mt-4"">
            <h1 class=""display-3"" style=""color: rgb(148, 84, 180);"">Quem Somos</h1><br>
            <p class=""lead""><b>DelaJob é uma organização sem fins lucrativos, cujo principal propósito é melhorar a situação de vulnerabilidade socioecômica de mulheres de baixa renda, através da valorização profissional e empregabilidade. Por meio de programas de capacitação de mão de obra feminina, o DelaJob promove o empoderamento feminino e ");
                WriteLiteral(@"geração de renda.</b></p>
            <br>
            <p class=""lead""><b>O projeto social foi fundado em 2022, através de um desafio proposto pela Recode Pro, tal iniciativa nasceu a partir de um grupo de 4 pessoas que se uniram para de sair de suas bolhas sociais e ver o mundo com outra perspectiva. Desse modo, criando uma rede de fortalecimento e pertencimento focada em mulheres em desemprego.</b></p>
        </div>
        <div class=""ml-auto mr-auto"">
            <img src=""../Views/Images/img-home-delajob.jpg"" style=""width: 600px; height: 600px;"">
        </div>

    </div>

    <!-- Texto e Cards com links: -->
    <div class=""row mt-5"">
        <div class=""mt-5 pt-5"">
            <h1 class=""mt-3 col-6 ml-auto mr-auto text-center"" style=""color: rgb(148, 84, 180); font-size: 80px;"">Vídeos e Palestras</h1>
        </div>
        <div class=""col-2 mt-4"">
            <a href=""https://www.youtube.com/watch?v=-O99-J-dtr0"" class=""text-dark"" type=""button"" target=""_blank"">
                <div c");
                WriteLiteral(@"lass=""card"" style=""background-color: FBC4C4; height: 400px;"">
                    <img class=""card-img-top"" style=""height: 150px;"" src=""../Views/Images/video1.png"">
                    <div class=""card-body"">
                        <h4 class=""card-title text-center"">Mulheres brasileiras no Mercado de Trabalho</h4>
                    </div>
                </div>
            </a>
        </div>

        <div class=""col-2 mt-4"">
            <a href=""https://www.youtube.com/watch?v=6RSc_XYezig"" class=""text-dark"" type=""button"" target=""_blank"">
                <div class=""card"" style=""background-color: FBC4C4; height: 400px;"">
                    <img class=""card-img-top"" style=""height: 150px;"" src=""../Views/Images/video2.png"">
                    <div class=""card-body"">
                        <h4 class=""card-title text-center"">Empoderamento das Mulheres</h4>
                    </div>
                </div>
            </a>
        </div>

        <div class=""col-2 mt-4"">
            <a hr");
                WriteLiteral(@"ef=""https://youtu.be/CiONvw9vvI0"" class=""text-dark"" type=""button"" target=""_blank"">
                <div class=""card"" style=""background-color: FBC4C4; height: 400px;"">
                    <img class=""card-img-top"" style=""height: 150px;"" src=""../Views/Images/video3.png"">
                    <div class=""card-body"">
                        <h4 class=""card-title text-center"">Mulheres no Mercado de Trabalho | Entrevista - Futuro do Trabalho</h4>
                    </div>
                </div>
            </a>
        </div>
    </div>

    <!-- Mais textos e cards: -->
    <div class=""row mt-5 ml-5 mb-lg-5"">

        <div class=""col-2 mt-4"">
            <div class=""card"" style=""background-color: FBC4C4; height: 400px;"">
                <img class=""card-img-top"" style=""height: 150px;"" src=""../Views/Images/medium-shot-woman-work.jpg"">
                <div class=""card-body"">
                    <h3 class=""card-title text-center"">Tecnologia</h3>
                </div>
            </div>
        <");
                WriteLiteral(@"/div>

        <div class=""col-2 mt-4"">
            <div class=""card"" style=""background-color: FBC4C4; height: 400px;"">
                <img class=""card-img-top"" style=""height: 150px;"" src=""../Views/Images/female-chef-chopping-vegetables-kitchen.jpg"">
                <div class=""card-body"">
                    <h3 class=""card-title text-center"">Culinária</h3>
                </div>
            </div>
        </div>

        <div class=""col-2 mt-4"">
            <div class=""card"" style=""background-color: FBC4C4; height: 400px;"">
                <img class=""card-img-top"" style=""height: 150px;"" src=""../Views/Images/happy-friendly-cashier-giving-credit-card-customer-after-payment-thanking-purchase-smiling-medium-shot-shopping-concept.jpg"">
                <div class=""card-body"">
                    <h3 class=""card-title text-center"">Vendas</h3>
                </div>
            </div>
        </div>

        <div class=""mt-5 pt-2 col-5 ml-auto mr-auto"">
            <h1 class=""mt-5 text-center");
                WriteLiteral("\" style=\"color: rgb(148, 84, 180); font-size: 80px;\">Vagas em diversas Áreas</h1>\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
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
