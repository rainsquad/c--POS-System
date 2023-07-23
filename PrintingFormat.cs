using System.Drawing;

namespace CSharpPrinting
{

    public class PrintingFormat
    {
        private StringFormat mTopLeft = new StringFormat();
        private StringFormat mTopCenter = new StringFormat();
        private StringFormat mTopRight = new StringFormat();
        private StringFormat mMidLeft = new StringFormat();
        private StringFormat mMidCenter = new StringFormat();
        private StringFormat mMidRight = new StringFormat();
        private StringFormat mBotLeft = new StringFormat();
        private StringFormat mBotCenter = new StringFormat();
        private StringFormat mBotRight = new StringFormat();

        public Font FntTitle
        {
            get
            {
                return new Font("Arial", 12, FontStyle.Bold, GraphicsUnit.Point);
            }
        }

        public Font FntTableHeader
        {
            get
            {
                return new Font("Arial", 10, FontStyle.Bold, GraphicsUnit.Point);
            }
        }

        public Font FntTableCell
        {
            get
            {
                return new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point);
            }
        }


        public StringFormat TopLeft
        {
            get
            {
                mTopLeft.LineAlignment = StringAlignment.Near;
                mTopLeft.Alignment = StringAlignment.Near;
                return mTopLeft;
            }
        }

        public StringFormat TopCenter
        {
            get
            {
                mTopCenter.LineAlignment = StringAlignment.Near;
                mTopCenter.Alignment = StringAlignment.Center;
                return mTopCenter;
            }
        }

        public StringFormat TopRight
        {
            get
            {
                mTopRight.LineAlignment = StringAlignment.Near;
                mTopRight.Alignment = StringAlignment.Far;
                return mTopRight;
            }
        }

        public StringFormat MidLeft
        {
            get
            {
                mMidLeft.LineAlignment = StringAlignment.Center;
                mMidLeft.Alignment = StringAlignment.Near;
                return mMidLeft;
            }
        }

        public StringFormat MidCenter
        {
            get
            {
                mMidCenter.LineAlignment = StringAlignment.Center;
                mMidCenter.Alignment = StringAlignment.Center;
                return mMidCenter;
            }
        }

        public StringFormat MidRight
        {
            get
            {
                mMidRight.LineAlignment = StringAlignment.Center;
                mMidRight.Alignment = StringAlignment.Far;
                return mMidRight;
            }
        }

        public StringFormat BotLeft
        {
            get
            {
                mBotLeft.LineAlignment = StringAlignment.Far;
                mBotLeft.Alignment = StringAlignment.Near;
                return mBotLeft;
            }
        }

        public StringFormat BotCenter
        {
            get
            {
                mBotCenter.LineAlignment = StringAlignment.Far;
                mBotCenter.Alignment = StringAlignment.Center;
                return mBotCenter;
            }
        }

        public StringFormat BotRight
        {
            get
            {
                mBotRight.LineAlignment = StringAlignment.Far;
                mBotRight.Alignment = StringAlignment.Far;
                return mBotRight;
            }
        }


        public int PrintCellText(string strValue, int x, int y, int w, System.Drawing.Printing.PrintPageEventArgs e, Font Font, StringFormat Format, bool Border = false, Brush Fill = null/* TODO Change to default(_) if this is not a reference type */, int h = 0)
        {
            RectangleF cellRect = new RectangleF();
            cellRect.Location = new Point(x, y);

            if (h > 0)
                cellRect.Size = new Size(w, h);
            else
                cellRect.Size = new Size(w, 10 + (System.Convert.ToInt32(e.Graphics.MeasureString(strValue, Font, w - 10, StringFormat.GenericTypographic).Height)));


            if (Fill != null)
                e.Graphics.FillRectangle(Fill, Rectangle.Round(cellRect));

            e.Graphics.DrawString(strValue, Font, Brushes.Black, cellRect, Format);

            if (Border == true)
                e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(cellRect));
            else
                e.Graphics.DrawRectangle(Pens.Transparent, Rectangle.Round(cellRect));

            return y + (int)cellRect.Height;
        }
    }

}
