#pragma checksum "/Users/diegopinones/Documents/GitHub/YouShallPass/TestApp/TestApp/TestApp/Views/Home/Game.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb9d4185ee446cc35df11e75db9207cdb22ea428"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Game), @"mvc.1.0.view", @"/Views/Home/Game.cshtml")]
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
#line 1 "/Users/diegopinones/Documents/GitHub/YouShallPass/TestApp/TestApp/TestApp/Views/_ViewImports.cshtml"
using TestApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/diegopinones/Documents/GitHub/YouShallPass/TestApp/TestApp/TestApp/Views/_ViewImports.cshtml"
using TestApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb9d4185ee446cc35df11e75db9207cdb22ea428", @"/Views/Home/Game.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e25db771d30abaf29d3599c25e6deb12289bab6e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Game : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SimplePlayer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/diegopinones/Documents/GitHub/YouShallPass/TestApp/TestApp/TestApp/Views/Home/Game.cshtml"
   ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"<style>
    p {
        font-family: ""Roboto"", sans-serif;
    }

    .list-group-item.active {
        background-color: seagreen;
        border-color: seagreen;
    }

    #game {
        background-color: darkgrey;
        border-radius: 1vh;
        height: 400px;
    }

    #title {
        margin-bottom: 0;
        color: white;
    }

    #last-scores-table {
        padding-left: 3%;
    }

    body {
        background-color: black;
    }

    .card-header.text-center {
        background-color: black;
        border-color: white;
    }

    .list-group-item {
        background-color: black;
        border-color: white;
    }

    h4 {
        color: white;
    }

    div {
        color: white;
    }
</style>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb9d4185ee446cc35df11e75db9207cdb22ea4285162", async() => {
                WriteLiteral(@"
    <div class=""row mb-3 mt-4"">
        <!-- Information BEGIN -->
        <div class=""col-9"">
            <div class=""row align-items-end"">
                <div class=""col text-start"">Score <span id=""score"">0000</span></div>
                <h4 id=""title"" class=""col text-center"">You Shall Pass</h4>
                <div class=""col text-end"" style=""text-align: end;"">Highscore <span id=""highscore"">0000</span></div>
            </div>
        </div>
        <!-- Information END -->

        <div class=""col-3""></div>
    </div>
    <div class=""row"">

        <div id=""game-wrapper"" class=""col-9"">
");
                WriteLiteral(@"            <div id=""unity-container"" class=""unity-desktop"">
                <canvas id=""unity-canvas"" width=960 height=600></canvas>
                <div id=""unity-loading-bar"">
                    <div id=""unity-logo""></div>
                    <div id=""unity-progress-bar-empty"">
                        <div id=""unity-progress-bar-full""></div>
                    </div>
                </div>
                <div id=""unity-warning""> </div>
                <div id=""unity-footer"">
                    <div id=""unity-webgl-logo""></div>
                    <div id=""unity-fullscreen-button""></div>
                    <div id=""unity-build-title"">You shall pass</div>
                </div>
            </div>
            <script>var container = document.querySelector(""#unity-container"");
                var canvas = document.querySelector(""#unity-canvas"");
                var loadingBar = document.querySelector(""#unity-loading-bar"");
                var progressBarFull = document.querySelector(""#un");
                WriteLiteral(@"ity-progress-bar-full"");
                var fullscreenButton = document.querySelector(""#unity-fullscreen-button"");
                var warningBanner = document.querySelector(""#unity-warning"");

                // Shows a temporary message banner/ribbon for a few seconds, or
                // a permanent error message on top of the canvas if type=='error'.
                // If type=='warning', a yellow highlight color is used.
                // Modify or remove this function to customize the visually presented
                // way that non-critical warnings and error messages are presented to the
                // user.
                function unityShowBanner(msg, type) {
                    function updateBannerVisibility() {
                        warningBanner.style.display = warningBanner.children.length ? 'block' : 'none';
                    }
                    var div = document.createElement('div');
                    div.innerHTML = msg;
                    warningBanner.ap");
                WriteLiteral(@"pendChild(div);
                    if (type == 'error') div.style = 'background: red; padding: 10px;';
                    else {
                        if (type == 'warning') div.style = 'background: yellow; padding: 10px;';
                        setTimeout(function () {
                            warningBanner.removeChild(div);
                            updateBannerVisibility();
                        }, 5000);
                    }
                    updateBannerVisibility();
                }

                var buildUrl = ""/game/Build"";
                var loaderUrl = buildUrl + ""/WebGl.loader.js"";
                var config = {
                    dataUrl: buildUrl + ""/WebGl.data.gz"",
                    frameworkUrl: buildUrl + ""/WebGl.framework.js.gz"",
                    codeUrl: buildUrl + ""/WebGl.wasm.gz"",
                    streamingAssetsUrl: ""StreamingAssets"",
                    companyName: ""DefaultCompany"",
                    productName: ""You shall pass"",
   ");
                WriteLiteral(@"                 productVersion: ""0.1"",
                    showBanner: unityShowBanner,
                };

                // By default Unity keeps WebGL canvas render target size matched with
                // the DOM size of the canvas element (scaled by window.devicePixelRatio)
                // Set this to false if you want to decouple this synchronization from
                // happening inside the engine, and you would instead like to size up
                // the canvas DOM size and WebGL render target sizes yourself.
                // config.matchWebGLToCanvasSize = false;

                if (/iPhone|iPad|iPod|Android/i.test(navigator.userAgent)) {
                    container.className = ""unity-mobile"";
                    // Avoid draining fillrate performance on mobile devices,
                    // and default/override low DPI mode on mobile browsers.
                    config.devicePixelRatio = 1;
                    unityShowBanner('WebGL builds are not supported on m");
                WriteLiteral(@"obile devices.');
                } else {
                    canvas.style.width = ""960px"";
                    canvas.style.height = ""600px"";
                }
                loadingBar.style.display = ""block"";

                var script = document.createElement(""script"");
                script.src = loaderUrl;
                script.onload = () => {
                    createUnityInstance(canvas, config, (progress) => {
                        progressBarFull.style.width = 100 * progress + ""%"";
                    }).then((unityInstance) => {
                        loadingBar.style.display = ""none"";
                        fullscreenButton.onclick = () => {
                            unityInstance.SetFullscreen(1);
                        };
                    }).catch((message) => {
                        alert(message);
                    });
                };
                document.body.appendChild(script);</script>
        </div>

        <!-- Best Scores Table  BEGIN");
                WriteLiteral(@" -->
        <div id=""last-scores-table"" class=""col-2w"">
            <div class=""card"">
                <div class=""card-header text-center"">Your Best Scores</div>
                <div id=""player-score"" class=""list-group list-group-flush"">
                    <!-- Scores BEGIN -->
                    <!-- Scores END -->
                </div>
            </div>
        </div>
        <!-- Best Scores Table END -->
    </div>
    <div class=""row"">
");
#nullable restore
#line 178 "/Users/diegopinones/Documents/GitHub/YouShallPass/TestApp/TestApp/TestApp/Views/Home/Game.cshtml"
         if (ViewData["id"] != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div id=\"edit\" class=\"col text-start\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb9d4185ee446cc35df11e75db9207cdb22ea42812242", async() => {
                    WriteLiteral("Editar datos de registro");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 181 "/Users/diegopinones/Documents/GitHub/YouShallPass/TestApp/TestApp/TestApp/Views/Home/Game.cshtml"
                                                 WriteLiteral(Model.id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n</div>\r\n                <div id=\"delete\" class=\"col text-end\">\r\n                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb9d4185ee446cc35df11e75db9207cdb22ea42814808", async() => {
                    WriteLiteral("Borrar datos");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 184 "/Users/diegopinones/Documents/GitHub/YouShallPass/TestApp/TestApp/TestApp/Views/Home/Game.cshtml"
                                                                   WriteLiteral(ViewData["id"]);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>");
#nullable restore
#line 185 "/Users/diegopinones/Documents/GitHub/YouShallPass/TestApp/TestApp/TestApp/Views/Home/Game.cshtml"
                      }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n");
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
            WriteLiteral(@"
<script>
    function UpdateScore(intScore, PlayerId) {
        $.ajax({
            url: ""/api/game"",
            method: ""POST"",
            dataType: ""json"",
            processData: false,
            contentType: ""application/json; charset=utf-8"",
            data: JSON.stringify({ score: intScore, id: PlayerId })
        }).done(
            function (data) {
                $(""#score"").text(data.score);

                if (data.score > parseInt($(""#highscore"").text())) {
                    $(""#highscore"").text(data.score);
                }

                var table = d3.select(""#player-score"");
                table.selectAll(""*"").remove();
                table.selectAll(""li"")
                    .data(data.hiscoreList)
                    .enter()
                    .append(""li"")
                    .attr(""class"", ""list-group-item"")
                    .text(function (row) {
                        return ""Your Score: "" + row.score;
                    });
          ");
            WriteLiteral("  }\r\n        );\r\n    };\r\n</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SimplePlayer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
