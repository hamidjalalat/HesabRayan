<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReportFactor.aspx.cs" Inherits="HJ_Template_MVC.Report.ReportFactor" %>
<%@ Register Assembly="Stimulsoft.Report.Web, Version=2012.2.1304.0, Culture=neutral, PublicKeyToken=EBE6666CBA19647A" Namespace="Stimulsoft.Report.Web" TagPrefix="cc1" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>فاکتور</title>
</head>
<script>
    function goBack() {
        window.history.back()
    }
</script>
<body>
    <form id="form1" runat="server">
    <div>
        <font size="3px" >
            </font>
        <cc1:StiWebViewer ID="MyStiWebViewer" runat="server" Width="100%" Height="1200px"
            ToolBarBackColor="WhiteSmoke" ImagesPath="Images/ReportImages" ScrollBarsMode="True"
            GlobalizationFile="Localization/fa.xml" ViewMode="WholeReport" ToolbarAlignment="Right">
        </cc1:StiWebViewer> 
      
    </div>
    </form>
</body>
</html>
