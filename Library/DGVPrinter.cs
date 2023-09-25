using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using System.Drawing.Imaging;

[module: CLSCompliant(true)]
namespace DataGridViewPrinter
{
    public class imageadress
    {
        public static int ImageHeight;
        public static int ImageWidth;
        public static string adress;

    }
    public class DGVPrinter
    {

        //---------------------------------------------------------------------
        // global variables
        //---------------------------------------------------------------------
        #region global variables

        // the data grid view we're printing
        DataGridView dgv = null;

        // print document
        PrintDocument printDoc = null;

        // print status items
        IList rowstoprint;
        IList colstoprint;
        int lastrowprinted = -1;
        int fromPage = 0;
        int toPage = -1;

        // page formatting options
        int pageHeight = 0;
        int pageWidth = 0;
        int printWidth = 0;
        float rowheaderwidth = 0;
        int CurrentPage = 0;
        PrintRange printRange;

        // calculated values
        private float headerHeight = 0;
        private float footerHeight = 0;
        private float pagenumberHeight = 0;
        private float colheaderheight = 0;
        private float coltotalwidth = 0;
        private List<float> rowheights;
        private List<float> colwidths;
        #endregion

        //---------------------------------------------------------------------
        // properties - settable by user
        //---------------------------------------------------------------------
        #region properties

        // Title
        #region title properties

        // override flag
        bool overridetitleformat = false;

        /// <summary>
        /// Title for this report. Default is empty.
        /// </summary>
        private String title;
        public String Title
        {
            get { return title; }
            set { title = value; printDoc.DocumentName = title; }
        }

        /// <summary>
        /// Font for the title. Default is Tahoma, 18pt.
        /// </summary>
        private Font titlefont;
        public Font TitleFont
        {
            get { return titlefont; }
            set { titlefont = value; }
        }

        /// <summary>
        /// Foreground color for the title. Default is Black
        /// </summary>
        private Color titlecolor;
        public Color TitleColor
        {
            get { return titlecolor; }
            set { titlecolor = value; }
        }

        /// <summary>
        /// Allow the user to override the title string alignment. Default value is 
        /// Alignment - Near; 
        /// </summary>
        private StringAlignment titlealignment;
        public StringAlignment TitleAlignment
        {
            get { return titlealignment; }
            set { titlealignment = value; overridetitleformat = true; }
        }

        /// <summary>
        /// Allow the user to override the title string format flags. Default values
        /// are: FormatFlags - NoWrap, LineLimit, NoClip
        /// </summary>
        private StringFormatFlags titleformatflags;
        public StringFormatFlags TitleFormatFlags
        {
            get { return titleformatflags; }
            set { titleformatflags = value; overridetitleformat = true; }
        }
        #endregion

        // SubTitle
        #region subtitle properties

        // override flat
        bool overridesubtitleformat = false;

        /// <summary>
        /// SubTitle for this report. Default is empty.
        /// </summary>
        private String subtitle;
        public String SubTitle
        {
            get { return subtitle; }
            set { subtitle = value; }
        }

        /// <summary>
        /// Font for the subtitle. Default is Tahoma, 12pt.
        /// </summary>
        private Font subtitlefont;
        public Font SubTitleFont
        {

            get { return subtitlefont; }
            set { subtitlefont = value; }
        }

        /// <summary>
        /// Foreground color for the subtitle. Default is Black
        /// </summary>
        private Color subtitlecolor;
        public Color SubTitleColor
        {
            get { return subtitlecolor; }
            set { subtitlecolor = value; }
        }

        /// <summary>
        /// Allow the user to override the subtitle string alignment. Default value is 
        /// Alignment - Near; 
        /// </summary>
        private StringAlignment subtitlealignment;
        public StringAlignment SubTitleAlignment
        {
            get { return subtitlealignment; }
            set { subtitlealignment = value; overridesubtitleformat = true; }
        }

        /// <summary>
        /// Allow the user to override the subtitle string format flags. Default values
        /// are: FormatFlags - NoWrap, LineLimit, NoClip
        /// </summary>
        private StringFormatFlags subtitleformatflags;
        public StringFormatFlags SubTitleFormatFlags
        {
            get { return subtitleformatflags; }
            set { subtitleformatflags = value; overridesubtitleformat = true; }
        }
        #endregion

        // Footer
        #region footer properties

        // override flag
        bool overridefooterformat = false;

        /// <summary>
        /// footer for this report. Default is empty.
        /// </summary>
        private String footer;
        public String Footer
        {
            get { return footer; }
            set { footer = value; }
        }

        /// <summary>
        /// Font for the footer. Default is Tahoma, 10pt.
        /// </summary>
        private Font footerfont;
        public Font FooterFont
        {
            get { return footerfont; }
            set { footerfont = value; }
        }

        /// <summary>
        /// Foreground color for the footer. Default is Black
        /// </summary>
        private Color footercolor;
        public Color FooterColor
        {
            get { return footercolor; }
            set { footercolor = value; }
        }

        /// <summary>
        /// Allow the user to override the footer string alignment. Default value is 
        /// Alignment - Center; 
        /// </summary>
        private StringAlignment footeralignment;
        public StringAlignment FooterAlignment
        {
            get { return footeralignment; }
            set { footeralignment = value; overridefooterformat = true; }
        }

        /// <summary>
        /// Allow the user to override the footer string format flags. Default values
        /// are: FormatFlags - NoWrap, LineLimit, NoClip
        /// </summary>
        private StringFormatFlags footerformatflags;
        public StringFormatFlags FooterFormatFlags
        {
            get { return footerformatflags; }
            set { footerformatflags = value; overridefooterformat = true; }
        }

        private float footerspacing;
        public float FooterSpacing
        {
            get { return footerspacing; }
            set { footerspacing = value; }
        }
        #endregion

        // Page Numbering
        #region page number properties

        // override flag
        bool overridepagenumberformat = false;

        /// <summary>
        /// Include page number in the printout. Default is true.
        /// </summary>
        private bool pageno = true;
        public bool PageNumbers
        {
            get { return pageno; }
            set { pageno = value; }
        }

        /// <summary>
        /// Font for the page number, Default is Tahoma, 8pt.
        /// </summary>
        private Font pagenofont;
        public Font PageNumberFont
        {
            get { return pagenofont; }
            set { pagenofont = value; }
        }

        /// <summary>
        /// Text color (foreground) for the page number. Default is Black
        /// </summary>
        private Color pagenocolor;
        public Color PageNumberColor
        {
            get { return pagenocolor; }
            set { pagenocolor = value; }
        }

        /// <summary>
        /// Allow the user to override the page number string alignment. Default value is 
        /// Alignment - Near; 
        /// </summary>
        private StringAlignment pagenumberalignment;
        public StringAlignment PageNumberAlignment
        {
            get { return pagenumberalignment; }
            set { pagenumberalignment = value; overridepagenumberformat = true; }
        }

        /// <summary>
        /// Allow the user to override the pagenumber string format flags. Default values
        /// are: FormatFlags - NoWrap, LineLimit, NoClip
        /// </summary>
        private StringFormatFlags pagenumberformatflags;
        public StringFormatFlags PageNumberFormatFlags
        {
            get { return pagenumberformatflags; }
            set { pagenumberformatflags = value; overridepagenumberformat = true; }
        }

        /// <summary>
        /// Allow the user to select whether to have the page number at the top or bottom
        /// of the page. Default is false: page numbers on the bottom of the page
        /// </summary>
        private bool pagenumberontop = false;
        public bool PageNumberInHeader
        {
            get { return pagenumberontop; }
            set { pagenumberontop = value; }
        }

        /// <summary>
        /// Should the page number be printed on a separate line, or printed on the
        /// same line as the header / footer? Default is false;
        /// </summary>
        private bool pagenumberonseparateline = false;
        public bool PageNumberOnSeparateLine
        {
            get { return pagenumberonseparateline; }
            set { pagenumberonseparateline = value; }
        }


        #endregion

        // Header Cell Printing 
        #region header cell properties

        // override flag
        bool overridecellheaderformat;

        /// <summary>
        /// Allow the user to override the header cell string alignment. Default value is 
        /// Alignment - Near; 
        /// </summary>
        private StringAlignment headercellalignment;
        public StringAlignment HeaderCellAlignment
        {
            get { return headercellalignment; }
            set { headercellalignment = value; overridecellheaderformat = true; }
        }

        /// <summary>
        /// Allow the user to override the header cell string format flags. Default values
        /// are: FormatFlags - NoWrap, LineLimit, NoClip
        /// </summary>
        private StringFormatFlags headercellformatflags;
        public StringFormatFlags HeaderCellFormatFlags
        {
            get { return headercellformatflags; }
            set { headercellformatflags = value; overridecellheaderformat = true; }
        }
        #endregion

        // Individual Cell Printing
        #region cell properties
        bool overridecellformat = true;

        /// <summary>
        /// Allow the user to override the cell string alignment. Default value is 
        /// Alignment - Near; 
        /// </summary>
        private StringAlignment cellalignment;
        public StringAlignment CellAlignment
        {
            get { return cellalignment; }
            set { cellalignment = value; overridecellformat = true; }
        }

        /// <summary>
        /// Allow the user to override the cell string format flags. Default values
        /// are: FormatFlags - NoWrap, LineLimit, NoClip
        /// </summary>
        private StringFormatFlags cellformatflags;
        public StringFormatFlags CellFormatFlags
        {
            get { return cellformatflags; }
            set { cellformatflags = value; overridecellformat = true; }
        }
        #endregion

        // Page Level Properties
        #region page level properties

        /// <summary>
        /// Page margins override. Default is (60, 60, 40, 40)
        /// </summary>
        private Margins printmargins;
        public Margins PrintMargins
        {
            get { return printmargins; }
            set { printmargins = value; }
        }

        /// <summary>
        /// Spread the columns porportionally accross the page. Default is false.
        /// </summary>
        private bool porportionalcolumns = false;
        public bool PorportionalColumns
        {
            get { return porportionalcolumns = false; }
            set { porportionalcolumns = value; }
        }
        #endregion

        #endregion

        /// <summary>
        /// Constructor for DGVPrinter
        /// </summary>
        public DGVPrinter()
        {
            //opimage
            // create print document
            printDoc = new PrintDocument();
            printDoc.PrintPage += new PrintPageEventHandler(printDoc_PrintPage);
            printmargins = new Margins(60, 60, 160, 40);

            // set default fonts
            pagenofont = new Font("tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            pagenocolor = Color.Black;
            titlefont = new Font("Tahoma", 18, FontStyle.Bold, GraphicsUnit.Point);
            titlecolor = Color.Black;
            subtitlefont = new Font("Tahoma", 12, FontStyle.Bold, GraphicsUnit.Point);
            subtitlecolor = Color.Black;
            footerfont = new Font("Tahoma", 10, FontStyle.Bold, GraphicsUnit.Point);
            footercolor = Color.Black;

            // set default string formats
            titlealignment = StringAlignment.Center;
            titleformatflags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            subtitlealignment = StringAlignment.Center;
            subtitleformatflags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            footeralignment = StringAlignment.Center;
            footerformatflags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            pagenumberalignment = StringAlignment.Far;
            pagenumberformatflags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            headercellalignment = StringAlignment.Near;
            headercellformatflags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            cellalignment = StringAlignment.Near;
            cellformatflags = StringFormatFlags.NoWrap | StringFormatFlags.LineLimit | StringFormatFlags.NoClip;


        }

        /// <summary>
        /// Start the printing process, print to a printer.
        /// </summary>
        /// <param name="dgv">The DataGridView to print</param>
        /// NOTE: Any changes to this method also need to be done in PrintPreviewDataGridView
        public void PrintDataGridView(DataGridView dgv)
        {
            // save the datagridview we're printing
            this.dgv = dgv;

            // create new print dialog
            PrintDialog pd = new PrintDialog();
            pd.Document = printDoc;
            printDoc.DefaultPageSettings.Margins = printmargins;
            pd.AllowCurrentPage = true;
            pd.AllowSelection = true;
            pd.AllowSomePages = true;
            pd.AllowPrintToFile = false;

            // show print dialog
            if (DialogResult.OK == pd.ShowDialog())
            {
                SetupPrint(pd);

                printDoc.Print();
            }
        }

        /// <summary>
        /// Start the printing process, print to a print preview dialog
        /// </summary>
        /// <param name="dgv">The DataGridView to print</param>
        /// NOTE: Any changes to this method also need to be done in PrintDataGridView
        public void PrintPreviewDataGridView(DataGridView dgv)
        {
            // save the datagridview we're printing
            this.dgv = dgv;

            // create new print dialog and set options
            PrintDialog pd = new PrintDialog();
            pd.Document = printDoc;
            printDoc.DefaultPageSettings.Margins = printmargins;
            pd.AllowSelection = true;
            pd.AllowSomePages = true;
            pd.AllowCurrentPage = true;
            pd.AllowPrintToFile = false;

            // show print dialog
            if (DialogResult.OK == pd.ShowDialog())
            {
                SetupPrint(pd);
                PrintPreviewDialog ppdialog = new PrintPreviewDialog();
                ppdialog.Document = printDoc;
                ppdialog.WindowState = FormWindowState.Maximized;
                ppdialog.PrintPreviewControl.Zoom = 1.0;
                ppdialog.ShowDialog();




                //' 0.75 = 75 %
                // ' 1.0 = 100 %
                //  ' 1.5 = 150 %

            }
        }

        /// <summary>
        /// Set up the print job. Save information from print dialog
        /// and print document for easy access. Also sets up the rows
        /// and columns that will be printed.
        /// </summary>
        /// <param name="pd">The print dialog the user just filled out</param>
        void SetupPrint(PrintDialog pd)
        {
            //-----------------------------------------------------------------
            // save data from print dialog and document
            //-----------------------------------------------------------------

            // check to see if we're doing landscape printing 
            if (printDoc.DefaultPageSettings.Landscape)
            {
                // landscape: switch width and height
                pageHeight = printDoc.DefaultPageSettings.PaperSize.Width;
                pageWidth = printDoc.DefaultPageSettings.PaperSize.Height;
            }
            else
            {
                // portrait: keep width and height as expected
                pageHeight = printDoc.DefaultPageSettings.PaperSize.Height;
                pageWidth = printDoc.DefaultPageSettings.PaperSize.Width;
            }

            // save printer margins and calc print width
            printmargins = printDoc.DefaultPageSettings.Margins;
            printWidth = pageWidth - printmargins.Left - printmargins.Right;

            // save print range 
            printRange = pd.PrinterSettings.PrintRange;

            // pages to print handles "some pages" option
            if (PrintRange.SomePages == printRange)
            {
                // set limits to only print some pages
                fromPage = pd.PrinterSettings.FromPage;
                toPage = pd.PrinterSettings.ToPage;
            }
            else
            {
                // set extremes so that we'll print all pages
                fromPage = 0;
                toPage = 2147483647;
            }

            //-----------------------------------------------------------------
            // set up the rows and columns to print
            //-----------------------------------------------------------------

            // rows to print (handles "selection" and "current page" options
            if (PrintRange.Selection == printRange)
            {
                // if DGV has rows selected, it's easy, selected rows and all visible columns
                if (0 != dgv.SelectedRows.Count)
                {
                    rowstoprint = dgv.SelectedRows;
                    colstoprint = new List<object>(dgv.Columns.Count);
                    foreach (DataGridViewColumn col in dgv.Columns) if (col.Visible) colstoprint.Add(col);
                }
                // if selected columns, then all rows, and selected columns
                else if (0 != dgv.SelectedColumns.Count)
                {
                    rowstoprint = dgv.Rows;
                    colstoprint = dgv.SelectedColumns;
                }
                // we just have a bunch of selected cells so we have to do some work
                else
                {
                    // set up sorted lists. the selectedcells method does not guarantee
                    // that the cells will always be in left-right top-bottom order. 
                    SortedList temprowstoprint = new SortedList(dgv.SelectedCells.Count);
                    SortedList tempcolstoprint = new SortedList(dgv.SelectedCells.Count);

                    // for each selected cell, add unique rows and columns
                    int colindex, rowindex;
                    foreach (DataGridViewCell cell in dgv.SelectedCells)
                    {
                        colindex = cell.ColumnIndex;
                        rowindex = cell.RowIndex;

                        if (!temprowstoprint.Contains(rowindex))
                            temprowstoprint.Add(rowindex, dgv.Rows[rowindex]);

                        if (!tempcolstoprint.Contains(colindex))
                            tempcolstoprint.Add(colindex, dgv.Columns[colindex]);
                    }

                    // Move the now-sorted columns and rows to our list of what to print
                    rowstoprint = new List<object>(temprowstoprint.Count);
                    foreach (object item in temprowstoprint.Values) rowstoprint.Add(item);
                    colstoprint = new List<object>(tempcolstoprint.Count);
                    foreach (object item in tempcolstoprint.Values) colstoprint.Add(item);
                }
            }
            // if current page was selected, print visible columns for the
            // displayed rows                
            else if (PrintRange.CurrentPage == printRange)
            {
                // create lists
                rowstoprint = new List<object>(dgv.DisplayedRowCount(true));
                colstoprint = new List<object>(dgv.Columns.Count);

                // select all visible rows on displayed page
                for (int i = dgv.FirstDisplayedScrollingRowIndex;
                    i < dgv.FirstDisplayedScrollingRowIndex + dgv.DisplayedRowCount(true);
                    i++)
                {
                    DataGridViewRow row = dgv.Rows[i];
                    if (row.Visible) rowstoprint.Add(row);
                }

                // select all visible columns
                colstoprint = new List<object>(dgv.Columns.Count);
                foreach (DataGridViewColumn col in dgv.Columns) if (col.Visible) colstoprint.Add(col);
            }
            // this is the default for print all - everything marked visible will be printed
            else
            {
                // select all visible rows and all visible columns
                rowstoprint = new List<object>(dgv.Rows.Count);
                foreach (DataGridViewRow row in dgv.Rows) if (row.Visible) rowstoprint.Add(row);

                colstoprint = new List<object>(dgv.Columns.Count);
                foreach (DataGridViewColumn col in dgv.Columns) if (col.Visible) colstoprint.Add(col);
            }
        }

        /// <summary>
        /// Centralize the string format settings. Does the work of checking for user
        /// overrides, and if they're not present, setting the cell alignment to match
        /// (somewhat) the source control's string alignment.
        /// </summary>
        /// <param name="alignment">String alignment</param>
        /// <param name="flags">String format flags</param>
        /// <param name="controlstyle">DataGridView style to apply (if available)</param>
        /// <param name="overrideformat">True if user overrode alignment or flags</param>
        /// <returns></returns>
        private static StringFormat managestringformat(StringAlignment alignment, StringFormatFlags flags,
            DataGridViewCellStyle controlstyle, bool overrideformat)
        {
            // start with the provided
            StringFormat format = new StringFormat();
            format.Trimming = StringTrimming.Word;
            format.Alignment = alignment;
            format.FormatFlags = flags;

            // if the format was overridded by the user, make no adjustments
            if (!overrideformat)
            {
                // check to see if a style is provided
                if (null != controlstyle)
                {
                    // Adjust the format based on the control settings, bias towards centered
                    DataGridViewContentAlignment cellalign = controlstyle.Alignment;
                    if (cellalign.ToString().Contains("Middle")) format.Alignment = StringAlignment.Center;
                    else if (cellalign.ToString().Contains("Right")) format.Alignment = StringAlignment.Near;
                    else if (cellalign.ToString().Contains("Left")) format.Alignment = StringAlignment.Far;

                }
            }

            return format;
        }

        /// <summary>
        /// Scan all the rows and columns to be printed and calculate the 
        /// overall individual column width (based on largest column value), 
        /// the header sizes, and determine all the row heights.
        /// </summary>
        /// <param name="g">The graphics context for all measurements</param>
        private void measureprintarea(Graphics g)
        {
            int i, j;
            rowheights = new List<float>(rowstoprint.Count);
            colwidths = new List<float>(colstoprint.Count);
            headerHeight = 0;
            footerHeight = 0;

            // temp variables
            DataGridViewColumn col;
            DataGridViewRow row;

            //-----------------------------------------------------------------
            // measure the page headers and footers, including the grid column header cells
            //-----------------------------------------------------------------

            // measure the column headers
            Font headerfont = dgv.ColumnHeadersDefaultCellStyle.Font;
            if (null == headerfont)
                headerfont = dgv.DefaultCellStyle.Font;

            // set initial column sizes based on column titles
            for (i = 0; i < colstoprint.Count; i++)
            {
                col = (DataGridViewColumn)colstoprint[i];

                // measure the title for each column, keep widths and biggest height
                SizeF size = g.MeasureString(col.HeaderText, headerfont);
                colwidths.Add(size.Width);
                colheaderheight = (colheaderheight < size.Height ? size.Height : colheaderheight);
            }

            //-----------------------------------------------------------------
            // measure the page number
            //-----------------------------------------------------------------

            if (pageno)
            {
                StringFormat format = managestringformat(pagenumberalignment, pagenumberformatflags,
                    dgv.DefaultCellStyle, overridetitleformat);
                pagenumberHeight = (g.MeasureString("Page", pagenofont, printWidth, format)).Height;
            }


            //-----------------------------------------------------------------
            // Calc height of header.
            // Header height is height of page number, title, subtitle and height of column headers
            //-----------------------------------------------------------------

            // note that we dont count the page number height if it's not on a separate line
            if (pagenumberontop && !pagenumberonseparateline)
            {
                headerHeight += pagenumberHeight;
            }

            if (!String.IsNullOrEmpty(title))
            {
                StringFormat format = managestringformat(titlealignment, titleformatflags,
                    null, overridetitleformat);
                headerHeight += (g.MeasureString(title, titlefont, printWidth, format)).Height;
            }

            if (!String.IsNullOrEmpty(subtitle))
            {
                StringFormat format = managestringformat(subtitlealignment, subtitleformatflags,
                    null, overridetitleformat);
                headerHeight += (g.MeasureString(subtitle, subtitlefont, printWidth, format)).Height;
            }

            headerHeight += colheaderheight;

            //-----------------------------------------------------------------
            // measure the footer, if one is provided. Include the page number if we're printing
            // it on the bottom
            //-----------------------------------------------------------------

            if (!String.IsNullOrEmpty(footer))
            {
                StringFormat format = managestringformat(footeralignment, footerformatflags,
                    null, overridefooterformat);
                footerHeight += (g.MeasureString(footer, footerfont, printWidth, format)).Height;
            }

            // note we don't count the page number height if it's not on a separate line
            if (!pagenumberontop && !pagenumberonseparateline)
            {
                footerHeight += pagenumberHeight;
            }

            footerHeight += footerspacing;

            //-----------------------------------------------------------------
            // measure the grid to be printed ... this gets us all the row heights
            // and an accurate measure of column widths for the printed area
            //-----------------------------------------------------------------

            Font defaultfont = dgv.DefaultCellStyle.Font;
            Font cellfont;

            for (i = 0; i < rowstoprint.Count; i++)
            {
                row = (DataGridViewRow)rowstoprint[i];
                rowheights.Add(0);

                // add row headers if they're visible
                if (dgv.RowHeadersVisible)
                {
                    SizeF rhsize = g.MeasureString(row.HeaderCell.EditedFormattedValue.ToString(),
                        headerfont);
                    rowheaderwidth = (rowheaderwidth < rhsize.Width) ? rhsize.Width : rowheaderwidth;
                }

                // calculate widths for each column. We're looking for the largest width needed for
                // all the rows of data.
                for (j = 0; j < colstoprint.Count; j++)
                {
                    col = (DataGridViewColumn)colstoprint[j];

                    if (row.Cells[col.Name].HasStyle && (null != row.Cells[col.Name].Style.Font))
                        cellfont = row.Cells[col.Name].Style.Font;
                    else
                        cellfont = defaultfont;

                    SizeF size = g.MeasureString(row.Cells[col.Name].EditedFormattedValue.ToString(),
                        cellfont);
                    colwidths[j] = (colwidths[j] < size.Width ? size.Width : colwidths[j]);
                    rowheights[i] = (rowheights[i] < size.Height ? size.Height : rowheights[i]);
                }
            }

            // total the column widths, including row headers. 
            coltotalwidth = rowheaderwidth;
            foreach (float w in colwidths)
                coltotalwidth += w;

            // if we're stretching the columns accross the page, recalculate each width and
            // set the total width to the printable width of the page.
            if (porportionalcolumns)
            {
                float ratio = (float)printWidth / (float)coltotalwidth;

                // adjust row header width
                rowheaderwidth = rowheaderwidth * ratio;

                // adjust data cells widths
                for (i = 0; i < colwidths.Count; i++)
                    colwidths[i] = colwidths[i] * ratio;

                // and, by definition the total width is the print width
                coltotalwidth = printWidth;
            }
        }

        /// <summary>
        /// PrintPage event handler. This routine prints one page. It will
        /// skip non-printable pages if the user selected the "some pages" option
        /// on the print dialog.
        /// </summary>
        /// <param name="sender">default object from windows</param>
        /// <param name="e">Event info from Windows about the printing</param>
        private void printDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            // flag for handling printing some pages rather than all
            bool printthispage = false;

            // current printing position
            float printpos = printmargins.Top;

            // increment page number & check page range
            CurrentPage++;
            if ((CurrentPage >= fromPage) && (CurrentPage <= toPage))
                printthispage = true;

            // if this is the first page, then measure the print area
            if (1 == CurrentPage)
                measureprintarea(e.Graphics);

            //-----------------------------------------------------------------
            // scan down heights until we're off this (non-printing) page
            //-----------------------------------------------------------------

            while (!printthispage)
            {
                // calculate and increment over the page we're not printing
                printpos = printmargins.Top + headerHeight;
                while (printpos < (pageHeight - footerHeight - printmargins.Top - printmargins.Bottom))
                {
                    lastrowprinted++;
                    printpos += rowheights[lastrowprinted];
                }

                // skip to the next page & see if it's in the print range
                CurrentPage++;
                if ((CurrentPage >= fromPage) && (CurrentPage <= toPage))
                    printthispage = true;

                // bottom check~
                if ((lastrowprinted >= rowstoprint.Count - 1) || (CurrentPage > toPage))
                {
                    // we're done here - nothing more to print
                    e.HasMorePages = false;
                    return;
                }
            }

            //-----------------------------------------------------------------
            // print headers
            //-----------------------------------------------------------------

            // reset printpos as it may have changed during the 'skip pages' routine just above.
            printpos = printmargins.Top;

            // print page number if user selected it
            if (pagenumberontop)
            {
                // if we have a page number to print
                if (pageno)
                {
                    // ... then print it
                    printsection(e.Graphics, ref printpos, "Page " + CurrentPage.ToString(CultureInfo.CurrentCulture),
                        pagenofont, pagenocolor, pagenumberalignment, pagenumberformatflags, overridepagenumberformat);

                    // if the page number is not on a separate line, don't "use up" it's vertical space
                    if (!pagenumberonseparateline)
                        printpos -= pagenumberHeight;
                }
            }

            //image adress

            // print title if provided
            if (DataGridViewPrinter.imageadress.adress != @"\")
            {

                Image imgPerson = Image.FromFile(Application.StartupPath + DataGridViewPrinter.imageadress.adress);

                e.Graphics.DrawImage(imgPerson, 350, 20, DataGridViewPrinter.imageadress.ImageWidth, DataGridViewPrinter.imageadress.ImageHeight);

            }
            //   Point p = new Point(100, 100);
            //  Point ulCorner = new Point(118, 118);
            // Pen blackPen = new Pen(Color.Black, 3);
            //  Rectangle rect = new Rectangle(320, 10, 200, 140);
            //  e.Graphics.DrawRectangle(blackPen, rect);


            if (!String.IsNullOrEmpty(title))

                printsection(e.Graphics, ref printpos, title, titlefont,
                  titlecolor, titlealignment, titleformatflags, overridetitleformat);


            //   e.Graphics.FillEllipse(Brushes.DarkGray, new Rectangle(320, 10, 200, 70));


            // Create rectangle for ellipse.


            // e.Graphics.DrawEllipse(blackPen,rect);




            // print subtitle if provided
            if (!String.IsNullOrEmpty(subtitle))
                printsection(e.Graphics, ref printpos, subtitle, subtitlefont,
                    subtitlecolor, subtitlealignment, subtitleformatflags, overridesubtitleformat);

            // print column headers
            //            printcolumnheaders(e.Graphics, ref printpos);
            printcolumnheadersRight(e.Graphics, ref printpos);

            //-----------------------------------------------------------------
            // print rows until the page is complete
            //-----------------------------------------------------------------

            while (printpos < (pageHeight - footerHeight - printmargins.Top - printmargins.Bottom))
            {
                lastrowprinted++;
                //                printrow(e.Graphics, ref printpos, (DataGridViewRow)(rowstoprint[lastrowprinted]));
                printrowRight(e.Graphics, ref printpos, (DataGridViewRow)(rowstoprint[lastrowprinted]));

                // bottom check, we're really really done when there's no more data
                if (lastrowprinted >= rowstoprint.Count - 1)
                {
                    // set no more pages flag
                    e.HasMorePages = false;

                    // print a footer for this page
                    printfooter(e.Graphics, ref printpos);

                    // reset counters since we'll go through this twice if we print from preview
                    lastrowprinted = -1;
                    CurrentPage = 0;

                    // return
                    return;
                }
            }

            //-----------------------------------------------------------------
            // print footer
            //-----------------------------------------------------------------
            printfooter(e.Graphics, ref printpos);

            //-----------------------------------------------------------------
            // bottom check, see if this is the last page to print
            //-----------------------------------------------------------------

            if (CurrentPage >= toPage)
            {
                // tell the caller we're complete
                e.HasMorePages = false;

                // reset counters since we'll go through this twice if we print from preview
                lastrowprinted = -1;
                CurrentPage = 0;
            }
            else
            {
                // we're not done yet
                e.HasMorePages = true;
            }

            return;
        }

        /// <summary>
        /// Print a header or footer section. Used for page numbers and titles
        /// </summary>
        /// <param name="g">Graphic context to print in</param>
        /// <param name="pos">Track vertical space used; 'y' location</param>
        /// <param name="text">String to print</param>
        /// <param name="font">Font to use for printing</param>
        /// <param name="color">Color to print in</param>
        /// <param name="alignment">Alignment - print to left, center or right</param>
        /// <param name="flags">String format flags</param>
        /// <param name="useroverride">True if the user overrode the alignment or flags</param>
        private void printsection(Graphics g, ref float pos, string text,
            Font font, Color color, StringAlignment alignment, StringFormatFlags flags, bool useroverride)
        {
            // string formatting setup
            StringFormat printformat = managestringformat(alignment, flags, null, useroverride);

            // measure string
            SizeF printsize = g.MeasureString(text, font, printWidth, printformat);

            // build area to print within
            RectangleF printarea = new RectangleF((float)printmargins.Left, pos, (float)printWidth,
               printsize.Height);

            // do the actual print
            g.DrawString(text, font, new SolidBrush(color), printarea, printformat);

            // track "used" vertical space
            pos += printsize.Height;
        }

        /// <summary>
        /// Print the footer. This handles the footer spacing, and printing the page number
        /// at the bottom of the page (if the page number is not in the header).
        /// </summary>
        /// <param name="g">Graphic context to print in</param>
        /// <param name="pos">Track vertical space used; 'y' location</param>
        private void printfooter(Graphics g, ref float pos)
        {
            // print last footer. Note: need to force printpos to the bottom of the page
            // as we may have run out of data anywhere on the page
            pos = pageHeight - footerHeight - printmargins.Top - printmargins.Bottom;

            // add spacing
            pos += footerspacing;

            // print the footer
            printsection(g, ref pos, footer, footerfont,
                footercolor, footeralignment, footerformatflags, overridefooterformat);

            // print the page number if it's on the bottom.
            if (!pagenumberontop)
            {
                if (pageno)
                {
                    // if the pageno is not on a separate line, push the print location up by its height.
                    if (!pagenumberonseparateline)
                        pos = pos - pagenumberHeight;

                    // print the page number
                    printsection(g, ref pos, "Page " + CurrentPage.ToString(CultureInfo.CurrentCulture),
                        pagenofont, pagenocolor, pagenumberalignment, pagenumberformatflags, overridepagenumberformat);

                }
            }
        }

        /// <summary>
        /// Print the column headers. Most printing format info is retrieved from the 
        /// source DataGridView.
        /// </summary>
        /// <param name="g">Graphics Context to print within</param>
        /// <param name="pos">Track vertical space used; 'y' location</param>
        private void printcolumnheaders(Graphics g, ref float pos)
        {
            //-----------------------------------------------------------------
            // setup printing
            //-----------------------------------------------------------------

            // track printing location accross the page. start position is hard left,
            // adjusted for the row headers. Note rowheaderwidth is 0 if row headers are not printed
            float xcoord = printmargins.Left + rowheaderwidth;

            // set up colors, fonts for header printing
            Color foreground = !(dgv.ColumnHeadersDefaultCellStyle.ForeColor.IsEmpty)
                ? dgv.ColumnHeadersDefaultCellStyle.ForeColor : dgv.DefaultCellStyle.ForeColor;

            Color background = !(dgv.ColumnHeadersDefaultCellStyle.BackColor.IsEmpty)
                ? dgv.ColumnHeadersDefaultCellStyle.BackColor : dgv.DefaultCellStyle.BackColor;

            Font font = (null != dgv.ColumnHeadersDefaultCellStyle.Font)
                ? dgv.ColumnHeadersDefaultCellStyle.Font : dgv.DefaultCellStyle.Font;

            // define print rectangle
            RectangleF printarea = new RectangleF(xcoord, pos, coltotalwidth - rowheaderwidth,
                colheaderheight);

            // set brushes for printing
            SolidBrush forebrush = new SolidBrush(foreground);
            SolidBrush backbrush = new SolidBrush(background);

            // set the pen for drawing the grid lines
            Pen lines = new Pen(dgv.GridColor, 1);

            // set the printing format for individual header cells
            StringFormat format = managestringformat(headercellalignment, headercellformatflags,
                dgv.ColumnHeadersDefaultCellStyle, overridecellheaderformat);

            //-----------------------------------------------------------------
            // Now that we're all setup, start printing the column headers
            //-----------------------------------------------------------------

            // fill in the background
            g.FillRectangle(backbrush, printarea);

            // write and draw each cell
            DataGridViewColumn col;
            for (int i = 0; i < colstoprint.Count; i++)
            {
                col = (DataGridViewColumn)colstoprint[i];

                // set print area for this individual cell
                RectangleF cellprintarea = new RectangleF(xcoord, pos, colwidths[i], colheaderheight);

                // draw the text
                g.DrawString(col.HeaderText, font, forebrush, cellprintarea, format);

                // draw the borders - default to the dgv's border setting
                if (dgv.ColumnHeadersBorderStyle != DataGridViewHeaderBorderStyle.None)
                    g.DrawRectangle(lines, xcoord, pos, colwidths[i], colheaderheight);

                xcoord += colwidths[i];
            }

            // all done, consume "used" vertical space
            pos += colheaderheight;
        }
        private void printcolumnheadersRight(Graphics g, ref float pos)
        {
            //-----------------------------------------------------------------
            // setup printing
            //-----------------------------------------------------------------

            // track printing location accross the page. start position is hard left,
            // adjusted for the row headers. Note rowheaderwidth is 0 if row headers are not printed
            float xcoord = printmargins.Right; // -rowheaderwidth;

            // set up colors, fonts for header printing
            Color foreground = !(dgv.ColumnHeadersDefaultCellStyle.ForeColor.IsEmpty)
                ? dgv.ColumnHeadersDefaultCellStyle.ForeColor : dgv.DefaultCellStyle.ForeColor;

            Color background = !(dgv.ColumnHeadersDefaultCellStyle.BackColor.IsEmpty)
                ? dgv.ColumnHeadersDefaultCellStyle.BackColor : dgv.DefaultCellStyle.BackColor;

            Font font = (null != dgv.ColumnHeadersDefaultCellStyle.Font)
                ? dgv.ColumnHeadersDefaultCellStyle.Font : dgv.DefaultCellStyle.Font;

            // define print rectangle
            RectangleF printarea = new RectangleF(pageWidth - xcoord - (coltotalwidth - rowheaderwidth), pos, coltotalwidth - rowheaderwidth,
                colheaderheight);

            // set brushes for printing
            SolidBrush forebrush = new SolidBrush(foreground);
            SolidBrush backbrush = new SolidBrush(background);

            // set the pen for drawing the grid lines
            Pen lines = new Pen(dgv.GridColor, 1);

            // set the printing format for individual header cells
            StringFormat format = managestringformat(headercellalignment, headercellformatflags,
                dgv.ColumnHeadersDefaultCellStyle, overridecellheaderformat);

            //-----------------------------------------------------------------
            // Now that we're all setup, start printing the column headers
            //-----------------------------------------------------------------

            // fill in the background
            g.FillRectangle(backbrush, printarea);

            // write and draw each cell
            DataGridViewColumn col;
            for (int i = 0; i < colstoprint.Count; i++)
            {
                col = (DataGridViewColumn)colstoprint[i];

                // set print area for this individual cell
                RectangleF cellprintarea = new RectangleF(pageWidth - xcoord - colwidths[i], pos, colwidths[i], colheaderheight);

                // draw the text
                g.DrawString(col.HeaderText, font, forebrush, cellprintarea, format);

                // draw the borders - default to the dgv's border setting
                if (dgv.ColumnHeadersBorderStyle != DataGridViewHeaderBorderStyle.None)
                    g.DrawRectangle(lines, pageWidth - xcoord - colwidths[i], pos, colwidths[i], colheaderheight);

                xcoord += colwidths[i];
            }

            // all done, consume "used" vertical space
            pos += colheaderheight;
        }

        /// <summary>
        /// Print one row of the DataGridView. Most printing format info is retrieved
        /// from the DataGridView.
        /// </summary>
        /// <param name="g">Graphics Context to print within</param>
        /// <param name="pos">Track vertical space used; 'y' location</param>
        /// <param name="row">The row that will be printed</param>
        private void printrow(Graphics g, ref float pos, DataGridViewRow row)
        {
            //-----------------------------------------------------------------
            // setup printing
            //-----------------------------------------------------------------

            // track printing location accross the page
            float xcoord = printmargins.Left;

            // set up colors, fonts for header printing
            Color foreground = !(row.DefaultCellStyle.ForeColor.IsEmpty)
                ? row.DefaultCellStyle.ForeColor : dgv.DefaultCellStyle.ForeColor;

            Color background = !(row.DefaultCellStyle.BackColor.IsEmpty)
                ? row.DefaultCellStyle.BackColor : dgv.DefaultCellStyle.BackColor;

            Font font = (null != row.DefaultCellStyle.Font)
                ? row.DefaultCellStyle.Font : dgv.DefaultCellStyle.Font;

            // define print rectangle
            RectangleF printarea = new RectangleF(xcoord, pos, coltotalwidth, rowheights[lastrowprinted]);

            // set brushes for printing
            SolidBrush forebrush = new SolidBrush(foreground);
            SolidBrush backbrush = new SolidBrush(background);

            // set the pen for drawing the grid lines
            Pen lines = new Pen(dgv.GridColor, 1);

            // set the printing format for individual cells 
            StringFormat format = managestringformat(cellalignment, cellformatflags, row.DefaultCellStyle,
                overridecellformat);

            //-----------------------------------------------------------------
            // Now that we're all setup, start printing the row as individual cells
            //-----------------------------------------------------------------

            // fill in the row background
            g.FillRectangle(backbrush, printarea);

            // print row headers
            if (dgv.RowHeadersVisible)
            {
                // set printing format for the row headers
                StringFormat rowheaderformat = managestringformat(headercellalignment,
                    headercellformatflags, row.DefaultCellStyle, overridecellheaderformat);

                // set print area for this individual cell
                RectangleF headercellprintarea = new RectangleF(xcoord, pos, rowheaderwidth, rowheights[lastrowprinted]);

                // draw the text for the row header cell
                g.DrawString(row.HeaderCell.EditedFormattedValue.ToString(),
                    font, forebrush, headercellprintarea, rowheaderformat);

                // draw the borders - default to the dgv's border setting
                if (dgv.RowHeadersBorderStyle != DataGridViewHeaderBorderStyle.None)
                    g.DrawRectangle(lines, xcoord, pos, rowheaderwidth, rowheights[lastrowprinted]);

                // track horizontal space used
                xcoord += rowheaderwidth;
            }

            // write and draw each cell
            DataGridViewColumn col;
            for (int i = 0; i < colstoprint.Count; i++)
            {
                // access the column being printed
                col = (DataGridViewColumn)colstoprint[i];

                // set print area for this individual cell
                RectangleF cellprintarea = new RectangleF(xcoord, pos, colwidths[i], rowheights[lastrowprinted]);

                // draw the text for the cell at the row / col intersection
                g.DrawString(row.Cells[col.Index].EditedFormattedValue.ToString(),
                    font, forebrush, cellprintarea, format);

                // draw the borders - default to the dgv's border setting
                if (dgv.BorderStyle != BorderStyle.None)
                    g.DrawRectangle(lines, xcoord, pos, colwidths[i], rowheights[lastrowprinted]);

                // track horizontal space used
                xcoord += colwidths[i];
            }

            // all done, consume "used" vertical space
            pos += rowheights[lastrowprinted];
        }
        private void printrowRight(Graphics g, ref float pos, DataGridViewRow row)
        {
            //-----------------------------------------------------------------
            // setup printing
            //-----------------------------------------------------------------

            // track printing location accross the page
            float xcoord = printmargins.Right;

            // set up colors, fonts for header printing
            Color foreground = !(row.DefaultCellStyle.ForeColor.IsEmpty)
                ? row.DefaultCellStyle.ForeColor : dgv.DefaultCellStyle.ForeColor;

            Color background = !(row.DefaultCellStyle.BackColor.IsEmpty)
                ? row.DefaultCellStyle.BackColor : dgv.DefaultCellStyle.BackColor;

            Font font = (null != row.DefaultCellStyle.Font)
                ? row.DefaultCellStyle.Font : dgv.DefaultCellStyle.Font;

            // define print rectangle
            RectangleF printarea = new RectangleF(pageWidth - xcoord - coltotalwidth, pos, coltotalwidth, rowheights[lastrowprinted]);

            // set brushes for printing
            SolidBrush forebrush = new SolidBrush(foreground);
            SolidBrush backbrush = new SolidBrush(background);

            // set the pen for drawing the grid lines
            Pen lines = new Pen(dgv.GridColor, 1);

            // set the printing format for individual cells 
            StringFormat format = managestringformat(cellalignment, cellformatflags, row.DefaultCellStyle,
                overridecellformat);

            //-----------------------------------------------------------------
            // Now that we're all setup, start printing the row as individual cells
            //-----------------------------------------------------------------

            // fill in the row background
            g.FillRectangle(backbrush, printarea);

            // print row headers
            if (dgv.RowHeadersVisible)
            {
                // set printing format for the row headers
                StringFormat rowheaderformat = managestringformat(headercellalignment,
                    headercellformatflags, row.DefaultCellStyle, overridecellheaderformat);

                // set print area for this individual cell
                RectangleF headercellprintarea = new RectangleF(pageWidth - xcoord - rowheaderwidth, pos, rowheaderwidth, rowheights[lastrowprinted]);

                // draw the text for the row header cell
                g.DrawString(row.HeaderCell.EditedFormattedValue.ToString(),
                    font, forebrush, headercellprintarea, rowheaderformat);

                // draw the borders - default to the dgv's border setting
                if (dgv.RowHeadersBorderStyle != DataGridViewHeaderBorderStyle.None)
                    g.DrawRectangle(lines, pageWidth - xcoord - rowheaderwidth, pos, rowheaderwidth, rowheights[lastrowprinted]);

                // track horizontal space used
                xcoord += rowheaderwidth;
            }

            // write and draw each cell
            DataGridViewColumn col;
            for (int i = 0; i < colstoprint.Count; i++)
            {
                // access the column being printed
                col = (DataGridViewColumn)colstoprint[i];

                // set print area for this individual cell
                RectangleF cellprintarea = new RectangleF(pageWidth - xcoord - colwidths[i], pos, colwidths[i], rowheights[lastrowprinted]);

                // draw the text for the cell at the row / col intersection
                g.DrawString(row.Cells[col.Index].EditedFormattedValue.ToString(),
                    font, forebrush, cellprintarea, format);

                // draw the borders - default to the dgv's border setting
                if (dgv.BorderStyle != BorderStyle.None)
                    g.DrawRectangle(lines, pageWidth - xcoord - colwidths[i], pos, colwidths[i], rowheights[lastrowprinted]);

                // track horizontal space used
                xcoord += colwidths[i];
            }

            // all done, consume "used" vertical space
            pos += rowheights[lastrowprinted];
        }

    }
}
