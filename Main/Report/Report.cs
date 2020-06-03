using System;
using System.Drawing;
using System.Data;
using Stimulsoft.Controls;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Dialogs;
using Stimulsoft.Report.Components;

namespace Reports
{
    public class Report : Stimulsoft.Report.StiReport
    {
        public Report()        {
            this.InitializeComponent();
        }

        #region StiReport Designer generated code - do not modify
        public Stimulsoft.Report.Components.StiPage Page1;
        public Stimulsoft.Report.Components.StiReportTitleBand ReportTitleBand1;
        public Stimulsoft.Report.Components.StiText Text2;
        public Stimulsoft.Report.Components.StiHeaderBand HeaderBand1;
        public Stimulsoft.Report.Components.StiText HeaderGetRahsepari_RDate;
        public Stimulsoft.Report.Components.StiText Text7;
        public Stimulsoft.Report.Components.StiText Text9;
        public Stimulsoft.Report.Components.StiDataBand DataBand1;
        public Stimulsoft.Report.Components.StiText Text5;
        public Stimulsoft.Report.Components.StiText Text6;
        public Stimulsoft.Report.Components.StiText Text16;
        public Stimulsoft.Report.Components.StiWatermark Page1_Watermark;
        public Stimulsoft.Report.Print.StiPrinterSettings Report_PrinterSettings;
        public FactorsDataSource Factors;
        
        public void Text2__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "گزارش فاکتور های صادره";
        }
        
        public void HeaderGetRahsepari_RDate__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "ردیف";
        }
        
        public void Text7__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "نام مشتری";
        }
        
        public void Text9__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "تاریخ صدور فاکتور";
        }
        
        public void Text5__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Factors.NameCustomer, true);
        }
        
        public void Text6__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Line, true);
        }
        
        public void Text16__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Factors.Date, true);
        }
        
        private void InitializeComponent()
        {
            this.Factors = new FactorsDataSource();
            this.NeedsCompiling = false;
            this.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.ReferencedAssemblies = new System.String[] {
                    "System.Dll",
                    "System.Drawing.Dll",
                    "System.Windows.Forms.Dll",
                    "System.Data.Dll",
                    "System.Xml.Dll",
                    "Stimulsoft.Controls.Dll",
                    "Stimulsoft.Base.Dll",
                    "Stimulsoft.Report.Dll"};
            this.ReportAlias = "Report";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2020, 6, 3, 10, 26, 34, 561);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2020, 6, 3, 10, 1, 25, 887);
            this.ReportFile = "";
            this.ReportGuid = "7e95fc071a4946d89d98342c37f1e5e3";
            this.ReportName = "Report";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.ReportVersion = "2012.1.1300";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            this.Page1 = new Stimulsoft.Report.Components.StiPage();
            this.Page1.Guid = "b6e6c6b846f74d50b746dbd1d9427a0d";
            this.Page1.Name = "Page1";
            this.Page1.PageHeight = 11;
            this.Page1.PageWidth = 8.5;
            this.Page1.PaperSize = System.Drawing.Printing.PaperKind.Letter;
            this.Page1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Page1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // ReportTitleBand1
            // 
            this.ReportTitleBand1 = new Stimulsoft.Report.Components.StiReportTitleBand();
            this.ReportTitleBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.2, 7.72, 0.7);
            this.ReportTitleBand1.Guid = "4e3665b86d5b4ff29b74edcb5e039d3e";
            this.ReportTitleBand1.Name = "ReportTitleBand1";
            this.ReportTitleBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.ReportTitleBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text2
            // 
            this.Text2 = new Stimulsoft.Report.Components.StiText();
            this.Text2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(2.6, 0.1, 2.3, 0.3);
            this.Text2.Guid = "1423959f5d9c4ab3922aaf9b42a9a70c";
            this.Text2.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text2.Name = "Text2";
            this.Text2.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text2__GetValue);
            this.Text2.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.White);
            this.Text2.Font = new System.Drawing.Font("Tahoma", 14F);
            this.Text2.Indicator = null;
            this.Text2.Interaction = null;
            this.Text2.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text2.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.ReportTitleBand1.Interaction = null;
            // 
            // HeaderBand1
            // 
            this.HeaderBand1 = new Stimulsoft.Report.Components.StiHeaderBand();
            this.HeaderBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 1.3, 7.72, 0.4);
            this.HeaderBand1.Guid = "23ccc253671f477eab6f516831ae558f";
            this.HeaderBand1.Name = "HeaderBand1";
            this.HeaderBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.HeaderBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // HeaderGetRahsepari_RDate
            // 
            this.HeaderGetRahsepari_RDate = new Stimulsoft.Report.Components.StiText();
            this.HeaderGetRahsepari_RDate.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7.1, 0, 0.6, 0.4);
            this.HeaderGetRahsepari_RDate.Guid = "0d5abe53b4ba452d9bf06c877437934d";
            this.HeaderGetRahsepari_RDate.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.HeaderGetRahsepari_RDate.Name = "HeaderGetRahsepari_RDate";
            this.HeaderGetRahsepari_RDate.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.HeaderGetRahsepari_RDate__GetValue);
            this.HeaderGetRahsepari_RDate.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.HeaderGetRahsepari_RDate.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.HeaderGetRahsepari_RDate.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.HeaderGetRahsepari_RDate.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 191, 191, 191));
            this.HeaderGetRahsepari_RDate.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.HeaderGetRahsepari_RDate.Indicator = null;
            this.HeaderGetRahsepari_RDate.Interaction = null;
            this.HeaderGetRahsepari_RDate.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.HeaderGetRahsepari_RDate.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.HeaderGetRahsepari_RDate.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text7
            // 
            this.Text7 = new Stimulsoft.Report.Components.StiText();
            this.Text7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(3.1, 0, 4, 0.4);
            this.Text7.Guid = "a96254a2abb44b57a5adc81809944f64";
            this.Text7.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text7.Name = "Text7";
            this.Text7.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text7__GetValue);
            this.Text7.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text7.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text7.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text7.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 191, 191, 191));
            this.Text7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Text7.Indicator = null;
            this.Text7.Interaction = null;
            this.Text7.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text7.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text7.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text9
            // 
            this.Text9 = new Stimulsoft.Report.Components.StiText();
            this.Text9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 3.1, 0.4);
            this.Text9.Guid = "b425236868cc47c1bc0dd3002252d2b5";
            this.Text9.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text9.Name = "Text9";
            this.Text9.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text9__GetValue);
            this.Text9.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text9.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text9.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(255, 191, 191, 191));
            this.Text9.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.Text9.Indicator = null;
            this.Text9.Interaction = null;
            this.Text9.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text9.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text9.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.HeaderBand1.Interaction = null;
            // 
            // DataBand1
            // 
            this.DataBand1 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 2.1, 7.72, 0.3);
            this.DataBand1.DataSourceName = "Factors";
            this.DataBand1.Guid = "8587d0f56d3b492f83a671678078caff";
            this.DataBand1.Name = "DataBand1";
            this.DataBand1.Sort = new System.String[0];
            this.DataBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.DataBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.DataBand1.BusinessObjectGuid = null;
            // 
            // Text5
            // 
            this.Text5 = new Stimulsoft.Report.Components.StiText();
            this.Text5.CanGrow = true;
            this.Text5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(3.1, 0, 4, 0.3);
            this.Text5.Guid = "61f9e0c225fc454db217231cb4fd8d24";
            this.Text5.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text5.Name = "Text5";
            this.Text5.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text5__GetValue);
            this.Text5.Type = Stimulsoft.Report.Components.StiSystemTextType.DataColumn;
            this.Text5.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text5.Font = new System.Drawing.Font("Arial", 8F);
            this.Text5.Indicator = null;
            this.Text5.Interaction = null;
            this.Text5.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text5.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text5.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text6
            // 
            this.Text6 = new Stimulsoft.Report.Components.StiText();
            this.Text6.CanGrow = true;
            this.Text6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7.1, 0, 0.6, 0.3);
            this.Text6.Guid = "77122adbb8e244e085630c9d5e131591";
            this.Text6.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text6.Name = "Text6";
            this.Text6.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text6__GetValue);
            this.Text6.Type = Stimulsoft.Report.Components.StiSystemTextType.SystemVariables;
            this.Text6.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text6.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text6.Font = new System.Drawing.Font("Tahoma", 8F);
            this.Text6.Indicator = null;
            this.Text6.Interaction = null;
            this.Text6.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text6.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text6.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text16
            // 
            this.Text16 = new Stimulsoft.Report.Components.StiText();
            this.Text16.CanGrow = true;
            this.Text16.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 3.1, 0.3);
            this.Text16.Guid = "874e9cb5cda643d9a9b14ba1b44222f0";
            this.Text16.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text16.Name = "Text16";
            this.Text16.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text16__GetValue);
            this.Text16.Type = Stimulsoft.Report.Components.StiSystemTextType.DataColumn;
            this.Text16.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text16.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black), false);
            this.Text16.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text16.Font = new System.Drawing.Font("Arial", 8F);
            this.Text16.Indicator = null;
            this.Text16.Interaction = null;
            this.Text16.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text16.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text16.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, true, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.DataBand1.DataRelationName = null;
            this.DataBand1.Interaction = null;
            this.DataBand1.MasterComponent = null;
            this.Page1.ExcelSheetValue = null;
            this.Page1.Interaction = null;
            this.Page1.Margins = new Stimulsoft.Report.Components.StiMargins(0.39, 0.39, 0.39, 0.39);
            this.Page1_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page1_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page1_Watermark.Image = null;
            this.Page1_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            this.Report_PrinterSettings = new Stimulsoft.Report.Print.StiPrinterSettings();
            this.PrinterSettings = this.Report_PrinterSettings;
            this.Page1.Report = this;
            this.Page1.Watermark = this.Page1_Watermark;
            this.ReportTitleBand1.Page = this.Page1;
            this.ReportTitleBand1.Parent = this.Page1;
            this.Text2.Page = this.Page1;
            this.Text2.Parent = this.ReportTitleBand1;
            this.HeaderBand1.Page = this.Page1;
            this.HeaderBand1.Parent = this.Page1;
            this.HeaderGetRahsepari_RDate.Page = this.Page1;
            this.HeaderGetRahsepari_RDate.Parent = this.HeaderBand1;
            this.Text7.Page = this.Page1;
            this.Text7.Parent = this.HeaderBand1;
            this.Text9.Page = this.Page1;
            this.Text9.Parent = this.HeaderBand1;
            this.DataBand1.Page = this.Page1;
            this.DataBand1.Parent = this.Page1;
            this.Text5.Page = this.Page1;
            this.Text5.Parent = this.DataBand1;
            this.Text6.Page = this.Page1;
            this.Text6.Parent = this.DataBand1;
            this.Text16.Page = this.Page1;
            this.Text16.Parent = this.DataBand1;
            // 
            // Add to ReportTitleBand1.Components
            // 
            this.ReportTitleBand1.Components.Clear();
            this.ReportTitleBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text2});
            // 
            // Add to HeaderBand1.Components
            // 
            this.HeaderBand1.Components.Clear();
            this.HeaderBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.HeaderGetRahsepari_RDate,
                        this.Text7,
                        this.Text9});
            // 
            // Add to DataBand1.Components
            // 
            this.DataBand1.Components.Clear();
            this.DataBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text5,
                        this.Text6,
                        this.Text16});
            // 
            // Add to Page1.Components
            // 
            this.Page1.Components.Clear();
            this.Page1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.ReportTitleBand1,
                        this.HeaderBand1,
                        this.DataBand1});
            // 
            // Add to Pages
            // 
            this.Pages.Clear();
            this.Pages.AddRange(new Stimulsoft.Report.Components.StiPage[] {
                        this.Page1});
            this.Factors.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Id", "Id", "Id", typeof(long)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Date", "Date", "Date", typeof(DateTime)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("NameCustomer", "NameCustomer", "NameCustomer", typeof(string))});
            this.DataSources.Add(this.Factors);
            this.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", "Connection", "Integrated Security=False;Data Source=.;Initial Catalog=HesabRayan;Password=123;User ID=sa", false));
            this.Factors.Connecting += new System.EventHandler(this.GetFactors_SqlCommand);
        }
        
        public void GetFactors_SqlCommand(object sender, System.EventArgs e)
        {
            this.Factors.SqlCommand = "select * from Factors";
        }
        
        #region DataSource Factors
        public class FactorsDataSource : Stimulsoft.Report.Dictionary.StiSqlSource
        {
            
            public FactorsDataSource() : 
                    base("Connection", "Factors", "Factors", "", true, false, 30)
            {
            }
            
            public virtual long Id
            {
                get
                {
                    return ((long)(StiReport.ChangeType(this["Id"], typeof(long), true)));
                }
            }
            
            public virtual string Date
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Date"], typeof(DateTime), true)));
                }
            }
            
            public virtual string NameCustomer
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["NameCustomer"], typeof(string), true)));
                }
            }
        }
        #endregion DataSource Factors
        #endregion StiReport Designer generated code - do not modify
    }
}
