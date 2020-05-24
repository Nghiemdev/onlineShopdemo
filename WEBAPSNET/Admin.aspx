<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin.aspx.cs" Inherits="WEBAPSNET.Admin" %>

<%@ Register Src="~/cms/admin/AdminLoadControl.ascx" TagPrefix="uc1" TagName="AdminLoadControl" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trang Quan Trị</title>
    <link href="cms/admin/css/AdminCss.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">

        <div>
             <%-- header --%>
           <div id="header">
               <div class="logo"><a href="/Admin.aspx"><img src="pic/Logo/ntg.png" / style="width:70px"></a></div>
                <div class="accountMenu"">
                Menu thông tin tài khoản</div>
           </div> 
             <div class="MenuChinh">
                <div class="container">
                    <ul>
                        <li><a class="<%=DanhDau("SanPham") %>" href="Admin.aspx?modul=SanPham">Sản phẩm</a></li>
                        <li><a class="<%=DanhDau("KhachHang") %>" href="Admin.aspx?modul=KhachHang">Khách Hàng</a></li>
                        <li><a class="<%=DanhDau("TinTuc") %>" href="Admin.aspx?modul=TinTuc">Tin Tức</a></li>
                        <li><a class="<%=DanhDau("TaiKhoan") %>" href="Admin.aspx?modul=TaiKhoan">Tài khoản</a></li> 
                        <li><a class="<%=DanhDau("QuangCao") %>" href="Admin.aspx?modul=QuangCao">Quảng cáo</a></li> 
                        <li><a class="<%=DanhDau("Menu") %>" href="Admin.aspx?modul=Menu">Menu</a></li>                              
                    </ul>
                </div>              
            </div> 

            <%-- Phần nội dung trang --%>
            <uc1:AdminLoadControl runat="server" ID="AdminLoadControl" />
        </div>
    </form>
    
</body>
</html>
