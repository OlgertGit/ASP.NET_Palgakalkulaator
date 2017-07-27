<%@ Page Title="Palgakalkulaator" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Palgakalkulaator.aspx.cs" Inherits="ASP.NET_PalgaKalkulaator.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <link rel="stylesheet" type="text/css" href="KalkulaatorStyle.css">
    <div id ="chb">
    <br>
    <asp:CheckBox ID="chb_Maksuvaba" runat="server" Text="Arvesta maksuvaba tulu (180 EUR kuus)" Checked="True" />
    <br>
    <asp:CheckBox ID="chb_TööandjaTöötuskindlustusmakse" runat="server" Text="Tööandja töötuskindlustus makse (0.8%)" Checked="True" />
    <br>
    <asp:CheckBox ID="chb_TöötajaTöötuskindlustusmakse" runat="server" Text="Töötaja (kindlustatu) töötuskindlustusmakse (1.6%)" Checked="True" />
    <br>
    <asp:CheckBox ID="chb_Kogumispenion" runat="server" Text="Kogumispension(II sammas)" Checked="True" />
    </div>
    <h2><%: Title %>.</h2>
    <div id ="bruto">
    <asp:Label ID="lbl_BrutopalkC" runat="server" Text="Brutopalk: "></asp:Label>
    <asp:TextBox ID="tb_Brutopalk" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="btn_Arvuta" runat="server" Text="Arvuta" OnClick="btn_Arvuta_Click" />
    </div>
    <div id ="kalkulaator">
    <h4>Tulemus.</h4>
    <asp:Label ID="lbl_Palgafond" runat="server" Text="Tööandja kulu kokku(palgafond): "></asp:Label>
    <asp:Label ID="lbl_PalgafondT" runat="server" Text="0"></asp:Label>
    <br>
    <asp:Label ID="lbl_Sotsiaalmaks" runat="server" Text="Sotsiaalmaks: "></asp:Label>
    <asp:Label ID="lbl_SotsiaalmaksT" runat="server" Text="0"></asp:Label>
    <br>
    <asp:Label ID="lbl_TöötuskindlustusmakseTööandja" runat="server" Text="Töötuskindlustusmakse (tööandja): "></asp:Label>
    <asp:Label ID="lbl_TöötuskindlustusmakseTööandjaT" runat="server" Text="0"></asp:Label>
    <br>
    <asp:Label ID="lbl_Brutopalk" runat="server" Text="Brutopalk: "></asp:Label>
    <asp:Label ID="lbl_BrutopalkT" runat="server" Text="0"></asp:Label>
    <br>
    <asp:Label ID="lbl_Kogumispension" runat="server" Text="Kogumispension (II sammas): "></asp:Label>
    <asp:Label ID="lbl_KogumispensionT" runat="server" Text="0"></asp:Label>
    <br>
    <asp:Label ID="lbl_TöötuskindlustusmakseTöötaja" runat="server" Text="Brutopalk: "></asp:Label>
    <asp:Label ID="lbl_TöötuskindlustusmakseTöötajaT" runat="server" Text="0"></asp:Label>
    <br>
    <asp:Label ID="lbl_Tulumaks" runat="server" Text="Tulumaks: "></asp:Label>
    <asp:Label ID="lbl_TulumaksT" runat="server" Text="0"></asp:Label>
    <br>
    <asp:Label ID="lbl_Netopalk" runat="server" Text="Netopalk: "></asp:Label>
    <asp:Label ID="lbl_NetopalkT" runat="server" Text="0"></asp:Label>
    <br>
    </div>    
    <asp:Label ID="errorLabel" runat="server" Font-Size="XX-Large" ForeColor="Red"></asp:Label>
    </asp:Content>


