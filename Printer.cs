using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;

namespace CSharpPrinting
{


    public class PrintData
    {
        private int mID;
        private string mStringValue;
        private Font mFnt;
        private int[] mColumnWidth;
        private StringFormat[] mCAlign;
        private int miLeft;
        private Image mImg;

        private int mWidth;
        private int mHeight;


        public PrintData(int Id, string StringValue = "", Font Fnt = null/* TODO Change to default(_) if this is not a reference type */, int[] ColumnWidth = null, StringFormat[] CAlign = null, int iLeft = 0)
        {
            this.mID = Id;
            this.mStringValue = StringValue;
            this.mFnt = Fnt;
            this.mColumnWidth = ColumnWidth;
            this.mCAlign = CAlign;
            this.miLeft = iLeft;
        }

        public PrintData(int Id, Image img)
        {
            this.mID = Id;
            this.mImg = img;
        }

        public PrintData(int Id, Image img, int Width, int Height)
        {
            this.mID = Id;
            this.mImg = img;
            this.mWidth = Width;
            this.mHeight = Height;
        }


        public int Id
        {
            get
            {
                return mID;
            }
            set
            {
                mID = value;
            }
        }

        public string StringValue
        {
            get
            {
                return mStringValue;
            }
            set
            {
                mStringValue = value;
            }
        }

        public Font Fnt
        {
            get
            {
                return mFnt;
            }
            set
            {
                mFnt = value;
            }
        }

        public int[] ColumnWidth
        {
            get
            {
                return mColumnWidth;
            }
            set
            {
                mColumnWidth = value;
            }
        }

        public StringFormat[] CAlign
        {
            get
            {
                return mCAlign;
            }
            set
            {
                mCAlign = value;
            }
        }

        public int iLeft
        {
            get
            {
                return miLeft;
            }
            set
            {
                miLeft = value;
            }
        }

        public Image img
        {
            get
            {
                return mImg;
            }
            set
            {
                mImg = value;
            }
        }

        public int Width
        {
            get
            {
                return mWidth;
            }
            set
            {
                mWidth = value;
            }
        }

        public int Height
        {
            get
            {
                return mHeight;
            }
            set
            {
                mHeight = value;
            }
        }
    }

    public class PrintDatalist : CollectionBase
    {
        public PrintData Add(int Id, string StringValue, Font Fnt, int[] ColumnWidth = null, StringFormat[] CAlign = null, int iLeft = 0)
        {
            PrintData PrintData = new PrintData(Id, StringValue, Fnt, ColumnWidth, CAlign, iLeft);
            this.InnerList.Add(PrintData);
            return PrintData;
        }

        public PrintData Add(int Id, Image img)
        {
            PrintData PrintData = new PrintData(Id, img);
            this.InnerList.Add(PrintData);
            return PrintData;
        }

        public PrintData Add(int Id, Image img, int Width, int Height)
        {
            PrintData PrintData = new PrintData(Id, img, Width, Height);
            this.InnerList.Add(PrintData);
            return PrintData;
        }

        public PrintData this[int Index]
        {
            get
            {
                if (Index > this.InnerList.Count - 1 || Index < 0)
                    throw new IndexOutOfRangeException("Index out of Range");
                else
                    return (PrintData)this.InnerList[Index];
            }
        }

        public int IndexOf(int Id)
        {
            PrintData PrintData;
            int FoundIndex = -1;

            for (int i = 0; i <= this.InnerList.Count - 1; i++)
            {
                PrintData = (PrintData)this.InnerList[i];
                if (PrintData.Id == Id)
                {
                    FoundIndex = i;
                    break;
                }
            }
            return FoundIndex;
        }

        public static PrintDatalist AddItemToDataList(ref PrintDatalist PrintDatalist, int Id, string StringValue, Font Fnt, int[] ColumnWidth = null, StringFormat[] CFormat = null, int iLeft = 0)
        {
            PrintDatalist.Add(Id, StringValue, Fnt, ColumnWidth, CFormat, iLeft);
            return PrintDatalist;
        }

        public static PrintDatalist AddItemToDataList(ref PrintDatalist PrintDatalist, int Id, Image Img)
        {
            PrintDatalist.Add(Id, Img);
            return PrintDatalist;
        }

        public static PrintDatalist AddItemToDataList(ref PrintDatalist PrintDatalist, int Id, Image Img, int Width, int Height)
        {
            PrintDatalist.Add(Id, Img, Width, Height);
            return PrintDatalist;
        }
    }


    public class SendPrint
    {
        private static Queue<string> Lines = new Queue<string>();
        private static Font _myfont;
        private static System.Drawing.Printing.PrintDocument prn;
        private static PrintDatalist PrintDatalist = new PrintDatalist();
        private static PrintingFormat c = new PrintingFormat();
        private static int row = 0;

        public SendPrint()
        {
            PrintDatalist = new PrintDatalist();
            _myfont = new Font("Courier New", 8, FontStyle.Regular, GraphicsUnit.Point); // Default
            prn = new System.Drawing.Printing.PrintDocument();
            row = 0;
            prn.PrintPage += Document_PrintPage;
        }

        public static void NewPrint()
        {
            PrintDatalist = new PrintDatalist();
            _myfont = new Font("Courier New", 8, FontStyle.Regular, GraphicsUnit.Point); // Default
            prn = new System.Drawing.Printing.PrintDocument();
            row = 0;

            System.Drawing.Printing.PageSettings PS1 = new System.Drawing.Printing.PageSettings();
            {
                var withBlock = PS1;
                withBlock.PaperSize = (from s in prn.PrinterSettings.PaperSizes.Cast<PaperSize>()
                                       select s).FirstOrDefault();
                withBlock.Margins.Left = 0;
                withBlock.Margins.Right = 0;
                withBlock.Margins.Top = 0;
                withBlock.Margins.Bottom = 0;
            }
            prn.DefaultPageSettings = PS1;

            prn.PrintPage += Document_PrintPage;
        }

        public static void SetFont(string FontFamily, float emSize, FontStyle style)
        {
            _myfont = new Font(FontFamily, emSize, style, GraphicsUnit.Point);
        }

        public static void Print(string text)
        {
            PrintDatalist = PrintDatalist.AddItemToDataList(ref PrintDatalist, PrintDatalist.Count, text, _myfont);
        }

        public static void Print(string text, int[] arrWidth)
        {
            PrintDatalist = PrintDatalist.AddItemToDataList(ref PrintDatalist, PrintDatalist.Count, text, _myfont, arrWidth);
        }

        public static void Print(string text, int[] arrWidth, StringFormat[] arrFormat)
        {
            PrintDatalist = PrintDatalist.AddItemToDataList(ref PrintDatalist, PrintDatalist.Count, text, _myfont, arrWidth, arrFormat);
        }

        public static void Print(string text, int[] arrWidth, int iLeft)
        {
            PrintDatalist = PrintDatalist.AddItemToDataList(ref PrintDatalist, PrintDatalist.Count, text, _myfont, arrWidth, iLeft: iLeft);
        }

        public static void Print(Image img)
        {
            PrintDatalist = PrintDatalist.AddItemToDataList(ref PrintDatalist, PrintDatalist.Count, img);
        }

        public static void Print(Image img, int Width, int Height)
        {
            PrintDatalist = PrintDatalist.AddItemToDataList(ref PrintDatalist, PrintDatalist.Count, img, Width, Height);
        }

        public static void DoPrint()
        {
            prn.Print();
        }

        private static void Document_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int curY = e.PageSettings.Margins.Top;
            int xZero = e.PageSettings.Margins.Left;
            PrintData data = null;

            StringFormat cFormat = c.MidLeft;
            while (row < PrintDatalist.Count)
            {
                data = PrintDatalist[row];

                if (data.img != null)
                {
                    if (data.Width != 0)
                    {
                        e.Graphics.DrawImage(data.img, data.iLeft, curY);
                        curY = curY + data.Height;
                    }
                    else
                    {
                        e.Graphics.DrawImage(data.img, data.iLeft, curY, data.Width, data.Height);
                        curY = curY + data.Height;
                    }
                }
                else if (data.StringValue == "---")
                {
                    e.Graphics.DrawLine(Pens.Black, xZero, curY, e.PageBounds.Width - e.PageSettings.Margins.Right, curY);
                }
                else if (data.ColumnWidth == null)
                {
                    cFormat = c.MidLeft;
                    if (data.CAlign != null)
                        cFormat = data.CAlign[0];
                    if (data.iLeft > 0)
                        curY = c.PrintCellText(data.StringValue, data.iLeft, curY, e.PageBounds.Width, e, data.Fnt, cFormat, false);
                    else
                        curY = c.PrintCellText(data.StringValue, xZero, curY, e.PageBounds.Width, e, data.Fnt, cFormat, false);
                }
                else
                {
                    string[] words = data.StringValue.Split(new char[] { ';' });
                    int iWidth; int iCol = 0; int x = xZero;
                    if (data.iLeft > 0)
                        x = data.iLeft;
                    int iMore; int y = curY;
                    int iFormat = 0;
                    foreach (string wrd in words)
                    {
                        if (iCol > data.ColumnWidth.Count() - 1)
                            iCol = 0;
                        iWidth = data.ColumnWidth[iCol];
                        if (data.CAlign != null)
                        {
                            if (iFormat > data.CAlign.Count() - 1)
                                iFormat = 0;
                            if (iFormat < data.CAlign.Length)
                                cFormat = data.CAlign[iFormat];
                        }
                        iMore = c.PrintCellText(wrd, x, y, iWidth, e, data.Fnt, cFormat, false);

                        if (iMore > curY)
                            curY = iMore;
                        iCol = iCol + 1;
                        iFormat = iFormat + 1;
                        x = x + iWidth;
                    }
                }
                row = row + 1;
                if (curY >= 0.99 * e.PageBounds.Height)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
        }
    }

}
