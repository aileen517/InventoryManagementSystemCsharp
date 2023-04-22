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
    public partial class frmcustomers : Form
    {
        public frmcustomers()
        {
            InitializeComponent();
        }
        SQLConfig config = new SQLConfig();
        usableFunction funct = new usableFunction();
        string sql;

        private void btn_New_Click_1(object sender, EventArgs e)
        {
            lbl_id1.Text = "id";


            config.Load_DTG("Select SUPLIERCUSTOMERID as 'ID' ,FIRSTNAME as 'Firstname',LASTNAME as 'Lastname',ADDRESS as 'Address',MOBILE as 'Mobile',TELEPHONE as 'Telephone',TYPE as 'Type' From tblperson", dtg_listcustomer);
            dtg_listcustomer.Columns[0].Visible = true;

            if (lbl_id1.Text == "id")
            {
                btn_update1.Enabled = true;
                btn_delete1.Enabled =true;
                btn_saveuser.Enabled = true;
            }
            else
            {
                btn_saveuser.Enabled = false;
                btn_update1.Enabled = true;
                btn_delete1.Enabled = true;
            }

            funct.clearTxt(Panel1);
        }

        private void frmcustomers_Load(object sender, EventArgs e)
        {
            btn_New_Click_1(sender, e);
        }

        private void btn_saveuser_Click(object sender, EventArgs e)
        {


            if (txt_firstname.Text == "" || txt_lastname.Text == "" || SID.Text == "" || TEL.Text == "" || txt_address.Text == "" || txt_mobile.Text == "")
            {
                MessageBox.Show("Field must be filled up", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                sql = "insert into tblperson (SUPLIERCUSTOMERID, FIRSTNAME, LASTNAME, ADDRESS, MOBILE, TELEPHONE,TYPE) "

                     + "values('" + SID.Text
                                                              + "','" + txt_firstname.Text
                                                              + "','" + txt_lastname.Text
                                                               + "','" + txt_address.Text 
                                                               + "','" + txt_mobile.Text
                                                               + "','" + TEL.Text
                                                              + "','" + cbo_typ.Text
                                                             
                                                              + "')";
                config.Execute_CUD(sql, "Unable to saved", "Data has been saved in the database.");
                frmcustomers_Load(sender, e);
            }


        }

       
        private void btn_delete_Click(object sender, EventArgs e)
        {
            {
                sql = "delete from tblperson where ID = '" + lbl_id1.Text + "'";
                config.Execute_CUD(sql, "unable to delete", "Data has been deleted in the database");
                frmcustomers_Load(sender, e);
            }

        }



        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtg_listcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                SID.Text = dtg_listcustomer.CurrentRow.Cells[0].Value.ToString();
                txt_firstname.Text = dtg_listcustomer.CurrentRow.Cells[1].Value.ToString();
                txt_lastname.Text = dtg_listcustomer.CurrentRow.Cells[2].Value.ToString();
                txt_address.Text = dtg_listcustomer.CurrentRow.Cells[3].Value.ToString();
                txt_mobile.Text = dtg_listcustomer.CurrentRow.Cells[4].Value.ToString();
                TEL.Text = dtg_listcustomer.CurrentRow.Cells[5].Value.ToString();
                cbo_typ.Text = dtg_listcustomer.CurrentRow.Cells[6].Value.ToString();
            }
        }

        private void lbl_id1_Click(object sender, EventArgs e)
        {

            {
                if (lbl_id1.Text == "id")
                {
                    btn_update1.Enabled = false;
                    btn_delete1.Enabled = false;
                    btn_saveuser.Enabled = true;
                }
                else
                {
                    btn_saveuser.Enabled = false;
                    btn_update1.Enabled = true;
                    btn_delete1.Enabled = true;
                }
            }
        }

        private void btn_update1_Click(object sender, EventArgs e)
        {
            {
                if (txt_firstname.Text == "" || SID.Text == "" || TEL.Text == "" || cbo_typ.Text == "" || txt_lastname.Text == "" || txt_address.Text == "" || txt_mobile.Text == "")
                {
                    MessageBox.Show("Field must be filled up", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    sql = "update tblperson set FIRSTNAME =  '" + txt_firstname.Text + "',LASTNAME= '" + txt_lastname.Text
                         
                          + "',ADDRESS= '" + txt_address.Text 
                          + "',MOBILE= '" + txt_mobile.Text
                          + "',TELEPHONE= '" + TEL.Text
                         
                          + "',TYPE= '" + cbo_typ.Text
                          + "'  where ID = " + lbl_id1.Text;
                    config.Execute_CUD(sql, "Unable to update", "Data has been updated in the database.");
                    frmcustomers_Load(sender, e);
                }


            }

        }

        private void txt_firstname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_mobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
        }
    
    

