using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_System
{
    public partial class Form1 : Form
    {
        BindingList<Order> Orders;
        BindingList<Online> Orders1;
        public Form1()
        {
            InitializeComponent();
            Orders = new BindingList<Order>();
            Orders1 = new BindingList<Online>();
            lstOutput.AutoGenerateColumns = true;

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            cmbOrderMade.Items.Add("Select Order");
            cmbOrderMade.Items.Add("Account");
            cmbOrderMade.Items.Add("Telephone");
            cmbOrderMade.Items.Add("Instore Order");
            cmbOrderMade.Items.Add("Online Order");

            grbOnline.Hide();

            cmbPayment.Items.Add("Select Type");
            cmbPayment.Items.Add("Cash");
            cmbPayment.Items.Add("Master Card");
            cmbPayment.Items.Add("Visa Card");
            cmbPayment.Items.Add("Direct Debit");

            lstBrand.Items.Add("Kenyan");
            lstBrand.Items.Add("South African");
            lstBrand.Items.Add("Canadian");
            lstBrand.Items.Add("USA");
            lstBrand.Items.Add("Indian");

            chkBeans.Checked = false;
            chkFullSet.Checked = false;
            chkMeat.Checked = false;
            chkRice.Checked = false;

            rbEight.Checked = false;
            rbFour.Checked = false;
            rbOne.Checked = false;
            rbTwo.Checked = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult iExit;
            iExit = MessageBox.Show("Confirm if you want to exit", "Order System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtFirstName.Clear();
            txtSurname.Clear();
            chkBeans.Checked = false;
            chkFullSet.Checked = false;
            chkMeat.Checked = false;
            chkRice.Checked = false;

            rbEight.Checked = false;
            rbFour.Checked = false;
            rbOne.Checked = false;
            rbTwo.Checked = false;

            lstBrand.SelectedItems.Clear();
            lstOutput.ClearSelection();
            cmbOrderMade.Text = "Select Order";
            cmbPayment.Text = "Select Type";

        }

        private void btnAddmore_Click(object sender, EventArgs e)
        {
            txtCustomerID.Clear();
            txtFirstName.Clear();
            txtSurname.Clear();
            chkBeans.Checked = false;
            chkFullSet.Checked = false;
            chkMeat.Checked = false;
            chkRice.Checked = false;

            rbEight.Checked = false;
            rbFour.Checked = false;
            rbOne.Checked = false;
            rbTwo.Checked = false;

            lstBrand.SelectedItems.Clear();
            cmbOrderMade.Text = "Select Order";
            cmbPayment.Text = "Select Type";


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String ID, Firstname, Surname, SelectOrder, SelectType, SelectDate, Website, Delivery, Price;
           
            double Kenyan_Price = 4.59;
            double Canadian_Price = 5.5;
            double Indian_Price = 4.5;
            double S_Africa_Price = 6.5;
            double USA_Price = 3.79;

            Order MyOrder = new Order();
            MyOrder.CustomerID = txtCustomerID.Text;
            MyOrder.Firstname = txtFirstName.Text;
            MyOrder.Surname = txtSurname.Text;
            MyOrder.OrderType = cmbOrderMade.Text;
            MyOrder.SelectType = cmbPayment.Text;
            MyOrder.DateOrdered = dateTimePicker1.Text;
            Orders.Add(MyOrder);
            Online MyOrder1 = new Online();
            MyOrder1.WebSite = txtWebsite.Text;
            MyOrder1.Delivery = txtDelivery.Text;
            Orders1.Add(MyOrder1);
            lstOutput.DataSource = Orders;

            ID = txtCustomerID.Text;
            Firstname = txtFirstName.Text;
            Surname = txtSurname.Text;
            SelectOrder = cmbOrderMade.Text;
            SelectType = cmbPayment.Text;
            SelectDate = dateTimePicker1.Text;
            Website = txtWebsite.Text;
            Delivery = txtDelivery.Text;


            if (lstBrand.Text == "")
            {
                MessageBox.Show("You must select a brand", "Brands", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((chkBeans.Checked == false) && (chkMeat.Checked == false) && (chkRice.Checked == false))
            {
                MessageBox.Show("You must select an item", "Items", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if ((rbOne.Checked == false) && (rbTwo.Checked == false) && (rbFour.Checked == false) && (rbEight.Checked == false))
            {
                MessageBox.Show("You must select quantity", "Quantity", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            //IF Statement is used to claculate the 10% off of the in store while else if statement calculates the other order types

            //----------------------------------------------------------------------//

            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Canadian" && chkBeans.Checked == true && rbOne.Checked == true)
            {
                MyOrder.Price = (Canadian_Price * 1 * .9).ToString();
            }
            else if(lstBrand.Text == "Canadian" && chkBeans.Checked == true && rbOne.Checked == true)
            {
                MyOrder.Price = (Canadian_Price * 1).ToString();
            }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Canadian" && chkBeans.Checked == true && rbTwo.Checked == true)
            {
                MyOrder.Price = (Canadian_Price * 2 * .9).ToString();
            }
            else if(lstBrand.Text == "Canadian" && chkBeans.Checked == true && rbTwo.Checked == true)
            {
                MyOrder.Price = (Canadian_Price * 2).ToString();
            }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Canadian" && chkBeans.Checked == true && rbFour.Checked == true)
            {
                MyOrder.Price = (Canadian_Price * 4 * .9).ToString();
            }
            else if(lstBrand.Text == "Canadian" && chkBeans.Checked == true && rbFour.Checked == true)
            {
                MyOrder.Price = (Canadian_Price * 4).ToString();
            }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Canadian" && chkBeans.Checked == true && rbEight.Checked == true)
            {
                MyOrder.Price = (Canadian_Price * 8 * .9).ToString();
            }
            else if(lstBrand.Text == "Canadian" && chkBeans.Checked == true && rbEight.Checked == true)
            {
                MyOrder.Price = (Canadian_Price * 8).ToString();
            }

            //-----------------------------------------------------------------------------------//

            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Canadian" && chkMeat.Checked == true && rbOne.Checked == true)
                {
                    MyOrder.Price = (Canadian_Price * 1.1 * .9).ToString();
                }
                else if(lstBrand.Text == "Canadian" && chkMeat.Checked == true && rbOne.Checked == true)
                {
                    MyOrder.Price = (Canadian_Price * 1.1).ToString();
                }

            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Canadian" && chkMeat.Checked == true && rbTwo.Checked == true)
                {
                    MyOrder.Price = (Canadian_Price * 2.1 * .9).ToString();
                }
                else if(lstBrand.Text == "Canadian" && chkMeat.Checked == true && rbTwo.Checked == true)
                {
                    MyOrder.Price = (Canadian_Price * 2.1 * .9).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Canadian" && chkMeat.Checked == true && rbFour.Checked == true)
                {
                    MyOrder.Price = (Canadian_Price * 4.1 * .9).ToString();
                }
                else if(lstBrand.Text == "Canadian" && chkMeat.Checked == true && rbFour.Checked == true)
                {
                    MyOrder.Price = (Canadian_Price * 4.1).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Canadian" && chkMeat.Checked == true && rbEight.Checked == true)
                {
                    MyOrder.Price = (Canadian_Price * 8.1 * .9).ToString();
                }
                else if(lstBrand.Text == "Canadian" && chkMeat.Checked == true && rbEight.Checked == true)
                {
                    MyOrder.Price = (Canadian_Price * 8.1).ToString();
                }

            //-------------------------------------------------------------------------------------//

            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Canadian" && chkRice.Checked == true && rbOne.Checked == true)
                {
                    MyOrder.Price = (Canadian_Price * 1.01 * .9).ToString();
                }
                else if(lstBrand.Text == "Canadian" && chkRice.Checked == true && rbOne.Checked == true)
                {
                    MyOrder.Price = (Canadian_Price * 1.01).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Canadian" && chkRice.Checked == true && rbTwo.Checked == true)
                {
                    MyOrder.Price = (Canadian_Price * 2.05 * .9).ToString();
                }
                else if(lstBrand.Text == "Canadian" && chkRice.Checked == true && rbTwo.Checked == true)
                {
                    MyOrder.Price = (Canadian_Price * 2.05).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Canadian" && chkRice.Checked == true && rbFour.Checked == true)
                {
                    MyOrder.Price = (Canadian_Price * 3.1 * .9).ToString();
                }
                else if(lstBrand.Text == "Canadian" && chkRice.Checked == true && rbFour.Checked == true)
                {
                    MyOrder.Price = (Canadian_Price * 3.1).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Canadian" && chkRice.Checked == true && rbEight.Checked == true)
                {
                    MyOrder.Price = (Canadian_Price * 7.1 *.9).ToString();
                }
                else if(lstBrand.Text == "Canadian" && chkRice.Checked == true && rbEight.Checked == true)
                {
                    MyOrder.Price = (Canadian_Price * 7.1).ToString();
                }
            //--------------------------------------------------------------------------------------//
            //--------------------------------------------------------------------------------------//

            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Indian" && chkBeans.Checked == true && rbOne.Checked == true)
                {
                    MyOrder.Price = (Indian_Price * 1 * .9).ToString();
                }
                else if(lstBrand.Text == "Indian" && chkBeans.Checked == true && rbOne.Checked == true)
                {
                    MyOrder.Price = (Indian_Price * 1).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Indian" && chkBeans.Checked == true && rbTwo.Checked == true)
                {
                    MyOrder.Price = (Indian_Price * 2 *.9).ToString();
                }
                else if(lstBrand.Text == "Indian" && chkBeans.Checked == true && rbTwo.Checked == true)
                {
                    MyOrder.Price = (Indian_Price * 2).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Indian" && chkBeans.Checked == true && rbFour.Checked == true)
                {
                    MyOrder.Price = (Indian_Price * 4 * .9).ToString();
                }
                else if(lstBrand.Text == "Indian" && chkBeans.Checked == true && rbFour.Checked == true)
                {
                    MyOrder.Price = (Indian_Price * 4).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Indian" && chkBeans.Checked == true && rbEight.Checked == true)
                {
                    MyOrder.Price = (Indian_Price * 8 *.9).ToString();
                }
                else
                {
                    MyOrder.Price = (Indian_Price * 8).ToString();
                }

            //-----------------------------------------------------------------------------------//

            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Indian" && chkMeat.Checked == true && rbOne.Checked == true)
                {
                    MyOrder.Price = (Indian_Price * 1.1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (Indian_Price * 1.1).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Indian" && chkMeat.Checked == true && rbTwo.Checked == true)
                {
                    MyOrder.Price = (Indian_Price * 2.1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (Indian_Price * 2.1).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Indian" && chkMeat.Checked == true && rbFour.Checked == true)
                {
                    MyOrder.Price = (Indian_Price * 4.1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (Indian_Price * 4.1).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Indian" && chkMeat.Checked == true && rbEight.Checked == true)
                {
                    MyOrder.Price = (Indian_Price * 8.1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (Indian_Price * 8.1).ToString();
                }

            //-------------------------------------------------------------------------------------//

            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Indian" && chkRice.Checked == true && rbOne.Checked == true)
                {
                    MyOrder.Price = (Indian_Price * 1.01 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (Indian_Price * 1.01).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Indian" && chkRice.Checked == true && rbTwo.Checked == true)
                {
                    MyOrder.Price = (Indian_Price * 2.05 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (Indian_Price * 2.05).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Indian" && chkRice.Checked == true && rbFour.Checked == true)
                {
                    MyOrder.Price = (Indian_Price * 3.1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (Indian_Price * 3.1).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Indian" && chkRice.Checked == true && rbEight.Checked == true)
                {
                    MyOrder.Price = (Indian_Price * 7.1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (Indian_Price * 7.1).ToString();
                }

            //-------------------------------------------------------------------------------------//
            //-------------------------------------------------------------------------------------//

            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "South African" && chkBeans.Checked == true && rbOne.Checked == true)
                {
                    MyOrder.Price = (S_Africa_Price * 1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (S_Africa_Price * 1).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "South African" && chkBeans.Checked == true && rbTwo.Checked == true)
                {
                    MyOrder.Price = (S_Africa_Price * 2 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (S_Africa_Price * 2).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "South African" && chkBeans.Checked == true && rbFour.Checked == true)
                {
                    MyOrder.Price = (S_Africa_Price * 4 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (S_Africa_Price * 4).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "South African" && chkBeans.Checked == true && rbEight.Checked == true)
                {
                    MyOrder.Price = (S_Africa_Price * 8 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (S_Africa_Price * 8).ToString();
                }

            //-----------------------------------------------------------------------------------//

            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "South African" && chkMeat.Checked == true && rbOne.Checked == true)
                {
                    MyOrder.Price = (S_Africa_Price * 1.1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (S_Africa_Price * 1.1).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "South African" && chkMeat.Checked == true && rbTwo.Checked == true)
                {
                    MyOrder.Price = (S_Africa_Price * 2.1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (S_Africa_Price * 2.1).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "South African" && chkMeat.Checked == true && rbFour.Checked == true)
                {
                    MyOrder.Price = (S_Africa_Price * 4.1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (S_Africa_Price * 4.1).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "South African" && chkMeat.Checked == true && rbEight.Checked == true)
                {
                    MyOrder.Price = (S_Africa_Price * 8.1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (S_Africa_Price * 8.1).ToString();
                }

            //-------------------------------------------------------------------------------------//

            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "South African" && chkRice.Checked == true && rbOne.Checked == true)
                {
                    MyOrder.Price = (S_Africa_Price * 1.01 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (S_Africa_Price * 1.01).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "South African" && chkRice.Checked == true && rbTwo.Checked == true)
                {
                    MyOrder.Price = (S_Africa_Price * 2.05 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (S_Africa_Price * 2.05).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "South African" && chkRice.Checked == true && rbFour.Checked == true)
                {
                    MyOrder.Price = (S_Africa_Price * 3.1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (S_Africa_Price * 3.1).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "South African" && chkRice.Checked == true && rbEight.Checked == true)
                {
                    MyOrder.Price = (S_Africa_Price * 7.1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (S_Africa_Price * 7.1).ToString();
                }

            //-------------------------------------------------------------------------------------//
            //-------------------------------------------------------------------------------------//

            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "USA" && chkBeans.Checked == true && rbOne.Checked == true)
                {
                    MyOrder.Price = (USA_Price * 1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (USA_Price * 1).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "USA" && chkBeans.Checked == true && rbTwo.Checked == true)
                {
                    MyOrder.Price = (USA_Price * 2 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (USA_Price * 2).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "USA" && chkBeans.Checked == true && rbFour.Checked == true)
                {
                    MyOrder.Price = (USA_Price * 4 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (USA_Price * 4).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "USA" && chkBeans.Checked == true && rbEight.Checked == true)
                {
                    MyOrder.Price = (USA_Price * 8 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (USA_Price * 8).ToString();
                }

            //-----------------------------------------------------------------------------------//

            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "USA" && chkMeat.Checked == true && rbOne.Checked == true)
                {
                    MyOrder.Price = (USA_Price * 1.1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (USA_Price * 1.1).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "USA" && chkMeat.Checked == true && rbTwo.Checked == true)
                {
                    MyOrder.Price = (USA_Price * 2.1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (USA_Price * 2.1).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "USA" && chkMeat.Checked == true && rbFour.Checked == true)
                {
                    MyOrder.Price = (USA_Price * 4.1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (USA_Price * 4.1).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "USA" && chkMeat.Checked == true && rbEight.Checked == true)
                {
                    MyOrder.Price = (USA_Price * 8.1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (USA_Price * 8.1).ToString();
                }

            //-------------------------------------------------------------------------------------//

            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "USA" && chkRice.Checked == true && rbOne.Checked == true)
                {
                    MyOrder.Price = (USA_Price * 1.01 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (USA_Price * 1.01).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "USA" && chkRice.Checked == true && rbTwo.Checked == true)
                {
                    MyOrder.Price = (USA_Price * 2.05 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (USA_Price * 2.05).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "USA" && chkRice.Checked == true && rbFour.Checked == true)
                {
                    MyOrder.Price = (USA_Price * 3.1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (USA_Price * 3.1).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "USA" && chkRice.Checked == true && rbEight.Checked == true)
                {
                    MyOrder.Price = (USA_Price * 7.1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (USA_Price * 7.1).ToString();
                }

            //--------------------------------------------------------------------------//
            //--------------------------------------------------------------------------//

            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Kenyan" && chkBeans.Checked == true && rbOne.Checked == true)
                {
                    MyOrder.Price = (Kenyan_Price * 1 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (Kenyan_Price * 1).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Kenyan" && chkBeans.Checked == true && rbTwo.Checked == true)
                {
                    MyOrder.Price = (Kenyan_Price * 2 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (Kenyan_Price * 2).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Kenyan" && chkBeans.Checked == true && rbFour.Checked == true)
                {
                    MyOrder.Price = (Kenyan_Price * 4 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (Kenyan_Price * 4).ToString();
                }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Kenyan" && chkBeans.Checked == true && rbEight.Checked == true)
                {
                    MyOrder.Price = (Kenyan_Price * 8 * .9).ToString();
                }
                else
                {
                    MyOrder.Price = (Kenyan_Price * 8).ToString();
                }

            //-----------------------------------------------------------------------------------//

            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Kenyan" && chkMeat.Checked == true && rbOne.Checked == true)
                    {
                        MyOrder.Price = (Kenyan_Price * 1.1 * .9).ToString();
                    }
                    else
                    {
                        MyOrder.Price = (Kenyan_Price * 1.1).ToString();
                    }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Kenyan" && chkMeat.Checked == true && rbTwo.Checked == true)
                    {
                        MyOrder.Price = (Kenyan_Price * 2.1 * .9).ToString();
                    }
                    else
                    {
                        MyOrder.Price = (Kenyan_Price * 2.1).ToString();
                    }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Kenyan" && chkMeat.Checked == true && rbFour.Checked == true)
                    {
                        MyOrder.Price = (Kenyan_Price * 4.1 * .9).ToString();
                    }
                    else
                    {
                        MyOrder.Price = (Kenyan_Price * 4.1).ToString();
                    }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Kenyan" && chkMeat.Checked == true && rbEight.Checked == true)
                    {
                        MyOrder.Price = (Kenyan_Price * 8.1 * .9).ToString();
                    }
                    else
                    {
                        MyOrder.Price = (Kenyan_Price * 8.1).ToString();
                    }

            //-------------------------------------------------------------------------------------//

            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Kenyan" && chkRice.Checked == true && rbOne.Checked == true)
                    {
                        MyOrder.Price = (Kenyan_Price * 1.01 * .9).ToString();
                    }
                    else
                    {
                        MyOrder.Price = (Kenyan_Price * 1.01).ToString();
                    }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Kenyan" && chkRice.Checked == true && rbTwo.Checked == true)
                    {
                        MyOrder.Price = (Kenyan_Price * 2.05 * .9).ToString();
                    }
                    else
                    {
                        MyOrder.Price = (Kenyan_Price * 2.05).ToString();
                    }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Kenyan" && chkRice.Checked == true && rbFour.Checked == true)
                    {
                        MyOrder.Price = (Kenyan_Price * 3.1 * .9).ToString();
                    }
                    else
                    {
                        MyOrder.Price = (Kenyan_Price * 3.1).ToString();
                    }
            if (cmbOrderMade.Text == "Instore Order" && lstBrand.Text == "Kenyan" && chkRice.Checked == true && rbEight.Checked == true)
                    {
                        MyOrder.Price = (Kenyan_Price * 7.1 * .9).ToString();
                    }
                    else
                    {
                        MyOrder.Price = (Kenyan_Price * 7.1).ToString();
                    }




        }
        private void chkFullSet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkFullSet.Checked)
            {
                chkMeat.Checked = true;
                chkRice.Checked = true;
                chkBeans.Checked = true;
            }
            else
            {
                chkMeat.Checked = false;
                chkRice.Checked = false;
                chkBeans.Checked = false;
            }
        }

        private void lstOutput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbOrderMade_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                if (cmbOrderMade.Text == "Online Order")
            {
                grbOnline.Show();
            }
            else
            {
                grbOnline.Hide();
            }
        }

        private void grbOnline_Enter(object sender, EventArgs e)
        {
            
        }
    }

        
    }
