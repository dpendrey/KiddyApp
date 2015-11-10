using System;
using System.Collections.Generic;
using System.Text;

namespace KiddyApp
{
    public abstract class Story
    {
        public int CurrentPage = 0;
        public abstract void PageFinished(Page Page);
        public abstract Page GetCurrentPage();
    }
}
