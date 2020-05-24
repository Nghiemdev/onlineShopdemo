using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace WEBAPSNET.cms.admin.SanPham.QuanLyDanhMuc
{
    public partial class DanhMuc_ThemMoi : System.Web.UI.UserControl
    {
      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LayDanhMucCha();
              
            }
        }

  
        private void LayDanhMucCha()
        {
            DataTable dt = new DataTable();
          
            ddlDanhMucCha.Items.Clear();
            //ddlDanhMucCha.Items.Add(new ListItem("Danh Muc Gốc", "0"));
       
        }

    
    }
}