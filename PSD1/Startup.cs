﻿using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PSD1.Startup))]
namespace PSD1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
