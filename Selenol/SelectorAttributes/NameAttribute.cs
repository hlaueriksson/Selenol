﻿// ﻿Copyright (c) Pavel Bakshy, Valeriy Ogiy. All rights reserved. See License.txt in the project root for license information.

using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Selenol.Controls;
using Selenol.Elements;
using Selenol.Page;

namespace Selenol.SelectorAttributes
{
    /// <summary>
    /// The Name selector attribute. Can be used for dynamic selection of elements or controls by their name. 
    /// An Element must be derived from <see cref="BaseHtmlElement"/> 
    /// or it can be a collection assignable from <see cref="ReadOnlyCollection{T}"/>.
    /// And used as an auto-property of class derived from <see cref="BasePage"/>.
    /// A Control must be derived from <see cref="Control"/> 
    /// or it can be a collection assignable from <see cref="ReadOnlyCollection{TControl}"/>.
    /// </summary>
    public class NameAttribute : BaseSelectorAttribute
    {
        /// <summary>Initializes a new instance of the <see cref="NameAttribute"/> class.</summary>
        /// <param name="name">The name attribute selector.</param>
        public NameAttribute(string name)
            : base(name)
        {
        }

        /// <summary>Gets the <see cref="By.Name"/> selector.</summary>
        public override By Selector
        {
            get
            {
                return By.Name(this.Value);
            }
        }
    }
}