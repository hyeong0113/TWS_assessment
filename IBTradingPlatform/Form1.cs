using IBApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBTradingPlatform
{
    public partial class Quantity : Form
    {
        // Enables asynchronous calls for setting the text property
        // on a ListBox control
        delegate void SetTextCallback(string text);

        delegate void SetTextCallbackTickPrice(string tickPrice);

        int OrderId = 0;

        int Timer1Counter = 5;

        public void AddListBoxItem(string text)
        {
            // See if a new invocation is required form a different thread
            if (this.LbData.InvokeRequired)
            {
                SetTextCallback data = new SetTextCallback(AddListBoxItem);
                this.Invoke(data, new object[] { text });
            }
            else
            {
                // Add the text string to the list box
                this.LbData.Items.Add(text);
            }
        }

        public void AddListBoxItemTickPrice(string tickPrice)
        {
            if (this.TbLast.InvokeRequired)
            {
                SetTextCallbackTickPrice data = new SetTextCallbackTickPrice(AddListBoxItemTickPrice);
                try
                {
                    this.Invoke(data, new object[] { tickPrice });
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error from tickPrice", ex);
                }
            }
            else
            {
                string[] tickerPrice = new string[] { tickPrice };
                tickerPrice = tickPrice.Split(',');

                int tickerType = Convert.ToInt32(tickerPrice[1]);

                if (Convert.ToInt32(tickerPrice[0]) == 1)
                {
                    if (tickerType == 68) // tickerPrice == 68 for delayed time
                    {
                        // Add the text to the list box
                        this.TbLast.Text = tickerPrice[2];
                    }
                    else if (tickerType == 67) // tickerPrice == 67 for delayed time
                    {
                        // Add the text to the list box
                        this.TbAsk.Text = tickerPrice[2];
                    }
                    else if (tickerType == 66) // tickerPrice == 66 for delayed time
                    {
                        // Add the text to the list box
                        this.TbBid.Text = tickerPrice[2];
                    }
                }
            }
        }

        // Create the IbClient object to represent the connection
        IBTradingPlatform.EWrapperImpl IbClient;

        public Quantity()
        {
            InitializeComponent();

            // Instantiate the Ib client
            IbClient = new IBTradingPlatform.EWrapperImpl();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            // Parameters to connect to TWS:
            // host: IP address or host name of the host running TWS
            // port: listening port 7497
            // clientId: client application identifier can be any number
            IbClient.ClientSocket.eConnect("", 7497, 0);

            var reader = new EReader(IbClient.ClientSocket, IbClient.Signal);
            reader.Start();
            new Thread(() =>
            {
                while (IbClient.ClientSocket.IsConnected())
                {
                    IbClient.Signal.waitForSignal();
                    reader.processMsgs();
                }
            })
            { IsBackground = true }.Start();

            // Wait until the connection is completed
            while (IbClient.NextOrderId <= 0) { }

            // Set up the form object in the EWrapper
            IbClient.myForm = (Quantity)Application.OpenForms[0];

            // Get the next order id and puts it in the textbox
            TbOrderId.Text = IbClient.NextOrderId.ToString();
            // Update the order id value
            OrderId = IbClient.NextOrderId;

            GetData();
        }

        private void BtnDisconnect_Click(object sender, EventArgs e)
        {
            // Disconnect TWS
            IbClient.ClientSocket.eDisconnect();
        }

        private void GetData()
        {
            // Cancel Market Data
            IbClient.ClientSocket.cancelMktData(1);

            // Create a new contract to specify the security we are searching for
            IBApi.Contract contract = new IBApi.Contract();
            // Create a new TagValueList object
            List<IBApi.TagValue> mkDataOptions = new List<IBApi.TagValue>();

            // Set the underlying stock symbol from the tbSymbol text box
            contract.Symbol = CbSymbol.Text;
            // Set the security type to STK for a stock
            contract.SecType = "STK";
            // Use "SMART" as the general exchange
            contract.Exchange = "SMART";
            // Set the primary exchange (sometimes called Listing exchange)
            // Use either NYSE or ISLAND
            contract.PrimaryExch = "ISLAND";
            // Set the currency to USD
            contract.Currency = "USD";

            // If using delayed market data subscription un-comment
            // the line below to request delayed data
            // 1 = live data
            // 3 = delayed data
            IbClient.ClientSocket.reqMarketDataType(3);

            // Kick off the subscription for real-time data (add the mktDataOptions list)
            IbClient.ClientSocket.reqMktData(1, contract, "", false, false, mkDataOptions);
        }

        private void CbSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void CbSymbol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLower(e.KeyChar))
            {
                e.KeyChar = char.ToUpper(e.KeyChar);
            }
        }

        private void CbSymbol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CbSymbol.SelectionStart = 0;
                CbSymbol.SelectionLength = CbSymbol.Text.Length;

                e.SuppressKeyPress = true;

                string name = CbSymbol.Text;

                // Adds the security symbol to the dropdown list in the CbSymbol (symbol combobox)
                if (!CbSymbol.Items.Contains(name))
                {
                    CbSymbol.Items.Add(name);
                }

                CbSymbol.SelectAll();

                GetData();
            }
        }

        private void BtnBuy_Click(object sender, EventArgs e)
        {
            string signal = "BUY";
            SendOrder(signal);
        }

        private void BtnSell_Click(object sender, EventArgs e)
        {
            string signal = "SELL";
            SendOrder(signal);
        }

        public void SendOrder(string signal)
        {
            // Create a new contract to specify the security we are searching for
            IBApi.Contract contract = new IBApi.Contract();

            // Set the underlying stock symbol from the CbSymbol combobox
            contract.Symbol = CbSymbol.Text;
            // Set the Security type to STK for a stock
            contract.SecType = "STK";
            // Use "SMART" as the general exchange
            contract.Exchange = CbMarket.Text;
            // Set the primary exchange, either NYSE or ISLAND
            contract.PrimaryExch = "ISLAND";
            // Set the currency to USD
            contract.Currency = "USD";

            IBApi.Order order = new IBApi.Order();
            // Gets the next order id from the text box
            order.OrderId = OrderId;
            // Gets the signal of the order
            order.Action = signal;
            // Gets order type from combobox market or limit order (MKT, or LMT)
            order.OrderType = CbOrderType.Text;
            // Number of shares from the numericupdown box
            order.TotalQuantity = NumQuantity.Value;
            // Number of shares from the numericupdown box then converts it to double variable
            order.LmtPrice = Convert.ToDouble(NumPrice.Value);
            
            // Checks for a stop order
            if (CbOrderType.Text == "STP")
            {
                // Stop order value from the limit textbox
                order.AuxPrice = Convert.ToDouble(NumPrice.Value);
            }

            // Visible shares to the market
            order.DisplaySize = Convert.ToInt32(TbVisible.Text);
            order.OutsideRth = CkOutside.Checked;

            // Place the order
            IbClient.ClientSocket.placeOrder(OrderId, contract, order);

            // Increase the OrderId value
            OrderId++;
            TbOrderId.Text = Convert.ToString(OrderId);
        }

        private void TbBid_Click(object sender, EventArgs e)
        {
            NumPrice.Value = Convert.ToDecimal(TbBid.Text);
        }

        private void TbAsk_Click(object sender, EventArgs e)
        {
            NumPrice.Value = Convert.ToDecimal(TbAsk.Text);
        }

        private void TbLast_Click(object sender, EventArgs e)
        {
            NumPrice.Value = Convert.ToDecimal(TbLast.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Timer1Counter == 0)
            {
                // Stop the timer
                timer1.Stop();
                // Add the bid price to the limit box
                NumPrice.Value = Convert.ToDecimal(TbBid.Text);
                // Reset timer back to 5
                Timer1Counter = 5;
            }
            Timer1Counter--;
        }
    }
}
