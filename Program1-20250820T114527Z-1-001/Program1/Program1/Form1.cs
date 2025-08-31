using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Program1
{
    public partial class Form1 : Form
    {
        public class OrderItem
        {
            public string ItemName { get; set; }
            public string Size { get; set; }
            public decimal UnitPrice { get; set; }
            public int Quantity { get; set; }
            public decimal LineTotal => UnitPrice * Quantity;

            public OrderItem(string itemName, string size, decimal unitPrice, int quantity)
            {
                ItemName = itemName;
                Size = size;
                UnitPrice = unitPrice;
                Quantity = quantity;
            }
        }

        private List<OrderItem> currentOrder = new List<OrderItem>();
        private decimal totalOrderAmount = 0;
        private bool isCalculating = false;

        private Dictionary<string, decimal> sizePrices = new Dictionary<string, decimal>
        {
            {"Small", 10.00m},
            {"Medium", 15.00m},
            {"Large", 25.00m},
            {"Extra Small", 20.00m},
            {"Super Small", 30.00m}
        };

        public Form1()
        {
            InitializeComponent();
            SetupDataGridView();
        }

        private void SetupDataGridView()
        {
            dgvOrderItems.AutoGenerateColumns = false;
            dgvOrderItems.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "ItemName", HeaderText = "Item" });
            dgvOrderItems.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Size", HeaderText = "Size" });
            dgvOrderItems.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "UnitPrice", HeaderText = "Price", DefaultCellStyle = { Format = "C2" } });
            dgvOrderItems.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "Quantity", HeaderText = "Qty" });
            dgvOrderItems.Columns.Add(new DataGridViewTextBoxColumn { DataPropertyName = "LineTotal", HeaderText = "Subtotal", DefaultCellStyle = { Format = "C2" } });

            foreach (DataGridViewColumn col in dgvOrderItems.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set initial state of controls
            cbMangoFloat.Checked = false; EnableMangoFloatControls(false);
            cbKamoteFloat.Checked = false; EnableKamoteFloatControls(false);
            cbKangkongFloat.Checked = false; EnableKangkongFloatControls(false);

            // Set input restrictions for cash
            cashTextBox.KeyPress += DecimalTextBox_KeyPress;

            // Initial price label updates for default selection
            UpdateMangoFloatPriceLabel();
            UpdateKamoteFloatPriceLabel();
            UpdateKangkongFloatPriceLabel();
        }

        // --- Helper Methods to Enable/Disable Controls per Item ---
        private void EnableMangoFloatControls(bool enable)
        {
            groupBoxMangoSizes.Enabled = enable;
            nudMangoFloatQuantity.Enabled = enable;
            btnAddMango.Enabled = enable;
            lblMangoFloatPrice.Enabled = enable;
            if (enable)
            {
                UpdateMangoFloatPriceLabel();
            }
            else
            {
                lblMangoFloatPrice.Text = "Price: ₱0.00";
            }
        }

        private void EnableKamoteFloatControls(bool enable)
        {
            groupBoxKamoteSizes.Enabled = enable;
            nudKamoteFloatQuantity.Enabled = enable;
            btnAddKamote.Enabled = enable;
            lblKamoteFloatPrice.Enabled = enable;
            if (enable)
            {
                UpdateKamoteFloatPriceLabel();
            }
            else
            {
                lblKamoteFloatPrice.Text = "Price: ₱0.00";
            }
        }

        private void EnableKangkongFloatControls(bool enable)
        {
            groupBoxKangkongSizes.Enabled = enable;
            nudKangkongFloatQuantity.Enabled = enable;
            btnAddKangkong.Enabled = enable;
            lblKangkongFloatPrice.Enabled = enable;
            if (enable)
            {
                UpdateKangkongFloatPriceLabel();
            }
            else
            {
                lblKangkongFloatPrice.Text = "Price: ₱0.00";
            }
        }

        // --- Methods to update individual item price labels ---
        private void UpdateMangoFloatPriceLabel()
        {
            RadioButton selectedSizeRadioButton = groupBoxMangoSizes.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
            if (selectedSizeRadioButton != null && sizePrices.TryGetValue(selectedSizeRadioButton.Text, out decimal price))
            {
                lblMangoFloatPrice.Text = $"Price: ₱{price:0.00}";
            }
            else
            {
                lblMangoFloatPrice.Text = "Price: N/A";
            }
        }

        private void UpdateKamoteFloatPriceLabel()
        {
            RadioButton selectedSizeRadioButton = groupBoxKamoteSizes.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
            if (selectedSizeRadioButton != null && sizePrices.TryGetValue(selectedSizeRadioButton.Text, out decimal price))
            {
                lblKamoteFloatPrice.Text = $"Price: ₱{price:0.00}";
            }
            else
            {
                lblKamoteFloatPrice.Text = "Price: N/A";
            }
        }

        private void UpdateKangkongFloatPriceLabel()
        {
            RadioButton selectedSizeRadioButton = groupBoxKangkongSizes.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);
            if (selectedSizeRadioButton != null && sizePrices.TryGetValue(selectedSizeRadioButton.Text, out decimal price))
            {
                lblKangkongFloatPrice.Text = $"Price: ₱{price:0.00}";
            }
            else
            {
                lblKangkongFloatPrice.Text = "Price: N/A";
            }
        }

        // --- Event Handlers for Menu Checkboxes ---
        private void cbMangoFloat_CheckedChanged(object sender, EventArgs e)
        {
            EnableMangoFloatControls(cbMangoFloat.Checked);
        }

        private void cbKamoteFloat_CheckedChanged(object sender, EventArgs e)
        {
            EnableKamoteFloatControls(cbKamoteFloat.Checked);
        }

        private void cbKangkongFloat_CheckedChanged(object sender, EventArgs e)
        {
            EnableKangkongFloatControls(cbKangkongFloat.Checked);
        }

        // --- Event Handlers for Size RadioButtons ---
        private void MangoSizeRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                UpdateMangoFloatPriceLabel();
            }
        }

        private void KamoteSizeRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                UpdateKamoteFloatPriceLabel();
            }
        }

        private void KangkongSizeRadioButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                UpdateKangkongFloatPriceLabel();
            }
        }

        // Handles adding items to the order
        private void AddItemToOrder(string itemName, GroupBox sizeGroupBox, NumericUpDown quantityNUD)
        {
            // Validate if the checkbox for this item is checked
            string cbName = "cb" + itemName.Replace(" ", "");
            CheckBox itemCheckbox = sizeGroupBox.Parent.Controls.Find(cbName, true).FirstOrDefault() as CheckBox;

            if (itemCheckbox == null || !itemCheckbox.Checked)
            {
                MessageBox.Show($"Please select the '{itemName}' checkbox first to enable adding this item.", "Item Not Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            RadioButton selectedSizeRadioButton = sizeGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(rb => rb.Checked);

            if (selectedSizeRadioButton == null)
            {
                MessageBox.Show($"Please select a size for {itemName}.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedSize = selectedSizeRadioButton.Text;
            int quantity = (int)quantityNUD.Value;

            if (quantity <= 0)
            {
                MessageBox.Show($"Quantity for {itemName} must be at least 1.", "Invalid Quantity", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            decimal unitPrice;
            if (!sizePrices.TryGetValue(selectedSize, out unitPrice))
            {
                MessageBox.Show($"Invalid size selected for {itemName}. Please check size definitions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OrderItem newItem = new OrderItem(itemName, selectedSize, unitPrice, quantity);
            currentOrder.Add(newItem);

            UpdateOrderDisplay();
            CalculateOverallTotal();
        }

        private void btnAddMango_Click(object sender, EventArgs e)
        {
            AddItemToOrder("Mango Float", groupBoxMangoSizes, nudMangoFloatQuantity);
        }

        private void btnAddKamote_Click(object sender, EventArgs e)
        {
            AddItemToOrder("Kamote Float", groupBoxKamoteSizes, nudKamoteFloatQuantity);
        }

        private void btnAddKangkong_Click(object sender, EventArgs e)
        {
            AddItemToOrder("Kangkong Float", groupBoxKangkongSizes, nudKangkongFloatQuantity);
        }

        private void UpdateOrderDisplay()
        {
            dgvOrderItems.DataSource = null;
            dgvOrderItems.DataSource = currentOrder;
            dgvOrderItems.Refresh();
        }

        private void CalculateOverallTotal()
        {
            totalOrderAmount = currentOrder.Sum(item => item.LineTotal);
            totalAmountTextBox.Text = totalOrderAmount.ToString("0.00");

            if (decimal.TryParse(cashTextBox.Text, out decimal cash))
            {
                decimal change = cash - totalOrderAmount;
                changeTextBox.Text = change >= 0 ? change.ToString("0.00") : "0.00";
            }
        }

        private void cashTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!isCalculating)
            {
                isCalculating = true;

                if (decimal.TryParse(cashTextBox.Text, out decimal cash))
                {
                    if (cash < 0)
                    {
                        cash = 0;
                        cashTextBox.Text = "0";
                        MessageBox.Show("Cash amount cannot be negative. Setting to 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (cash > 10000)
                    {
                        cash = 10000;
                        cashTextBox.Text = "10000";
                        MessageBox.Show("Maximum cash amount is ₱10,000. Setting to ₱10,000.", "Limit Exceeded", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    decimal change = cash - totalOrderAmount;
                    changeTextBox.Text = change >= 0 ? change.ToString("0.00") : "0.00";
                }
                else if (!string.IsNullOrEmpty(cashTextBox.Text))
                {
                    cashTextBox.Text = "0";
                    changeTextBox.Text = "0.00";
                    MessageBox.Show("Please enter a valid amount for cash. Setting to 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                isCalculating = false;
            }
        }

        private void btnGenerateReceipt_Click(object sender, EventArgs e)
        {
            if (currentOrder.Count == 0)
            {
                MessageBox.Show("Please add items to the order before generating a receipt.", "Order Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(cashTextBox.Text, out decimal cash) || cash <= 0)
            {
                MessageBox.Show("Please enter a valid cash amount.", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cashTextBox.Focus();
                return;
            }

            if (cash < totalOrderAmount)
            {
                MessageBox.Show($"Insufficient cash. Total amount is ₱{totalOrderAmount:0.00}.", "Insufficient Funds", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string cashAmount = cashTextBox.Text;
            string changeAmount = changeTextBox.Text;

            receiptTextBox.Text = GenerateReceiptText(cashAmount, changeAmount);

            System.Media.SystemSounds.Beep.Play();

            if (MessageBox.Show("Receipt generated successfully!\n\nWould you like to print this receipt?", "Success",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show("Printing functionality would be implemented here.", "Print Receipt", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private string GenerateReceiptText(string cash, string change)
        {
            System.Text.StringBuilder receipt = new System.Text.StringBuilder();
            receipt.AppendLine("=== FLOAT ORDER RECEIPT ===");
            receipt.AppendLine($"Date: {DateTime.Now:yyyy-MM-dd HH:mm}");
            receipt.AppendLine($"Order #: {DateTime.Now.Ticks.ToString().Substring(8, 6)}");
            receipt.AppendLine("---------------------------");
            receipt.AppendLine("Item            Qty   Price   Total");
            receipt.AppendLine("---------------------------");

            foreach (var item in currentOrder)
            {
                string itemDisplay = $"{item.ItemName} ({item.Size})";
                string itemNameShort = itemDisplay.Length > 15 ? itemDisplay.Substring(0, 15) : itemDisplay.PadRight(15);
                receipt.AppendLine($"{itemNameShort} {item.Quantity,3} {item.UnitPrice,8:0.00} {item.LineTotal,8:0.00}");
            }

            receipt.AppendLine("---------------------------");
            receipt.AppendLine($"TOTAL:  ₱{totalOrderAmount:0.00}");
            receipt.AppendLine($"CASH:   ₱{decimal.Parse(cash):0.00}");
            receipt.AppendLine($"CHANGE: ₱{decimal.Parse(change):0.00}");
            receipt.AppendLine("===========================");
            receipt.AppendLine("Thank you for your order!");
            receipt.AppendLine("Please come again!");

            return receipt.ToString();
        }

        private void DecimalTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void btnRemoveSelectedItem_Click(object sender, EventArgs e)
        {
            if (dgvOrderItems.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvOrderItems.SelectedRows)
                {
                    OrderItem itemToRemove = row.DataBoundItem as OrderItem;
                    if (itemToRemove != null)
                    {
                        currentOrder.Remove(itemToRemove);
                    }
                }
                UpdateOrderDisplay();
                CalculateOverallTotal();
            }
            else
            {
                MessageBox.Show("Please select an item from the order list to remove.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClearOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to clear the entire order?", "Confirm Clear Order", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ClearOrderAndResetControls();
            }
        }

        private void ClearOrderAndResetControls()
        {
            currentOrder.Clear();
            UpdateOrderDisplay();
            CalculateOverallTotal();
            cashTextBox.Text = "0";
            changeTextBox.Text = "0.00";
            receiptTextBox.Clear();

            // Reset menu item selections and NUDs
            cbMangoFloat.Checked = false;
            cbKamoteFloat.Checked = false;
            cbKangkongFloat.Checked = false;
            nudMangoFloatQuantity.Value = 1;
            nudKamoteFloatQuantity.Value = 1;
            nudKangkongFloatQuantity.Value = 1;
        }

        private void nudKangkongFloatQuantity_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}