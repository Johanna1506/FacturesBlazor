#pragma checksum "/Users/johannajato/Projects/Facturations/Facturations/Client/Pages/Facturation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aefc28459a9a29b98ca0ace93023f6e7d053203c"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.AddMarkupContent(0, "<h1>Liste des Factures</h1>\n\n");
            __builder.AddMarkupContent(1, "<p>Voici la liste detaillée des factures</p>");
#nullable restore
#line 10 "/Users/johannajato/Projects/Facturations/Facturations/Client/Pages/Facturation.razor"
 if (factures == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 13 "/Users/johannajato/Projects/Facturations/Facturations/Client/Pages/Facturation.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, @"<thead><tr><th>Numéro de Facture</th>
                <th>Nom du client</th>
                <th>Date de facturation</th>
                <th>Date du reglement</th>
                <th>Montant du</th>
                <th>Montant réglé</th></tr></thead>
        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 29 "/Users/johannajato/Projects/Facturations/Facturations/Client/Pages/Facturation.razor"
             foreach (var facture in factures)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.AddAttribute(8, "class", "table-" + (
#nullable restore
#line 31 "/Users/johannajato/Projects/Facturations/Facturations/Client/Pages/Facturation.razor"
                                  ColorFromFacture(facture)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 32 "/Users/johannajato/Projects/Facturations/Facturations/Client/Pages/Facturation.razor"
                         facture.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\n                    ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 33 "/Users/johannajato/Projects/Facturations/Facturations/Client/Pages/Facturation.razor"
                         facture.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 34 "/Users/johannajato/Projects/Facturations/Facturations/Client/Pages/Facturation.razor"
                         facture.BillingDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 35 "/Users/johannajato/Projects/Facturations/Facturations/Client/Pages/Facturation.razor"
                         facture.PaymentDate.ToShortDateString()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 36 "/Users/johannajato/Projects/Facturations/Facturations/Client/Pages/Facturation.razor"
                         facture.Amount.ToString("$ 0.00")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 37 "/Users/johannajato/Projects/Facturations/Facturations/Client/Pages/Facturation.razor"
                         facture.AmountPaid.ToString("$ 0.00")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "/Users/johannajato/Projects/Facturations/Facturations/Client/Pages/Facturation.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 43 "/Users/johannajato/Projects/Facturations/Facturations/Client/Pages/Facturation.razor"
}

#line default
#line hidden
#nullable disable
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
