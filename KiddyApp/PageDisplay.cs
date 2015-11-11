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
        PageProvider curProvider;
        Page curPage;
        DisplayCard clicked;

        public PageDisplay()
        {
            InitializeComponent();

            WindowState = FormWindowState.Maximized;

            Card.loadCards();

            Random r=new Random(0);
            curProvider = new PageProviders.MainMenu();
            curPage = curProvider.CurrentPage;
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

        private void PageDisplay_MouseDown(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < curPage.Rows.Length; i++)
            {
                DisplayCard tmpCard = curPage.Rows[i].Click(e.X, e.Y);
                if (tmpCard != null)
                {
                    clicked = tmpCard;
                    break;
                }
            }
        }

        private void PageDisplay_MouseUp(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < curPage.Rows.Length; i++)
            {
                DisplayCard tmpCard = curPage.Rows[i].Click(e.X, e.Y);
                if (tmpCard != null)
                {
                    if (tmpCard == clicked)
                    {
                        curPage.XClicked = e.X;
                        curPage.YClicked = e.Y;
                        curPage.RowClicked = i;
                        curPage.CardClicked = tmpCard;
                        curProvider.PageClicked(curPage);

                        curPage = curProvider.CurrentPage;
                        while (curPage == null)
                        {
                            curProvider = curProvider.NextProvider;
                            curPage = curProvider.CurrentPage;
                        }

                        Text = "KiddyApp: " + curProvider.Name;

                        Invalidate();
                    }
                }
            }
        }
    }
}
