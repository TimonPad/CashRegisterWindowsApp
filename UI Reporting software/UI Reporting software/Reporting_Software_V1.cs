using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsvHelper;
using System.IO;
using CsvHelper.Configuration;
using System.Globalization;

namespace UI_Reporting_software
{
    public partial class Form1 : Form
    {
        private string transctions_path { get; set; }
        public List<Items> Product { get; set; }

        private string base_dir { get; set; }
        private void InitialiseProductGrid()
        {
            Total_sales_grid.ColumnCount = 2;
            Total_sales_grid.Columns[0].Name = "Products";
            Total_sales_grid.Columns[0].Width = 230;

            Total_sales_grid.Columns[1].Name = "units";

           Top_sales_grid.ColumnCount = 3;
            Top_sales_grid.Columns[0].Name = "rank";
            Top_sales_grid.Columns[0].Width = 50;
            Top_sales_grid.Columns[1].Name = "Products";
            Top_sales_grid.Columns[1].Width = 200 ;
            Top_sales_grid.Columns[2].Name = "units";

            //Top_sales_grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
            //Total_sales_grid.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);


        }
        public Form1()
        {
            
            InitializeComponent();
            string document_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            base_dir = Path.Combine(document_path, "transactions");





        }
      

        private void Form1_Load(object sender, EventArgs e)
        {
            InitialiseProductGrid();
        }
        
        //private List<Items> GetProduct()
        //{

        //    var list = new List<Items>();
        //    list.Add(new Items()
        //    {
        //        Item_name = "Item 1",
        //        Unit_amount = 1,
        //        Unit_price = 100,
        //        Total = 100,
        //    });
            
        //    list.Add(new Items()
        //    {
        //        Item_name = "Item 2",
        //        Unit_amount = 1,
        //        Unit_price = 75,
        //        Total = 75,
        //    });

        //    return list;
        //}

        private void Total_sales_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Most_Items_text_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chooseTimelineToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Total_sales_text_Click(object sender, EventArgs e)
        {
        }

        private void Top_sales_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Reporting Software");
            Console.ReadLine();


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void chooseTimelineToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        List< string> AvailableDays(DateTime start, DateTime end)
        {
            List<string> all_paths = new List<string>();
            for (var day = start.Date; day.Date <= end.Date; day = day.AddDays(1))
            {
                if (Directory.Exists(Path.Combine(base_dir, day.ToString("yyyy-MM-dd"))))
                {
                    all_paths.Add(Path.Combine(base_dir, day.ToString("yyyy-MM-dd")));
                }
            }
            return all_paths;
        }
        private void TopLastWeek()
        {
            DayOfWeek weekStart = DayOfWeek.Monday; // or Sunday, or whenever
            DateTime startingDate = DateTime.Today;

            while (startingDate.DayOfWeek != weekStart)
            {
                startingDate = startingDate.AddDays(-1);
            }

            DateTime previousWeekStart = startingDate.AddDays(-7);
            DateTime previousWeekEnd = startingDate.AddDays(-1);
            //Console.WriteLine(previousWeekStart.ToString("yyyy-MM-dd"));
            //Console.WriteLine(previousWeekEnd.ToString("yyyy-MM-dd"));
            var dirs = AvailableDays(previousWeekStart, previousWeekEnd);
            var listProducts = GetProducts(dirs);
            var orderedProducts = listProducts.OrderByDescending(product => product.count);
            FillGrids(orderedProducts);
        }
        private void TopLastMonth()
        {
            var today = DateTime.Today;
            var month = new DateTime(today.Year, today.Month, 1);
            var first = month.AddMonths(-1);
            var last = month.AddDays(-1);
            //Console.WriteLine(first.ToString("yyyy-MM-dd"));
            //Console.WriteLine(last.ToString("yyyy-MM-dd"));
            var dirs = AvailableDays(first, last);
            var listProducts = GetProducts(dirs);
            var orderedProducts = listProducts.OrderByDescending(product => product.count);
            FillGrids(orderedProducts);


        }
       

       

        private List<DayTotal> GetProducts(IEnumerable<string> dirs)
        {
            List<DayTotal> all_products = new List<DayTotal>();
            //Console.WriteLine("all !");
            foreach (string dir in dirs)
            {

                string day_record = Path.Combine(dir, "dayTotal.csv");
                var reader = new StreamReader(day_record);
                var csv_reader = new CsvReader(reader, CultureInfo.InvariantCulture);
                var day_records = csv_reader.GetRecords<DayTotal>().ToList();
                reader.Close();
                foreach (var day_product in day_records)
                {
                    bool found = false;
                    foreach (var product in all_products)
                    {
                        if (day_product.product == product.product)
                        {
                            product.count += day_product.count;
                            found = true;
                            break;
                        }
                    }
                    if (found)
                    {
                        continue;
                    }
                    all_products.Add(day_product);
                }
                
            }
            return all_products;
        }
        
        private void FillGrids(IOrderedEnumerable<DayTotal> ordered_products)
        {
            int total = 0;
            int rank = 1;
            Total_sales_grid.Rows.Clear();
            Top_sales_grid.Rows.Clear();
            foreach (var product in ordered_products)
            {
                int rowId = Total_sales_grid.Rows.Add();

                DataGridViewRow row = Total_sales_grid.Rows[rowId];
                // Add the data
                row.Cells["Products"].Value = product.product;
                row.Cells["units"].Value = product.count.ToString();
                total += product.count;

                if(rank <= 10)
                {
                    int top_rowId = Top_sales_grid.Rows.Add();

                    DataGridViewRow top_row = Top_sales_grid.Rows[top_rowId];
                    // Add the data
                    top_row.Cells["rank"].Value = rank.ToString();
                    top_row.Cells["Products"].Value = product.product;
                    top_row.Cells["units"].Value = product.count.ToString();
                }
                rank++;
            }
            label2.Text = String.Format("total Sales {0}", total);

        }
        private void lastMonth_CheckedChanged(object sender, EventArgs e)
        {
            TopLastMonth();
        }

        private void lastWeekbtn_CheckedChanged(object sender, EventArgs e)
        {
            TopLastWeek();
        }

        private void allTimebtn_CheckedChanged(object sender, EventArgs e)
        {
            string document_path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string[] dirs = Directory.GetDirectories(Path.Combine(document_path, "transactions"));
            var listProducts = GetProducts(dirs);
            var orderedProducts = listProducts.OrderByDescending(product => product.count);
            FillGrids(orderedProducts);


        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }

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
