﻿using PropertyChanged;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSRT.Astra
{
    [AddINotifyPropertyChangedInterface]
    class OptionsWindowViewModel
    {
        public string TelepipeProxyUrl { get; set; } = Properties.Settings.Default.TelepipeProxyUrl;

        public bool TelepipeProxyUrlValid
            => string.IsNullOrWhiteSpace(TelepipeProxyUrl)
            || (Uri.TryCreate(TelepipeProxyUrl, UriKind.Absolute, out var uri) && (uri.Scheme == Uri.UriSchemeHttp || uri.Scheme == Uri.UriSchemeHttps));

        public bool SettingsValid => TelepipeProxyUrlValid;
    }
}