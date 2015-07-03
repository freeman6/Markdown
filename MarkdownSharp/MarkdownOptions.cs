﻿/*
 * MarkdownSharp
 * -------------
 * a C# Markdown processor
 * 
 * Markdown is a text-to-HTML conversion tool for web writers
 * Copyright (c) 2004 John Gruber
 * http://daringfireball.net/projects/markdown/
 * 
 * Markdown.NET
 * Copyright (c) 2004-2009 Milan Negovan
 * http://www.aspnetresources.com
 * http://aspnetresources.com/blog/markdown_announced.aspx
 * 
 * MarkdownSharp
 * Copyright (c) 2009-2011 Jeff Atwood
 * http://stackoverflow.com
 * http://www.codinghorror.com/blog/
 * http://code.google.com/p/markdownsharp/
 * 
 * History: Milan ported the Markdown processor to C#. He granted license to me so I can open source it
 * and let the community contribute to and improve MarkdownSharp.
 * 
 * For the full copyright and license information,
 * view the LICENSE file that was distributed with this source code.
 */


namespace MarkdownSharp
{
    public class MarkdownOptions
    {
        /// <summary>
        /// when true, (most) bare plain URLs are auto-hyperlinked  
        /// WARNING: this is a significant deviation from the markdown spec
        /// </summary>
        public bool AutoHyperlink { get; set; }
        /// <summary>
        /// when true, RETURN becomes a literal newline  
        /// WARNING: this is a significant deviation from the markdown spec
        /// </summary>
        public bool AutoNewlines { get; set; }
        /// <summary>
        /// use ">" for HTML output, or " />" for XHTML output
        /// </summary>
        public string EmptyElementSuffix { get; set; }
        /// <summary>
        /// when false, email addresses will never be auto-linked  
        /// WARNING: this is a significant deviation from the markdown spec
        /// </summary>
        public bool LinkEmails { get; set; }
        /// <summary>
        /// when true, bold and italic require non-word characters on either side  
        /// WARNING: this is a significant deviation from the markdown spec
        /// </summary>
        public bool StrictBoldItalic { get; set; }

        /// <summary>
        /// when true, asterisks may be used for intraword emphasis
        /// this does nothing if StrictBoldItalic is false
        /// </summary>
        public bool AsteriskIntraWordEmphasis { get; set; }
    }
}
