// WARNING: Auto generated code. Modifications will be lost!
#nullable enable
// This file is part of YamlDotNet - A .NET library for YAML.
// Copyright (c) Antoine Aubry and contributors
//
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies
// of the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

namespace Unity.Services.Multiplay.Authoring.YamlDotNet.Core.Events
{
    /// <summary>
    /// Contains the behavior that is common between node events.
    /// </summary>
    abstract class NodeEvent : ParsingEvent
    {
        /// <summary>
        /// Gets the anchor.
        /// </summary>
        /// <value></value>
        public AnchorName Anchor { get; }

        /// <summary>
        /// Gets the tag.
        /// </summary>
        /// <value></value>
        public TagName Tag { get; }

        /// <summary>
        /// Gets a value indicating whether this instance is canonical.
        /// </summary>
        /// <value></value>
        public abstract bool IsCanonical
        {
            get;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeEvent"/> class.
        /// </summary>
        /// <param name="anchor">The anchor.</param>
        /// <param name="tag">The tag.</param>
        /// <param name="start">The start position of the event.</param>
        /// <param name="end">The end position of the event.</param>
        protected NodeEvent(AnchorName anchor, TagName tag, Mark start, Mark end)
            : base(start, end)
        {
            this.Anchor = anchor;
            this.Tag = tag;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NodeEvent"/> class.
        /// </summary>
        protected NodeEvent(AnchorName anchor, TagName tag)
            : this(anchor, tag, Mark.Empty, Mark.Empty)
        {
        }
    }
}

#nullable disable
