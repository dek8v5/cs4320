﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace challenge3
{
    public partial class Page1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //save the information, user went to page1
            Session["Page"] = "Page1";
        }
    }
}