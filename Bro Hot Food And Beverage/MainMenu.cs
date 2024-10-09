using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Bro_Hot_Food_And_Beverage
{
    public partial class MainMenu : Form
    {
        int quantity = 0;
        double srv;

        public MainMenu()
        {
            
            InitializeComponent();
            getvalue();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            add_new_meal add_New_Meal = new add_new_meal();
            add_New_Meal.ShowDialog();
        }

        private void MainMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MessageBox.Show("sajuuu");
            }
        }

        private void guna2Button51_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button52_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button53_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button54_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button55_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button56_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button57_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button58_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button59_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button60_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button61_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button62_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button63_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button64_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button65_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button66_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button67_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button68_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button69_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button70_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button71_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button72_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button73_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button74_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void guna2Button29_Click(object sender, EventArgs e)
        {
            String kottuF = btn_CkottuF.Text;
            kottuF = "Chiken Kottu Full";
            
            txt_meal_name.Text = kottuF;
            txt_meal_price.Text = "800";
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }


        //quantity eke button deka  (+ ekai - ekai)
        private void btn_qty_plus_Click(object sender, EventArgs e)
        {
            
                quantity++;
                txt_qty.Text = quantity.ToString();
            if (double.TryParse(txt_meal_price.Text, out a) == false)
            {
                MessageBox.Show("nothing");
            }
            else
            {
                double Price = Convert.ToDouble(txt_meal_price.Text);
                double total = 0.00;
                quantity = Convert.ToInt32(txt_qty.Text);

                total = Price * quantity;

                txt_tot.Text = total.ToString();
            }

        }

        private void btn_qty_minus_Click(object sender, EventArgs e)
        {
            double b;
                quantity--;
                txt_qty.Text = quantity.ToString();
            double total = 0.00;
            if (double.TryParse(txt_meal_price.Text, out b) == false)
            {
                MessageBox.Show("nothing");
            }
            else
            {
                double Price = Convert.ToDouble(txt_meal_price.Text);
                total = Convert.ToInt32(txt_tot.Text);
                total = total - Price;
                txt_tot.Text = total.ToString();
            }
        }

        private void btn_CkotttuR_Click(object sender, EventArgs e)
        {
            String kottuR = btn_CkottuR.Text;
            kottuR = "Chiken Kottu Reguler";

            txt_meal_name.Text = kottuR;
            txt_meal_price.Text = "800";
        }

        //add button in qty section
        private void guna2Button77_Click(object sender, EventArgs e)
        {
            try
            {
                string meal;
                int quantity = 0;
                double Price = 0.00;
                double total = 0.00;


                meal = txt_meal_name.Text;
                quantity=Convert.ToInt32(txt_qty.Text);
                Price=Convert.ToDouble(txt_meal_price.Text);
                total = Convert.ToDouble(txt_tot.Text);



                double ntot;
                if (swtch_sch.Checked == true)
                {


                    srv = total * 10 / 100;
                    ntot = total + srv;
                }
                else
                {
                    ntot = total;
                }


                dataGridView3.Rows.Add(meal, quantity, Price, srv, ntot);





                txt_meal_name.Clear();
                txt_meal_price.Clear();
                txt_qty.Clear();
                txt_tot.Clear();
                swtch_sch.Checked = false;


                srv = 0;







                /*MySqlConnection connection = new DbCon().connectDB();
                connection.Open();
                string query = "insert into bill (Meal, Quantity, price ) VALUES(@Meal, @Quantity, @price)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Meal", meal);
                command.Parameters.AddWithValue("@Quantity", Convert.ToInt32(txt_qty.Text));
                command.Parameters.AddWithValue("@price", Convert.ToDouble(txt_meal_price.Text));


                txt_meal_name.Clear();
                txt_meal_price.Clear();
                txt_qty.Clear();



                command.ExecuteNonQuery();*/
                MessageBox.Show("Items add succesfully");
                getvalue();
                
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
            quantity = 0;
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            txt_meal_name.Clear();
            txt_meal_price.Clear();
            txt_qty.Clear();   
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        public void getvalue()
        {
            lbl_tot.Text = "0";
            double tot;
            double tl;
            double ftot;
            for (int i = 0; i < dataGridView3.Rows.Count; i++)
            {

                tot = Convert.ToDouble(lbl_tot.Text);
                tl = Convert.ToDouble(dataGridView3.Rows[i].Cells[4].Value);
                ftot = tot + tl;
                lbl_tot.Text = ftot.ToString();
            }
        }

        private void MainMenu_Load_1(object sender, EventArgs e)
        {

        }
    }
}
