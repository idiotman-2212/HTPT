using Dotmim.Sync;
using Dotmim.Sync.Enumerations;
using Dotmim.Sync.SqlServer;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_HTPT
{
    public partial class ControlProduct : UserControl
    {
        private readonly Product product;
        private ProductDAO productDAO;
        private enum SaveType { INSERT, UPDATE, DELETE, NONE };
        private SaveType saveType;
        private string connectionString;
        private string connectionStringNext;

        private void InitProductDAO()
        {
            productDAO = new ProductDAO(ConnectionString);
        }

        public string ConnectionString
        {
            get => connectionString;

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    connectionString = value;
                }
            }
        }

        public string ConnectionStringNext
        {
            get => connectionStringNext;

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    connectionStringNext = value;
                }
            }
        }

        public ControlProduct()
        {
            InitializeComponent();
            product = new Product();
            saveType = SaveType.NONE;
        }

        public void SetVisibleButton(bool flag)
        {
            buttonInsert.Visible = flag;
            buttonUpdate.Visible = flag;
            buttonDelete.Visible = flag;
            buttonSave.Visible = flag;
            buttonCancel.Visible = flag;

        }

        public void SetVisivlePropagateButton(bool flag)
        {
            buttonPropagate.Visible = flag;
        }

        public void LoadData()
        {
            DataTable tableProduct = productDAO.GetProductTable();
            if (tableProduct.Rows.Count > 0)
            {
                tableProduct.Columns[0].ColumnName = "Mã sản phẩm";
                tableProduct.Columns[1].ColumnName = "Tên sản phẩm";
                tableProduct.Columns[2].ColumnName = "Giá";
                tableProduct.Columns[3].ColumnName = "Ngày sản xuất";
                tableProduct.Columns[4].ColumnName = "Đang còn hàng";
                dataGridViewProduct.Columns.Clear();
                dataGridViewProduct.DataSource = tableProduct;
                GetInfoRowSelected();
            }
            CheckProductTableData();
        }

        private void GetInfoProductFormInputField()
        {
            int.TryParse(textBoxProductID.Text, out int productID);
            product.ProductID = productID;
            product.ProductName = textBoxProductName.Text;
            decimal.TryParse(textBoxPrice.Text, out decimal price);
            product.Price = price;
            product.ManufactureDate = dateTimePickerManufactureDate.Value;
            product.IsAvailable = checkBoxIsAvailable.Checked;
        }

        private void GetInfoRowSelected()
        {
            if (dataGridViewProduct.CurrentRow != null)
            {
                int index = dataGridViewProduct.CurrentRow.Index;
                //get infor from row to input field
                textBoxProductID.Text = dataGridViewProduct.Rows[index].Cells[0].Value.ToString();
                textBoxProductName.Text = dataGridViewProduct.Rows[index].Cells[1].Value.ToString();
                textBoxPrice.Text = dataGridViewProduct.Rows[index].Cells[2].Value.ToString();
                DateTime.TryParse(dataGridViewProduct.Rows[index].Cells[3].Value.ToString(), out DateTime manufactureDate);
                dateTimePickerManufactureDate.Value = manufactureDate;
                bool.TryParse(dataGridViewProduct.Rows[index].Cells[4].Value.ToString(), out bool isAvailabel);
                checkBoxIsAvailable.Checked = isAvailabel;
            }
            else
            {
                ClearInput();
            }
        }

        private void ClearInput()
        {
            textBoxProductID.Clear();
            textBoxProductName.Clear();
            textBoxPrice.Clear();
            dateTimePickerManufactureDate.Value = DateTime.Now;
            checkBoxIsAvailable.Checked = false;
        }

        private bool IsInputValid()
        {
            bool flag = (textBoxProductID.Text.Length != 0) && (textBoxPrice.Text.Length != 0) && (textBoxProductName.Text.Length != 0);
            if (!flag)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flag;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (saveType == SaveType.INSERT)
            {
                if (IsInputValid())
                {
                    GetInfoProductFormInputField();
                    if (productDAO.InsertProduct(product))
                    {
                        WriteNoitify("Thêm sản phẩm thành công.");
                    }
                    else
                    {
                        WriteNoitify("Thêm sản phẩm không thành công.");
                    }
                    saveType = SaveType.NONE;
                    SetEnableEditButton(false);
                    SetEnableInput(false);
                    LoadData();
                }
            }
            else if (saveType == SaveType.UPDATE)
            {
                if (IsInputValid())
                {
                    GetInfoProductFormInputField();
                    if (productDAO.UpdateProduct(product))
                    {
                        WriteNoitify("Cập nhật sản phẩm thành công.");
                    }
                    else
                    {
                        WriteNoitify("Cập nhật sản phẩm không thành công.");
                    }
                    saveType = SaveType.NONE;
                    SetEnableEditButton(false);
                    SetEnableInput(false);
                    LoadData();
                }
            }
            else if (saveType == SaveType.DELETE)
            {
                if (productDAO.DeleteProduct(product))
                {
                    WriteNoitify("Xóa sản phẩm thành công.");
                }
                else
                {
                    WriteNoitify("Xóa sản phẩm không thành công.");
                }
                saveType = SaveType.NONE;
                SetEnableEditButton(false);
                SetEnableInput(false);
                LoadData();
            }
        }


        private void CancelButton_Click(object sender, EventArgs e)
        {
            ClearInput();
            GetInfoRowSelected();
            SetEnableEditButton(false);
            SetEnableInput(false);
            LoadData();

        }

        private void SetEnableInput(bool flag)
        {
            textBoxProductID.ReadOnly = !flag;
            textBoxProductName.ReadOnly = !flag;
            textBoxPrice.ReadOnly = !flag;
            dateTimePickerManufactureDate.Enabled = flag;
            checkBoxIsAvailable.Enabled = flag;
        }

        private void SetEnableEditButton(bool flag)
        {
            buttonSave.Enabled = flag;
            buttonCancel.Enabled = flag;
            buttonPropagate.Enabled = !flag;
            buttonReload.Enabled = !flag;
            buttonInsert.Enabled = !flag;
            buttonUpdate.Enabled = !flag;
            buttonDelete.Enabled = !flag;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            ClearInput();
            SetEnableInput(true);
            saveType = SaveType.INSERT;
            SetEnableEditButton(true);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            SetEnableInput(true);
            textBoxProductID.ReadOnly = true;
            saveType = SaveType.UPDATE;
            SetEnableEditButton(true);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduct.Rows.Count > 0)
            {
                GetInfoProductFormInputField();
                dataGridViewProduct.Rows.Remove(dataGridViewProduct.SelectedRows[0]);
                saveType = SaveType.DELETE;
                SetEnableEditButton(true);
            }
        }

        private async Task PushDataDownAsync(string serverConnectionString, string clientConnectionString)
        {
            try
            {
                // Database chủ
                SqlSyncProvider serverProvider = new SqlSyncProvider(serverConnectionString);
                // Database đích
                SqlSyncProvider clientProvider = new SqlSyncProvider(clientConnectionString);

                // Chọn bảng Product
                var setup = new SyncSetup("Product");

                // Khởi tạo lớp đông bộ
                Dotmim.Sync.SyncOptions syncOptions = new SyncOptions();
                SyncAgent agent = new SyncAgent(clientProvider, serverProvider);

                //Bắt đầu đồng bộ
                var syncContext = await agent.SynchronizeAsync(setup,SyncType.Reinitialize);

                WriteNoitify(syncContext.ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in PushDataDown method: {ex.Message}");
            }
        }

        private void PropagateButton_Click(object sender, EventArgs e)
        {
            _ = PushDataDownAsync(ConnectionString, ConnectionStringNext);
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void PriceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((textBoxPrice.Text.Length == 0) && (e.KeyChar == '.'))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && (textBoxPrice.Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ProductIDTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ButtonClearNotify_Click(object sender, EventArgs e)
        {
            textBoxNotify.Clear();
        }

        private void DataGridViewProduct_SelectionChanged(object sender, EventArgs e)
        {
            GetInfoRowSelected();
        }

        private void WriteNoitify(string notify)
        {
            textBoxNotify.Text += $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}:{Environment.NewLine}{notify}{Environment.NewLine}{Environment.NewLine}";
            textBoxNotify.SelectionStart = textBoxNotify.Text.Length;
        }

        private void ControlProduct_Load(object sender, EventArgs e)
        {
            buttonSave.Enabled = false;
            buttonCancel.Enabled = false;
            InitProductDAO();
            LoadData();
        }

        private void DataGridViewProduct_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CheckProductTableData();
        }

        private void CheckProductTableData()
        {
            bool flag = dataGridViewProduct.Rows.Count > 0;
            buttonUpdate.Enabled = flag;
            buttonDelete.Enabled = flag;
        }

        private void DataGridViewProduct_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            CheckProductTableData();
        }
    }
}
