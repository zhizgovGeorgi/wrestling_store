using LogicLayer;
using Modules;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace WrestlingStoreApp
{
    public partial class AdminForm : Form
    {
        private ProductManager pm;
        private UserManager um;
        private OrderManager om;
        public AdminForm()
        {
            InitializeComponent();
            pm = new ProductManager(new ProductData());
            um = new UserManager(new UserData());
            om = new OrderManager(new OrderData());
            LoadProducts();
            LoadUsers();
            LoadCompleteOrders();
            tbAdditionalInfo.Visible = false;
            lblAdditionalInfo.Visible = false;
            lblAdditionalInfo.Text = "";
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            try
            {

                if (rbWrestlingAccessories.Checked)
                {
                    if (tbProdName.Text == "")
                    {
                        MessageBox.Show("Please enter name  of the product");
                        return;

                    }
                    if (tbProdCategory.Text == "")
                    {
                        MessageBox.Show("Please enter category  of the product");
                        return;

                    }
                    if (tbProdPrice.Text == "")
                    {
                        MessageBox.Show("Please enter price  of the product");
                        return;

                    }
                    if (tbProdImg.Text == "")
                    {
                        MessageBox.Show("Please enter image  of the product");
                        return;

                    }
                    Product product = new WrestlingAccessories(tbProdName.Text, tbProdCategory.Text, Convert.ToDouble(tbProdPrice.Text), tbProdImg.Text);
                    if (pm.AddProduct(product) == true)
                    {
                        MessageBox.Show("Successful addition of product");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("Sorry, there seems to be the same product!");
                    }
                    LoadProducts();
                }

                else if (rbWrestlingClothes.Checked)
                {
                    if (tbProdName.Text == "")
                    {
                        MessageBox.Show("Please enter name  of the product");
                        return;

                    }
                    if (tbProdCategory.Text == "")
                    {
                        MessageBox.Show("Please enter category  of the product");
                        return;

                    }
                    if (tbProdPrice.Text == "")
                    {
                        MessageBox.Show("Please enter price  of the product");
                        return;

                    }
                    if (tbProdImg.Text == "")
                    {
                        MessageBox.Show("Please enter image  of the product");
                        return;

                    }
                    if (tbAdditionalInfo.Text == "")
                    {
                        MessageBox.Show("Please enter material  of the product");
                        return;

                    }
                    Product product = new WrestlingClothes(tbProdName.Text, tbProdCategory.Text, Convert.ToDouble(tbProdPrice.Text), tbProdImg.Text, tbAdditionalInfo.Text);
                    pm.AddProduct(product);
                    LoadProducts();
                }
                else if (rbWrestlingShoes.Checked)
                {
                    if (tbProdName.Text == "")
                    {
                        MessageBox.Show("Please enter name  of the product");
                        return;

                    }
                    if (tbProdCategory.Text == "")
                    {
                        MessageBox.Show("Please enter category  of the product");
                        return;

                    }
                    if (tbProdPrice.Text == "")
                    {
                        MessageBox.Show("Please enter price  of the product");
                        return;

                    }
                    if (tbProdImg.Text == "")
                    {
                        MessageBox.Show("Please enter image  of the product");
                        return;

                    }
                    if (tbAdditionalInfo.Text == "")
                    {
                        MessageBox.Show("Please enter kind  of the product");
                        return;

                    }
                    Product product = new WrestlingShoes(tbProdName.Text, tbProdCategory.Text, Convert.ToDouble(tbProdPrice.Text), tbProdImg.Text, tbAdditionalInfo.Text);
                    pm.AddProduct(product);
                    LoadProducts();
                }
                else
                {
                    MessageBox.Show("Please select the type of Product!");
                }
            }
            catch (System.FormatException)
            {

                MessageBox.Show("The information provided is incorrect!");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            lbProducts.Items.Clear();
            foreach (Product p in pm.GetProducts())
            {
                lbProducts.Items.Add(p);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a product!");
                return;
            }
            pm.RemoveProduct((Product)lbProducts.SelectedItem);
            LoadProducts();
        }

        private void rbWrestlingShoes_CheckedChanged(object sender, EventArgs e)
        {
            tbAdditionalInfo.Visible = true;
            lblAdditionalInfo.Visible = true;
            lblAdditionalInfo.Text = "Kind";
        }

        private void rbWrestlingClothes_CheckedChanged(object sender, EventArgs e)
        {
            tbAdditionalInfo.Visible = true;
            lblAdditionalInfo.Visible = true;
            lblAdditionalInfo.Text = "Material";
        }

        private void rbWrestlingAccessories_CheckedChanged(object sender, EventArgs e)
        {
            tbAdditionalInfo.Visible = false;
            lblAdditionalInfo.Visible = false;
            lblAdditionalInfo.Text = "";
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            if (tbFName.Text =="")
            {
                MessageBox.Show("Please fill in First Name");
                return;
            }
            else if (tbLName.Text == "")
            {
                MessageBox.Show("Please fill in last Name");
                return;
            }
            else if(tbEmail.Text == "")
            {
                MessageBox.Show("Please fill in email");
                return;
            }
            else if(tbAddress.Text == "")
            {
                MessageBox.Show("Please fill in Adress");
                return;
            }
            else if (tbPassword.Text == "")
            {
                MessageBox.Show("Please fill in password");
                return;
            }

            try
            {
                User user = new User(tbFName.Text, tbLName.Text, tbEmail.Text, tbAddress.Text, tbPassword.Text, "Administrator");
                um.AddUser(user);
                LoadUsers();
            }
            catch (System.FormatException)
            {

                MessageBox.Show("The information provided is incorrect!");
                return;
            }
        }

        private void btnRemoveAdmin_Click(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex < 0)
            {
                MessageBox.Show("Please select an administrator");
                return;
            }
            User selectedUser = (User)lbUsers.SelectedItem;
            try
            {
                if (selectedUser.Role == "Administrator")
                {
                    um.RemoveUser(selectedUser);
                    LoadUsers();
                }
                else
                {
                    MessageBox.Show("You are allowed to only create other administrators!");
                    return;
                }
            }
            catch (System.NullReferenceException)
            {

                MessageBox.Show("Please, select a User!");
            }

        }

        private void btnShowAllUsers_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            lbUsers.Items.Clear();
            foreach (User user in um.GetAllUsers())
            {
                lbUsers.Items.Add(user);
            }
        }

        private void LoadCompleteOrders()
        {
            lbOrders.Items.Clear();
            foreach (Order order in om.GetCartItems())
            {
                if (order.Status == Status.Complete)
                {

                    lbOrders.Items.Add(order);
                }
            }
        }

        private void LoadConfirmedOrders()
        {
            lbOrders.Items.Clear();
            foreach (Order order in om.GetCartItems())
            {
                if (order.Status == Status.Confirmed)
                {

                    lbOrders.Items.Add(order);
                }
            }
        }

        private void LoadDeclinedOrders()
        {
            lbOrders.Items.Clear();
            foreach (Order order in om.GetCartItems())
            {
                if (order.Status == Status.Declined)
                {

                    lbOrders.Items.Add(order);
                }
            }
        }
        private void LoadAllOrders()
        {
            lbOrders.Items.Clear();
            foreach (Order order in om.GetCartItems())
            {
                if (order.Status == Status.Declined || order.Status == Status.Confirmed || order.Status == Status.Confirmed)
                {

                    lbOrders.Items.Add(order);
                }
            }
        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            if (rbCoplete.Checked)
            {
                LoadCompleteOrders();
            }
            else if (rbConfirmed.Checked)
            {
                lbOrders.Items.Clear();
                LoadConfirmedOrders();
            }
            else if (rbDeclined.Checked)
            {
                lbOrders.Items.Clear();
                LoadDeclinedOrders();
            }
            else if (rbAll.Checked)
            {
                lbOrders.Items.Clear();
                LoadAllOrders();
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            Order oi = (Order)lbOrders.SelectedItem;
            if (oi.Status == Status.Complete)
            {
                om.EditOrder(oi, Status.Declined);
                LoadDeclinedOrders();
            }
            else
            {
                MessageBox.Show("Once an order is Confirmed it cannot be re-declined!");
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Order oi = (Order)lbOrders.SelectedItem;
            if (oi.Status == Status.Complete)
            {
                om.EditOrder(oi, Status.Confirmed);
                LoadConfirmedOrders();
            }
            else
            {
                MessageBox.Show("Once an order is Declined it cannot be re-confirmed!");
            }
        }

        private void lbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbProducts.SelectedIndex < 0)
            {
                return;
            }
            Object productObject = lbProducts.SelectedItem;
            if (!(productObject is Product))
            {
                return;
            }
            Product product = (Product)productObject;
            tbProdID.Text = product.Prod_id.ToString();
            tbProdName.Text = product.ProdName;
            tbProdPrice.Text = product.ProdPrice.ToString();
            tbProdCategory.Text = product.ProdCategory;
            tbProdImg.Text = product.ProdImg;
            if (product is WrestlingShoes)
            {
                tbAdditionalInfo.Text = ((WrestlingShoes)product).KindOfActivity;
            }
            else if (product is WrestlingClothes)
            {
                tbAdditionalInfo.Text = ((WrestlingClothes)product).Material;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lbProducts.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a product first");
                return;
            }


            Product p;
            if (rbWrestlingAccessories.Checked)
            {
                p = new WrestlingAccessories(Convert.ToInt32(tbProdID.Text), tbProdName.Text, "Wrestling Accessories", Convert.ToDouble(tbProdPrice.Text), tbProdImg.Text);
                if (pm.EditProduct(p) == true)
                {
                    MessageBox.Show("Successful update of the product");
                    LoadProducts();
                    return;
                }
                else
                {
                    MessageBox.Show("Oops, sorry something went wrong, please try again later");
                }
            }
            else if (rbWrestlingClothes.Checked)
            {
                p = new WrestlingClothes(Convert.ToInt32(tbProdID.Text), tbProdName.Text, "Wrestling Clothes", Convert.ToDouble(tbProdPrice.Text), tbProdImg.Text, tbAdditionalInfo.Text);
                if (pm.EditProduct(p) == true)
                {
                    MessageBox.Show("Successful update of the product");
                    LoadProducts();
                    return;
                }
                else
                {
                    MessageBox.Show("Oops, sorry something went wrong, please try again later");
                }
            }
            else if (rbWrestlingShoes.Checked)
            {
                p = new WrestlingShoes(Convert.ToInt32(tbProdID.Text), tbProdName.Text, "Wrestling Shoes", Convert.ToDouble(tbProdPrice.Text), tbProdImg.Text, tbAdditionalInfo.Text);
                if (pm.EditProduct(p) == true)
                {
                    MessageBox.Show("Successful update of the product");
                    LoadProducts();
                    return;
                }
                else
                {
                    MessageBox.Show("Oops, sorry something went wrong, please try again later");
                }

            }
            else
            {
                MessageBox.Show("Please select a category!");
            }

        }

        private void lbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbUsers.SelectedIndex < 0)
            {
                return;
            }
            Object userObject = lbUsers.SelectedItem;
            if (!(userObject is User))
            {
                return;
            }
            User user = (User)userObject;
            tbID.Text = user.Id.ToString();
            tbFName.Text = user.FName;
            tbLName.Text = user.LName;
            tbEmail.Text = user.Email;
            tbAddress.Text = user.Adress;
        }
    }
}
