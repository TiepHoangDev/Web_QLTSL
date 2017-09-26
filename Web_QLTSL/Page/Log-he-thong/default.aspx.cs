﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web_QLTSL.Page.Log_he_thong
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string log = "";
            var data = new Log_he_thong.LogHeThong().GetLog();
            for (int i = 0; i < data.Length; i++)
            {
                log += string.Format("<br />{0}. {1}", i + 1, data[i]);
            }
            ltrLog.Text = log;
        }

        protected void btnXem_Click(object sender, EventArgs e)
        {
            string log = "";
            var data = new Log_he_thong.LogHeThong().GetLog(DateTime.Parse(date.Value));
            for (int i = 0; i < data.Length; i++)
            {
                log += string.Format("<br />{0}. {1}", i + 1, data[i]);
            }
            ltrLog.Text = log;
        }


    }
}