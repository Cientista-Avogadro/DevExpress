using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PR.Controllers;
namespace PR.Report
{
    public partial class Report1 : DevExpress.XtraReports.UI.XtraReport
    {
        public Report1()
        {
            InitializeComponent();
        }

       
        string tolang;

        Traduzir traduzir = new Traduzir();
       
        Lang l = new Lang();
        string pl = "pt";
        private void Report1_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {


            tolang = id.Value.ToString();
            List<ReportHeaderBand> Sbl = this.Controls.OfType<ReportHeaderBand>().ToList();
            foreach (var sbl in Sbl)
            {
                if (sbl.Name.StartsWith("ReportHeader"))
                {
                    List<XRPanel> lblts = sbl.Controls.OfType<XRPanel>().ToList();
                    foreach (var lblt in lblts)
                    {
                        if (lblt.Name.StartsWith("xrPanel"))
                        {
                            List<XRLabel> lb = lblt.Controls.OfType<XRLabel>().ToList();
                            foreach (var ol in lb)
                            {
                                if (!String.IsNullOrWhiteSpace(ol.Text))
                                {
                                    if (ol.Name.StartsWith("xrLabel"))
                                    {
                                        if (tolang!="/")
                                        {
                                            ol.Text = traduzir.TranslateAsync(ol.Text, pl, tolang).Result.outputs.ElementAt(0).output;
                                        }
                                    }
                                }
                               
                            }
                        }

                    }




                }
            }

            pl = tolang;
        }
    }
}
