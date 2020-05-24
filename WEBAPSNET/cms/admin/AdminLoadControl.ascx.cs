using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEBAPSNET.cms.admin
{
    public partial class AdminLoadControl : System.Web.UI.UserControl
    {
        string modul = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["modul"] != null)
                modul = Request.QueryString["modul"];
            switch (modul) {
                case "SanPham":
                    pAdminLoadControl.Controls.Add(LoadControl("SanPham/SanPhamLoadControl.ascx"));
                    break;
                case "TaiKhoan":
                    pAdminLoadControl.Controls.Add(LoadControl("TaiKhoan/TaiKhoanLoadControl.ascx"));
                    break;
                case "KhachHang":
                    pAdminLoadControl.Controls.Add(LoadControl("KhachHang/KhachHangLoadControl.ascx"));
                    break;
                case "TinTuc":
                    pAdminLoadControl.Controls.Add(LoadControl("TinTuc/TinTucLoadControl.ascx"));
                    break;
                case "Menu":
                    pAdminLoadControl.Controls.Add(LoadControl("Menu/MenuLoadControl.ascx"));
                    break;
                case "QuanCao":
                    pAdminLoadControl.Controls.Add(LoadControl("QuangCao/QuangCaoLoadControl.ascx"));
                    break;

                default:
                    pAdminLoadControl.Controls.Add(LoadControl("SanPham/SanPhamLoadControl.ascx"));
                    break;
            } 
            
        }
    }
}