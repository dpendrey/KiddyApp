using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp
{
    public abstract class PageProvider
    {
        public abstract string Name { get; }

        public abstract PageProvider NextProvider { get; }

        public abstract Page CurrentPage { get; }

        public abstract void PageClicked(Page Clicked);
    }
}
