using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KiddyApp
{
    public partial class PageDisplay : Form
    {
        Story story;
        Page curPage;

        public PageDisplay()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            Card.loadCards();

            Random r=new Random(0);
            story = new Stories.FarmVisit(r);
            curPage = story.GetCurrentPage();
        }

        private void PageDisplay_Paint(object sender, PaintEventArgs e)
        {
            // Clear background
            e.Graphics.Clear(curPage.Background);

            // Determine page height
            float pageHeight = curPage.PageHeight(e.Graphics);
            float curY = (ClientSize.Height - pageHeight) / 2;

            // Draw each row in turn
            for (int i = 0; i < curPage.Rows.Length; i++)
            {
                curPage.Rows[i].DrawRow(e.Graphics, curY, ClientSize.Width);
                curY += curPage.Rows[i].RowHeight(e.Graphics);
            }
        }
    }
}
