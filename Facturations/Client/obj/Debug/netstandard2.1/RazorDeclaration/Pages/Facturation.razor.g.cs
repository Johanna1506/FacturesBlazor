// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Facturations.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/Users/johannajato/Projects/Facturations/Facturations/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/johannajato/Projects/Facturations/Facturations/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/johannajato/Projects/Facturations/Facturations/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/johannajato/Projects/Facturations/Facturations/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/johannajato/Projects/Facturations/Facturations/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/johannajato/Projects/Facturations/Facturations/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/johannajato/Projects/Facturations/Facturations/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/johannajato/Projects/Facturations/Facturations/Client/_Imports.razor"
using Facturations.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/johannajato/Projects/Facturations/Facturations/Client/_Imports.razor"
using Facturations.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/johannajato/Projects/Facturations/Facturations/Client/Pages/Facturation.razor"
using Facturations.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/factures")]
    public partial class Facturation : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "/Users/johannajato/Projects/Facturations/Facturations/Client/Pages/Facturation.razor"
           
            static string ColorFromFacture(Facture facture)
            {
                if (facture.IsLate)
                {
                    return "danger";
                }
                else if (facture.IsPaid)
                {
                    return "success";
                }
                else
                {
                    return "default";
                }
            }
        

        private IEnumerable<Facture> factures = null;

        protected override async Task OnInitializedAsync()
        {
          factures = await http.GetFromJsonAsync<IEnumerable<Facture>>("api/facture");
           
        }

        

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBusinessData Data { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
