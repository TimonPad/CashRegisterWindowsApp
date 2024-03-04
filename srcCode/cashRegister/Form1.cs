using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using CsvHelper;
using System.IO;
using CsvHelper.Configuration;
using System.Globalization;

namespace cashRegister
{
    public partial class cashMain : MetroForm
    {
        public static cashMain instance;
        public static float CalculateTotal()
        {
            float result = 0.0f;
            for(int row_index=0; row_index < cashMain.instance.salesGrid1.RowCount; row_index++)
            {
                
                result += float.Parse(cashMain.instance.salesGrid1.Rows[row_index].Cells["total"].Value.ToString());
            }
            return result;
            
        }
        public static string getSelectedProductName()
        {
            var index_row = cashMain.instance.productGrid1.CurrentCell.RowIndex;
            return cashMain.instance.productGrid1.Rows[index_row].Cells["Products"].Value.ToString();
        }

        //public MetroFramework.Controls.MetroGrid ProductGrid
        //{
        //    get { return productGrid1; }
        //}
        //public MetroFramework.Controls.MetroGrid SaleGrid { get { return salesGrid1; } }
        public cashMain()
        {
            // instance of the current  form
            instance = this;
            InitializeComponent();
            InitialiseProductGrid();
            InitialiseSalesGrid();
            //cancelBtn.Enabled = false;
            deletebtn.Enabled = false;
            productGrid1.ScrollBars = ScrollBars.Both;
            productGrid1.Height = productGrid1.Height + 1;
            productGrid1.Width = productGrid1.Width + 1;
            productGrid1.Height = productGrid1.Height - 1;

        }
        
        private void InitialiseProductGrid()
        {
            productGrid1.ColumnCount = 2;
            productGrid1.Columns[0].Name = "Products";
            
            productGrid1.Columns[1].Name = "Price";

        }
        private void InitialiseSalesGrid()
        {
            salesGrid1.ColumnCount = 4;
            salesGrid1.Columns[0].Name = "Items";
            salesGrid1.Columns[1].Name = "units";
            salesGrid1.Columns[2].Name = "unit Price";
            salesGrid1.Columns[3].Name = "total";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadProducts_Click(object sender, EventArgs e)
        {
            if(load_dialog.ShowDialog()== DialogResult.OK)
            {
                
                //Console.WriteLine(productGrid1.RowCount);
                productGrid1.Rows.Clear();
                var reader = new StreamReader(load_dialog.FileName);
                var csv_reader = new CsvReader(reader, CultureInfo.InvariantCulture);
                var GetData = csv_reader.GetRecords<ProductRow>();
                foreach (var row_data in GetData)
                {
                    if(row_data.Availability == true)
                    {
                        Console.WriteLine(row_data.ProductName);
                        //string[] row = { row_data.ProductName, row_data.Price.ToString() };
                        int rowId = productGrid1.Rows.Add();

                        // Grab the new row!
                        DataGridViewRow row = productGrid1.Rows[rowId];

                        // Add the data
                        row.Cells["Products"].Value = row_data.ProductName;
                        row.Cells["Price"].Value = row_data.Price.ToString();

                        //var listItem = new ListViewItem(row);
                        //Mainlist.Items.Add(listItem);
                    }
                    
                }
                productGrid1.PerformLayout();
                reader.Close();
                if(productGrid1.RowCount > 0)
                {
                    addbtn.Enabled = true;
                }


            }
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            addSaleGrid frm = new addSaleGrid();
            frm.ShowDialog();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
            DateTime now = DateTime.Now;
            string document_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string file_name = String.Format("{0}.txt", now.ToString("yyyy-MM-dd.HH.mm.ss"));
            string day_folder = string.Format(@"transactions\{0}",now.ToString("yyyy-MM-dd"));
            string base_dir = Path.Combine(document_path, day_folder);
            // path for day total
            string day_total_path = Path.Combine(base_dir, "dayTotal.csv");
            bool exist = Directory.Exists(base_dir);
            if( !exist)
            {
                Directory.CreateDirectory(base_dir);
                var day_file = new StreamWriter(day_total_path);
                day_file.Close();
            }
            var file = new StreamWriter(Path.Combine(base_dir, file_name));

            file.WriteLine("grand Total:\t{0}", totalPrice.Text);
            for (int i_row = 0; i_row < cashMain.instance.salesGrid1.RowCount; i_row++)
            {
                var row = cashMain.instance.salesGrid1.Rows[i_row];
                file.WriteLine("Item:\t{0}\tnumber:\t{1}", row.Cells["Items"].Value.ToString(), row.Cells["units"].Value.ToString());


            }
            UpdateDayTotal(day_total_path);

            
            file.Close();
            MessageBox.Show("Transaction is saved ! !", "Success!");
            salesGrid1.Rows.Clear();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var pRowIndex = salesGrid1.CurrentCell.RowIndex;
            float new_total = float.Parse(totalPrice.Text) - float.Parse(salesGrid1.Rows[pRowIndex].Cells["total"].Value.ToString());
            totalPrice.Text = new_total.ToString();
            salesGrid1.Rows.RemoveAt(pRowIndex);
            if(salesGrid1.RowCount <= 0)
            {
                deletebtn.Enabled = false;
            }
        }
        private void WriteNew(string path)
        {
            var writer = new StreamWriter(path);
            var csvWriter = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csvWriter.WriteHeader<DayTotal>();
            csvWriter.NextRecord();
            for (int i_row = 0; i_row < cashMain.instance.salesGrid1.RowCount; i_row++)
            {
                var row = cashMain.instance.salesGrid1.Rows[i_row];
                var product = new DayTotal(row.Cells["Items"].Value.ToString(),int.Parse(row.Cells["units"].Value.ToString()));
                csvWriter.WriteRecord(product);
                csvWriter.NextRecord();

            }
            csvWriter.Flush();
            writer.Close();
        }
        //private Tuple<bool, DayTotal> IsExists(string product)
        //{
        //    for (int i_row = 0; i_row < cashMain.instance.salesGrid1.RowCount; i_row++)
        //    {
        //        var row = cashMain.instance.salesGrid1.Rows[i_row];
        //        var product_name = row.Cells["Items"].Value.ToString();
        //        if(product_name == product)
        //        {
        //            return new Tuple<bool, DayTotal>(true, new DayTotal(product_name, int.Parse(row.Cells["units"].Value.ToString())));
                    
        //        }
        //        else


        //    }
        //        return true;
        //}
        private void Update(string path)
        {
            var reader = new StreamReader(path);
            var csv_reader = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv_reader.GetRecords<DayTotal>().ToList();
            reader.Close();
            for (int i_row = 0; i_row < cashMain.instance.salesGrid1.RowCount; i_row++)
            {
                var row = cashMain.instance.salesGrid1.Rows[i_row];
                var product_name = row.Cells["Items"].Value.ToString();
                // main file
                
                // temporary file
                //var temp_writer = new StreamWriter(Path.Combine(Path.GetDirectoryName(path), "temp.csv"));
                //var csv_tempWriter = new CsvWriter(temp_writer, CultureInfo.InvariantCulture);
                //csv_tempWriter.WriteHeader<DayTotal>();
                //csv_tempWriter.NextRecord();
                bool is_found = false;
                foreach (var row_record in records)
                {
                    if (product_name == row_record.product )
                    {
                        row_record.count += int.Parse(row.Cells["units"].Value.ToString());
                        is_found = true;
                        break;
                    }
                    //csv_tempWriter.WriteRecord(row_record);
                    //csv_tempWriter.NextRecord();
                }
                if (is_found)
                {
                    continue;
                }
                records.Add(new DayTotal(product_name, int.Parse(row.Cells["units"].Value.ToString())));

            }
            
            var file = new StreamWriter(path);
            var csvWriter = new CsvWriter(file, CultureInfo.InvariantCulture);
            csvWriter.WriteHeader<DayTotal>();
            csvWriter.NextRecord();
            foreach (var record in records)
            {
                csvWriter.WriteRecord(record);
                csvWriter.NextRecord();

            }
            csvWriter.Flush();
            file.Close();


        }
        private void UpdateDayTotal(string path_csv)
        {
            var csvFileLenth = new System.IO.FileInfo(path_csv).Length;
            if (csvFileLenth == 0)
            {
                WriteNew(path_csv);

            }
            else
            {
                Update(path_csv);
            }
        }
    }
    // class used to read the data from the product csv file
    public class ProductRow
    {
        public string ProductName { get; set; }
        public float Price { get; set; }
        public bool Availability { get; set; }
        public ProductRow(string ProductName, float Price, bool Availability)
        {
            
            this.ProductName = ProductName;
            this.Price = Price;
            this.Availability = Availability;

        }
    }
    // class used to update the data for the day total csv file
    public class DayTotal
    {
        public string product { get; set; }
        public int count { get; set; }
        public DayTotal(string product, int count)
        {
            this.product = product;
            this.count = count;
        }
    }

}
