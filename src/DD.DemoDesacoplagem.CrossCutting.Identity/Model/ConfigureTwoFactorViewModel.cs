﻿using System.Collections.Generic;

namespace DD.DemoDesacoplagem.Infra.CrossCutting.Identity.Model
{
    public class ConfigureTwoFactorViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<string> Providers { get; set; }
    }
}