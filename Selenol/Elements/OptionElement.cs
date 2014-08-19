﻿// ﻿Copyright (c) Pavel Bakshy, Valeriy Ogiy. All rights reserved. See License.txt in the project root for license information.

using OpenQA.Selenium;

using Selenol.Validation.Element;

namespace Selenol.Elements
{
    /// <summary>The option element.</summary>
    [Tag(HtmlElements.Option)]
    public class OptionElement : BaseHtmlElement
    {
        /// <summary>Initializes a new instance of the <see cref="OptionElement"/> class.</summary>
        /// <param name="webElement">The web element.</param>
        public OptionElement(IWebElement webElement)
            : base(webElement)
        {
        }

        /// <summary>Gets the option text.</summary>
        public string Text
        {
            get
            {
                return this.WebElement.Text;
            }
        }

        /// <summary>Gets the option value.</summary>
        public string Value
        {
            get
            {
                return this.WebElement.GetAttribute(HtmlElementAttributes.Value);
            }
        }

        /// <summary>Gets a value indicating whether the option is selected or not.</summary>
        public bool IsSelected
        {
            get
            {
                return this.HasAttribute(HtmlElementAttributes.Selected);
            }
        }

        /// <summary>Selects the option.</summary>
        public void Select()
        {
            if (!this.IsSelected)
            {
                this.WebElement.Click();
            }
        }

        /// <summary>Deselects the option.</summary>
        public void Deselect()
        {
            if (this.IsSelected)
            {
                this.WebElement.Click();
            }
        }
    }
}