using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventorySystem1._0.Includes;

namespace InventorySystem1._0
{
    public partial class OR : Form
    {
        public OR()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;
        private void dtgor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
            
        }

        private void OR_Load(object sender, EventArgs e)
        {
            sql = "SELECT  `TRANSACTIONNUMBER` as TRANSACTIONID,`TRANSACTIONDATE` as DATE,`SUPLIERCUSTOMERID` as 'CUSTOMER ID', `TOTAL` as TOTAL FROM  `tblor`" ;
      
            config.Load_DTG(sql, dtgor);

  


        }

       
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Order Summary", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(230));
            e.Graphics.DrawString("Transaction ID:" + dtgor.CurrentRow.Cells[0].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 100));
            e.Graphics.DrawString("Date:" + dtgor.CurrentRow.Cells[1].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 133));
            e.Graphics.DrawString("Customer ID:" + dtgor.CurrentRow.Cells[2].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 166));
            e.Graphics.DrawString("Total:" + dtgor.CurrentRow.Cells[3].Value.ToString(), new Font("Century", 20, FontStyle.Regular), Brushes.Black, new Point(80, 199));
            e.Graphics.DrawString("PoweredByDakki", new Font("Century", 25, FontStyle.Bold), Brushes.Red, new Point(230, 350));
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            sql = "SELECT `TRANSACTIONNUMBER` as TRANSACTIONID,`TRANSACTIONDATE` as DATE,`SUPLIERCUSTOMERID` as 'CUSTOMER ID', `TOTAL` as TOTAL FROM `tblor` WHERE  `TRANSACTIONNUMBER` like '%" + txtsearch.Text + "%' or `TRANSACTIONNUMBER` = '" + txtsearch.Text + "'";
            config.Load_DTG(sql, dtgor);
            funct.ResponsiveDtg(dtgor);
        }

       
    }
}
