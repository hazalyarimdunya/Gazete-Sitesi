﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace MaysaGazete
{
    public partial class sondakika : System.Web.UI.Page
    { 
        sqlbaglantı baglan = new sqlbaglantı();
       // string id1;
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Select * from Haberler where Durum=1", baglan.baglan());
            SqlDataReader oku = cmd.ExecuteReader();
            DataList2.DataSource = oku;
            DataList2.DataBind();
        }

        protected void DataList2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}