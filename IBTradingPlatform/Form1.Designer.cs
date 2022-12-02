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
            this.components = new System.ComponentModel.Container();
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
            this.BtnBuy = new System.Windows.Forms.Button();
            this.BtnSell = new System.Windows.Forms.Button();
            this.CkOutside = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.NumQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(35, 12);
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
            this.CbSymbol.Location = new System.Drawing.Point(35, 179);
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
            this.LbData.Location = new System.Drawing.Point(35, 385);
            this.LbData.Name = "LbData";
            this.LbData.Size = new System.Drawing.Size(403, 95);
            this.LbData.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Symbol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 160);
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
            this.NumQuantity.Location = new System.Drawing.Point(184, 179);
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
            this.NumPrice.Location = new System.Drawing.Point(345, 179);
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
            this.label3.Location = new System.Drawing.Point(342, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Limit Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 216);
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
            this.CbMarket.Location = new System.Drawing.Point(35, 232);
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
            this.CbOrderType.Location = new System.Drawing.Point(190, 232);
            this.CbOrderType.Name = "CbOrderType";
            this.CbOrderType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CbOrderType.Size = new System.Drawing.Size(121, 21);
            this.CbOrderType.TabIndex = 12;
            this.CbOrderType.Text = "LMT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type";
            // 
            // TbVisible
            // 
            this.TbVisible.Location = new System.Drawing.Point(345, 232);
            this.TbVisible.Name = "TbVisible";
            this.TbVisible.Size = new System.Drawing.Size(100, 20);
            this.TbVisible.TabIndex = 13;
            this.TbVisible.Text = "100";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Visible";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Primary Exchange";
            // 
            // TbExchange
            // 
            this.TbExchange.Location = new System.Drawing.Point(35, 289);
            this.TbExchange.Name = "TbExchange";
            this.TbExchange.Size = new System.Drawing.Size(100, 20);
            this.TbExchange.TabIndex = 15;
            this.TbExchange.Text = "NASDAQ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(184, 269);
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
            this.CbTIF.Location = new System.Drawing.Point(183, 288);
            this.CbTIF.Name = "CbTIF";
            this.CbTIF.Size = new System.Drawing.Size(121, 21);
            this.CbTIF.TabIndex = 17;
            this.CbTIF.Text = "DAY";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 273);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Bid";
            this.label9.UseWaitCursor = true;
            // 
            // TbBid
            // 
            this.TbBid.Location = new System.Drawing.Point(345, 289);
            this.TbBid.Name = "TbBid";
            this.TbBid.Size = new System.Drawing.Size(100, 20);
            this.TbBid.TabIndex = 19;
            this.TbBid.Text = "0.00";
            this.TbBid.Click += new System.EventHandler(this.TbBid_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Ask";
            this.label10.UseWaitCursor = true;
            // 
            // TbAsk
            // 
            this.TbAsk.Location = new System.Drawing.Point(35, 344);
            this.TbAsk.Name = "TbAsk";
            this.TbAsk.Size = new System.Drawing.Size(100, 20);
            this.TbAsk.TabIndex = 21;
            this.TbAsk.Text = "0.00";
            this.TbAsk.Click += new System.EventHandler(this.TbAsk_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(187, 328);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Last";
            this.label11.UseWaitCursor = true;
            // 
            // TbLast
            // 
            this.TbLast.Location = new System.Drawing.Point(190, 344);
            this.TbLast.Name = "TbLast";
            this.TbLast.Size = new System.Drawing.Size(100, 20);
            this.TbLast.TabIndex = 23;
            this.TbLast.Text = "0.00";
            this.TbLast.Click += new System.EventHandler(this.TbLast_Click);
            // 
            // TbOrderId
            // 
            this.TbOrderId.Location = new System.Drawing.Point(35, 125);
            this.TbOrderId.Name = "TbOrderId";
            this.TbOrderId.Size = new System.Drawing.Size(100, 20);
            this.TbOrderId.TabIndex = 25;
            this.TbOrderId.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Next Valid Order Id";
            // 
            // BtnDisconnect
            // 
            this.BtnDisconnect.Location = new System.Drawing.Point(313, 12);
            this.BtnDisconnect.Name = "BtnDisconnect";
            this.BtnDisconnect.Size = new System.Drawing.Size(132, 45);
            this.BtnDisconnect.TabIndex = 27;
            this.BtnDisconnect.Text = "Disconnect";
            this.BtnDisconnect.UseVisualStyleBackColor = true;
            this.BtnDisconnect.Click += new System.EventHandler(this.BtnDisconnect_Click);
            // 
            // BtnBuy
            // 
            this.BtnBuy.BackColor = System.Drawing.Color.Lime;
            this.BtnBuy.Location = new System.Drawing.Point(35, 503);
            this.BtnBuy.Name = "BtnBuy";
            this.BtnBuy.Size = new System.Drawing.Size(75, 23);
            this.BtnBuy.TabIndex = 28;
            this.BtnBuy.Text = "BUY";
            this.BtnBuy.UseVisualStyleBackColor = false;
            this.BtnBuy.Click += new System.EventHandler(this.BtnBuy_Click);
            // 
            // BtnSell
            // 
            this.BtnSell.BackColor = System.Drawing.Color.Red;
            this.BtnSell.Location = new System.Drawing.Point(363, 503);
            this.BtnSell.Name = "BtnSell";
            this.BtnSell.Size = new System.Drawing.Size(75, 23);
            this.BtnSell.TabIndex = 29;
            this.BtnSell.Text = "SELL";
            this.BtnSell.UseVisualStyleBackColor = false;
            this.BtnSell.Click += new System.EventHandler(this.BtnSell_Click);
            // 
            // CkOutside
            // 
            this.CkOutside.AutoSize = true;
            this.CkOutside.Location = new System.Drawing.Point(345, 346);
            this.CkOutside.Name = "CkOutside";
            this.CkOutside.Size = new System.Drawing.Size(85, 17);
            this.CkOutside.TabIndex = 30;
            this.CkOutside.Text = "OutsideRTH";
            this.CkOutside.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.CkOutside.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Quantity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 563);
            this.Controls.Add(this.CkOutside);
            this.Controls.Add(this.BtnSell);
            this.Controls.Add(this.BtnBuy);
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
        private Button BtnBuy;
        private Button BtnSell;
        private CheckBox CkOutside;
        private System.Windows.Forms.Timer timer1;
    }
}

