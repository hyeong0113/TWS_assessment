using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using IBApi;

namespace IBTradingPlatform
{
    partial class Quantity
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.CbSymbol = new System.Windows.Forms.ComboBox();
            this.LbData = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NumQuantity = new System.Windows.Forms.NumericUpDown();
            this.NumPrice = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbMarket = new System.Windows.Forms.ComboBox();
            this.CbOrderType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TbVisible = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TbExchange = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CbTIF = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TbBid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TbAsk = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TbLast = new System.Windows.Forms.TextBox();
            this.TbOrderId = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BtnDisconnect = new System.Windows.Forms.Button();
            this.BtnSell = new System.Windows.Forms.Button();
            this.CkOutside = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.HistoricalData = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label13 = new System.Windows.Forms.Label();
            this.TbMA = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.LbPosition = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrice)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(493, 508);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(132, 45);
            this.BtnConnect.TabIndex = 0;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // CbSymbol
            // 
            this.CbSymbol.AutoCompleteCustomSource.AddRange(new string[] {
            "MSFT",
            "TSLA",
            "IBM"});
            this.CbSymbol.FormattingEnabled = true;
            this.CbSymbol.Items.AddRange(new object[] {
            "MSFT",
            "TSLA",
            "SPEC"});
            this.CbSymbol.Location = new System.Drawing.Point(37, 120);
            this.CbSymbol.Name = "CbSymbol";
            this.CbSymbol.Size = new System.Drawing.Size(121, 21);
            this.CbSymbol.TabIndex = 1;
            this.CbSymbol.Text = "MSFT";
            this.CbSymbol.SelectedIndexChanged += new System.EventHandler(this.CbSymbol_SelectedIndexChanged);
            this.CbSymbol.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CbSymbol_KeyDown);
            this.CbSymbol.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CbSymbol_KeyPress);
            // 
            // LbData
            // 
            this.LbData.FormattingEnabled = true;
            this.LbData.Location = new System.Drawing.Point(37, 326);
            this.LbData.Name = "LbData";
            this.LbData.Size = new System.Drawing.Size(430, 95);
            this.LbData.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Symbol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity";
            // 
            // NumQuantity
            // 
            this.NumQuantity.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumQuantity.Location = new System.Drawing.Point(186, 120);
            this.NumQuantity.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NumQuantity.Name = "NumQuantity";
            this.NumQuantity.Size = new System.Drawing.Size(120, 20);
            this.NumQuantity.TabIndex = 6;
            // 
            // NumPrice
            // 
            this.NumPrice.DecimalPlaces = 2;
            this.NumPrice.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NumPrice.Location = new System.Drawing.Point(347, 120);
            this.NumPrice.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.NumPrice.Name = "NumPrice";
            this.NumPrice.Size = new System.Drawing.Size(120, 20);
            this.NumPrice.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(344, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Limit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Market";
            // 
            // CbMarket
            // 
            this.CbMarket.AutoCompleteCustomSource.AddRange(new string[] {
            "MSFT",
            "TSLA",
            "IBM"});
            this.CbMarket.FormattingEnabled = true;
            this.CbMarket.Items.AddRange(new object[] {
            "SMART",
            "ARCA",
            "BATS",
            "ISLAND"});
            this.CbMarket.Location = new System.Drawing.Point(37, 173);
            this.CbMarket.Name = "CbMarket";
            this.CbMarket.Size = new System.Drawing.Size(121, 21);
            this.CbMarket.TabIndex = 10;
            this.CbMarket.Text = "SMART";
            // 
            // CbOrderType
            // 
            this.CbOrderType.AutoCompleteCustomSource.AddRange(new string[] {
            "MSFT",
            "TSLA",
            "IBM"});
            this.CbOrderType.FormattingEnabled = true;
            this.CbOrderType.Items.AddRange(new object[] {
            "LMT",
            "MKT",
            "STP",
            "MOC"});
            this.CbOrderType.Location = new System.Drawing.Point(186, 173);
            this.CbOrderType.Name = "CbOrderType";
            this.CbOrderType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CbOrderType.Size = new System.Drawing.Size(121, 21);
            this.CbOrderType.TabIndex = 12;
            this.CbOrderType.Text = "LMT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type";
            // 
            // TbVisible
            // 
            this.TbVisible.Location = new System.Drawing.Point(347, 173);
            this.TbVisible.Name = "TbVisible";
            this.TbVisible.Size = new System.Drawing.Size(100, 20);
            this.TbVisible.TabIndex = 13;
            this.TbVisible.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Visible";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Primary Exchange";
            // 
            // TbExchange
            // 
            this.TbExchange.Location = new System.Drawing.Point(37, 230);
            this.TbExchange.Name = "TbExchange";
            this.TbExchange.Size = new System.Drawing.Size(100, 20);
            this.TbExchange.TabIndex = 15;
            this.TbExchange.Text = "NASDAQ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(182, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "TIF";
            // 
            // CbTIF
            // 
            this.CbTIF.AutoCompleteCustomSource.AddRange(new string[] {
            "MSFT",
            "TSLA",
            "IBM"});
            this.CbTIF.FormattingEnabled = true;
            this.CbTIF.Items.AddRange(new object[] {
            "DAY",
            "GTC"});
            this.CbTIF.Location = new System.Drawing.Point(185, 229);
            this.CbTIF.Name = "CbTIF";
            this.CbTIF.Size = new System.Drawing.Size(121, 21);
            this.CbTIF.TabIndex = 17;
            this.CbTIF.Text = "DAY";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(344, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Bid";
            this.label9.UseWaitCursor = true;
            // 
            // TbBid
            // 
            this.TbBid.Location = new System.Drawing.Point(347, 230);
            this.TbBid.Name = "TbBid";
            this.TbBid.Size = new System.Drawing.Size(100, 20);
            this.TbBid.TabIndex = 19;
            this.TbBid.Text = "0.00";
            this.TbBid.Click += new System.EventHandler(this.TbBid_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ask";
            this.label10.UseWaitCursor = true;
            // 
            // TbAsk
            // 
            this.TbAsk.Location = new System.Drawing.Point(37, 285);
            this.TbAsk.Name = "TbAsk";
            this.TbAsk.Size = new System.Drawing.Size(100, 20);
            this.TbAsk.TabIndex = 21;
            this.TbAsk.Text = "0.00";
            this.TbAsk.Click += new System.EventHandler(this.TbAsk_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(182, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Last";
            this.label11.UseWaitCursor = true;
            // 
            // TbLast
            // 
            this.TbLast.Location = new System.Drawing.Point(185, 285);
            this.TbLast.Name = "TbLast";
            this.TbLast.Size = new System.Drawing.Size(100, 20);
            this.TbLast.TabIndex = 23;
            this.TbLast.Text = "0.00";
            this.TbLast.Click += new System.EventHandler(this.TbLast_Click);
            // 
            // TbOrderId
            // 
            this.TbOrderId.Location = new System.Drawing.Point(37, 66);
            this.TbOrderId.Name = "TbOrderId";
            this.TbOrderId.Size = new System.Drawing.Size(100, 20);
            this.TbOrderId.TabIndex = 25;
            this.TbOrderId.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(34, 45);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Next Valid Order Id";
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Location = new System.Drawing.Point(848, 508);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(132, 45);
            this.BtnDisconnect.TabIndex = 27;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // BtnSell
            // 
            this.BtnSell.Location = new System.Drawing.Point(0, 0);
            this.BtnSell.Name = "BtnSell";
            this.BtnSell.Size = new System.Drawing.Size(75, 23);
            this.BtnSell.TabIndex = 34;
            // 
            // CkOutside
            // 
            this.CkOutside.AutoSize = true;
            this.CkOutside.Location = new System.Drawing.Point(347, 287);
            this.CkOutside.Name = "CkOutside";
            this.CkOutside.Size = new System.Drawing.Size(85, 17);
            this.CkOutside.TabIndex = 30;
            this.CkOutside.Text = "OutsideRTH";
            this.CkOutside.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CkOutside.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(493, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(491, 478);
            this.tabControl1.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.HistoricalData);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(483, 452);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Historical Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // HistoricalData
            // 
            this.HistoricalData.FormattingEnabled = true;
            this.HistoricalData.Location = new System.Drawing.Point(20, 16);
            this.HistoricalData.Name = "HistoricalData";
            this.HistoricalData.Size = new System.Drawing.Size(438, 420);
            this.HistoricalData.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Chart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(483, 452);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visual Chart";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Chart
            // 
            chartArea3.AxisX.IsStartedFromZero = false;
            chartArea3.AxisY.IsStartedFromZero = false;
            chartArea3.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.Chart.Legends.Add(legend3);
            this.Chart.Location = new System.Drawing.Point(32, 20);
            this.Chart.Name = "Chart";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
            series3.CustomProperties = "PriceUpColor=Red, PriceDownColor=Blue";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 4;
            this.Chart.Series.Add(series3);
            this.Chart.Size = new System.Drawing.Size(427, 410);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "chart1";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(182, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 13);
            this.label13.TabIndex = 33;
            this.label13.Text = "Moving Average";
            this.label13.UseWaitCursor = true;
            // 
            // TbMA
            // 
            this.TbMA.Location = new System.Drawing.Point(185, 66);
            this.TbMA.Name = "TbMA";
            this.TbMA.Size = new System.Drawing.Size(100, 20);
            this.TbMA.TabIndex = 32;
            this.TbMA.Text = "0.00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(34, 310);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 13);
            this.label14.TabIndex = 35;
            this.label14.Text = "Tick Price";
            this.label14.UseWaitCursor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(34, 430);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Position";
            this.label15.UseWaitCursor = true;
            // 
            // LbPosition
            // 
            this.LbPosition.FormattingEnabled = true;
            this.LbPosition.Location = new System.Drawing.Point(37, 446);
            this.LbPosition.Name = "LbPosition";
            this.LbPosition.Size = new System.Drawing.Size(430, 95);
            this.LbPosition.TabIndex = 36;
            // 
            // Quantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 563);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.LbPosition);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TbMA);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.CkOutside);
            this.Controls.Add(this.BtnSell);
            this.Controls.Add(this.BtnDisconnect);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TbOrderId);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TbLast);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TbAsk);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TbBid);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CbTIF);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TbExchange);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TbVisible);
            this.Controls.Add(this.CbOrderType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CbMarket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NumPrice);
            this.Controls.Add(this.NumQuantity);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LbData);
            this.Controls.Add(this.CbSymbol);
            this.Controls.Add(this.BtnConnect);
            this.Name = "Quantity";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrice)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnConnect;
        private ComboBox CbSymbol;
        private ListBox LbData;
        private Label label1;
        private Label label2;
        private NumericUpDown NumQuantity;
        private NumericUpDown NumPrice;
        private Label label3;
        private Label label4;
        private ComboBox CbMarket;
        private ComboBox CbOrderType;
        private Label label5;
        private TextBox TbVisible;
        private Label label6;
        private Label label7;
        private TextBox TbExchange;
        private Label label8;
        private ComboBox CbTIF;
        private Label label9;
        private TextBox TbBid;
        private Label label10;
        private TextBox TbAsk;
        private Label label11;
        private TextBox TbLast;
        private TextBox TbOrderId;
        private Label label12;
        private Button BtnDisconnect;
        private Button BtnSell;
        private CheckBox CkOutside;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private ListBox HistoricalData;
        private TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private Label label13;
        private TextBox TbMA;
        private Label label14;
        private Label label15;
        private ListBox LbPosition;
    }
}

