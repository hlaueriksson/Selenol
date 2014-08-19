﻿// ﻿Copyright (c) Pavel Bakshy, Valeriy Ogiy. All rights reserved. See License.txt in the project root for license information.

using OpenQA.Selenium;

using Selenol.Validation.Element;

namespace Selenol.Elements
{
    /// <summary>The table cell element.</summary>
    [Tag(HtmlElements.TableHeaderCell)]
    [Tag(HtmlElements.TableCell)]
    public class TableCellElement : ContainerElement
    {
        /// <summary>Initializes a new instance of the <see cref="TableCellElement"/> class.</summary>
        /// <param name="webElement">The web element.</param>
        public TableCellElement(IWebElement webElement)
            : base(webElement)
        {
            this.ParentRow = this.Parent.As<TableRowElement>();
            this.Index = -1;
        }

        /// <summary>Initializes a new instance of the <see cref="TableCellElement"/> class.</summary>
        /// <param name="webElement">The web element. </param>
        /// <param name="parent">The parent row. </param>
        /// <param name="index">The index. </param>
        public TableCellElement(IWebElement webElement, TableRowElement parent, int index)
            : base(webElement)
        {
            this.ParentRow = parent;
            this.Index = index;
        }

        /// <summary>Gets the parent row.</summary>
        public TableRowElement ParentRow { get; private set; }

        /// <summary>Gets the index.</summary>
        public int Index { get; private set; }
    }
}