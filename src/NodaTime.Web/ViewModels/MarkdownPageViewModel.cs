﻿// Copyright 2019 The Noda Time Authors. All rights reserved.
// Use of this source code is governed by the Apache License 2.0,
// as found in the LICENSE.txt file.

using Microsoft.AspNetCore.Html;
using NodaTime.Web.Models;

namespace NodaTime.Web.ViewModels
{
    public class MarkdownPageViewModel
    {
        public IHtmlContent TryDotNetSrc { get; }
        public MarkdownPage Page { get; }

        public MarkdownPageViewModel(IHtmlContent tryDotNetSrc, MarkdownPage page) =>
            (TryDotNetSrc, Page) = (tryDotNetSrc, page);
    }
}
