using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TicketVendingMachine
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        SqlDataAdapter data;
        SqlCommand cm;
        DataTable tb;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "initial catalog = TicketVendingMachine; data source = DESKTOP-K32FQ05; integrated security = true";
            cn = new SqlConnection(sql);
            cn.Open();
        }

        private void PurchaseTicket(string ticketType, int numberOfTickets, string paymentMethod)
        {
            // Validate input
            if (string.IsNullOrEmpty(ticketType))
            {
                MessageBox.Show("Please select a ticket type.");
                return;
            }
            if (numberOfTickets <= 0)
            {
                MessageBox.Show("Please enter a valid number of tickets.");
                return;
            }
            if (string.IsNullOrEmpty(paymentMethod))
            {
                MessageBox.Show("Please select a payment method.");
                return;
            }

            // Insert ticket purchase information into database
            try
            {
                string sql = "initial catalog = TicketVendingMachine; data source = DESKTOP-K32FQ05; integrated security = true";
                cn = new SqlConnection(sql);
                cn.Open();
                SqlCommand command = new SqlCommand("INSERT INTO TicketPurchase (TicketType, NumberOfTickets, PaymentMethod) VALUES (@TicketType, @NumberOfTickets, @PaymentMethod)", cn);
                command.Parameters.AddWithValue("@TicketType", ticketType);
                command.Parameters.AddWithValue("@NumberOfTickets", numberOfTickets);
                command.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while purchasing the ticket: " + ex.Message);
            }
            finally
            {
                cn.Close();
            }

            // Generate unique identification number and display on form
            int ticketId = GenerateTicketId();
            lblTicketId.Text = "Ticket ID: " + ticketId.ToString();
        }

        private int GenerateTicketId()
        {
            // Generate unique identification number using a random number
            Random random = new Random();
            int ticketId = random.Next(100000, 999999);
            return ticketId;
        }
        private void PurchaseTicket_Click(object sender, EventArgs e)
        {
            // Get selected ticket type
            string ticketType = cboTicketType.SelectedItem.ToString();

            // Get selected number of tickets
            int numberOfTickets = (int)numTickets.Value;

            // Get selected payment method
            string paymentMethod = "";
            if (rdoCash.Checked)
            {
                paymentMethod = "Cash";
            }
            else if (rdoCreditCard.Checked)
            {
                paymentMethod = "Credit Card";
            }
            else if (rdoMobilePayment.Checked)
            {
                paymentMethod = "Mobile Payment";
            }

            // Purchase the ticket and display the ticket ID
            PurchaseTicket(ticketType, numberOfTickets, paymentMethod);
        }

    }
}
