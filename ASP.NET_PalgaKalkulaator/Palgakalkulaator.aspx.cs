using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NET_PalgaKalkulaator
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_Arvuta_Click(object sender, EventArgs e)
        {
            try // Proovib
            {
                double bruto = Convert.ToDouble(tb_Brutopalk.Text);
                KalkulaatorClass palk = new KalkulaatorClass(bruto, chb_Maksuvaba.Checked, chb_TööandjaTöötuskindlustusmakse.Checked, chb_TöötajaTöötuskindlustusmakse.Checked, chb_Kogumispenion.Checked);
                lbl_TöötuskindlustusmakseTöötajaT.Text = palk.UnemploymentTaxEmployeeO().ToString(); // Töötuskindlustusmakse (töötaja 1.6%).
                lbl_KogumispensionT.Text = palk.SecondPillarO().ToString(); // Kogumispension (II sammas 2%).
                lbl_TulumaksT.Text = palk.IncomeTaxO().ToString(); // Tulumaks.
                lbl_NetopalkT.Text = palk.NetSalaryO().ToString(); // Netopalk.
                lbl_BrutopalkT.Text = palk.GrossSalaryO().ToString(); // Brutopalk.
                lbl_SotsiaalmaksT.Text = palk.SocialTaxO().ToString(); // Sotsiaalmaks.
                lbl_TöötuskindlustusmakseTööandjaT.Text = palk.UnemploymentTaxEmployerO().ToString(); // Töötuskindlustusmakse (tööandja 0.8%).
                lbl_PalgafondT.Text = palk.TotalCostforEmployerO().ToString(); // Tööandja kulu kokku (palgafond).
                lbl_NetopalkT.Text = palk.NetSalaryO().ToString(); // Netopalk.

                errorLabel.Visible = false;
            }
            catch (Exception ex) // Püüab viga.
            {
                errorLabel.Text = ("Error: " + ex.Message);
                errorLabel.Visible = true;
            }
        }
    }
    }
