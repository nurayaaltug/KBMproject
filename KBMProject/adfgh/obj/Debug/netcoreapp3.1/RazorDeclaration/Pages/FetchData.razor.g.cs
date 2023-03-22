// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace KisiselBakimProje.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "c:\Users\Lenovo\Desktop\KBMProje\KBMProject\adfgh\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\Lenovo\Desktop\KBMProje\KBMProject\adfgh\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Lenovo\Desktop\KBMProje\KBMProject\adfgh\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Lenovo\Desktop\KBMProje\KBMProject\adfgh\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "c:\Users\Lenovo\Desktop\KBMProje\KBMProject\adfgh\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "c:\Users\Lenovo\Desktop\KBMProje\KBMProject\adfgh\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "c:\Users\Lenovo\Desktop\KBMProje\KBMProject\adfgh\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "c:\Users\Lenovo\Desktop\KBMProje\KBMProject\adfgh\_Imports.razor"
using KisiselBakimProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "c:\Users\Lenovo\Desktop\KBMProje\KBMProject\adfgh\_Imports.razor"
using KisiselBakimProje.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "c:\Users\Lenovo\Desktop\KBMProje\KBMProject\adfgh\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "c:\Users\Lenovo\Desktop\KBMProje\KBMProject\adfgh\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "c:\Users\Lenovo\Desktop\KBMProje\KBMProject\adfgh\Pages\FetchData.razor"
using KisiselBakimProje.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "c:\Users\Lenovo\Desktop\KBMProje\KBMProject\adfgh\Pages\FetchData.razor"
using System.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "c:\Users\Lenovo\Desktop\KBMProje\KBMProject\adfgh\Pages\FetchData.razor"
       
    int zoom = 10;
    string clickedPosition = "";
    double lat = 0, lng = 0;
    double latm = 39.937988, lngm = 32.784185;

    public SeciliKonumModel skm = new SeciliKonumModel();
    public KisiselBakimMagazaModel kbmm = new KisiselBakimMagazaModel();
    public List<UzaklikModel> uzakliste;
    public bool Checksubmit = false;

    protected void SeciliKonumTanimla()
    {
        if (lat != 0 && lng != 0)
        {
            sks.SeciliKonumSil();
            sks.SeciliKonumTanimlama(skm);
            uzakliste = us.MagazaKonumUzaklik();
            skm = new SeciliKonumModel();
            Checksubmit = true;
        }
    }

    void OnMapClick(GoogleMapClickEventArgs args)
    {
        clickedPosition = $"Map clicked LAT: {args.Position.Lat}, LNG: {args.Position.Lng}";
        lat = Convert.ToDouble(args.Position.Lat);
        lng = Convert.ToDouble(args.Position.Lng);
        latm = Convert.ToDouble(args.Position.Lat);
        lngm = Convert.ToDouble(args.Position.Lng);
        skm.lat = lat.ToString().Replace(",", ".");
        skm.lng = lng.ToString().Replace(",", ".");

    }
    void OnMarkerClick(RadzenGoogleMapMarker args)
    {
        clickedPosition = $"Map {args.Title} clicked LAT: {args.Position.Lat}, LNG: {args.Position.Lng}";
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UzaklikServices us { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SeciliKonumServices sks { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private KisiselBakimMagazaServices kbms { get; set; }
    }
}
#pragma warning restore 1591