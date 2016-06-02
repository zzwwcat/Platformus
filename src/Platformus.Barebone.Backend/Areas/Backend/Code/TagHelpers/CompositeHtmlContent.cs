﻿// Copyright © 2015 Dmitry Sikorsky. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.IO;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Html;

namespace Platformus.Barebone.Backend
{
  public class CompositeHtmlContent : IHtmlContent
  {
    private IHtmlContent[] htmlContents;

    public CompositeHtmlContent(params IHtmlContent[] htmlContents)
    {
      this.htmlContents = htmlContents;
    }

    public void WriteTo(TextWriter writer, HtmlEncoder encoder)
    {
      foreach (IHtmlContent htmlContent in this.htmlContents)
        htmlContent.WriteTo(writer, encoder);
    }
  }
}