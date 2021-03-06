﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Stratiteq.DeployVersionInfo.Controllers;

namespace Stratiteq.DeployVersionInfo
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var dc = new DeployController();
            var deployInfo = dc.Get();
            VersionList.DataSource = deployInfo;
            VersionList.DataBind();
        }
    }
}