using System.DirectoryServices.ActiveDirectory;
using System.Runtime.Intrinsics.Arm;
//created by chouayb.belhizia@gmail.com
namespace MyRestaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float GetSelectedSizePrice()
        {
            if (rbSmall.Checked)
                return Convert.ToSingle(rbSmall.Tag);
            if (rbMedium.Checked)
                return Convert.ToSingle(rbMedium.Tag);
            else
                return Convert.ToSingle(rbLarge.Tag);
        }

        float CalculateToppingsPrice()
        {
            float ToppingPrice = 0;
            if (chbExtra.Checked)
                ToppingPrice += Convert.ToSingle(chbExtra.Tag);
            if (chbGreenPepper.Checked)
                ToppingPrice += Convert.ToSingle(chbGreenPepper.Tag);
            if (chbOlives.Checked)
                ToppingPrice += Convert.ToSingle(chbOlives.Tag);
            if (chbOnion.Checked)
                ToppingPrice += Convert.ToSingle(chbOnion.Tag);
            if (chbMushroom.Checked)
                ToppingPrice += Convert.ToSingle(chbMushroom.Tag);
            if (chbTomatoes.Checked)
                ToppingPrice += Convert.ToSingle(chbTomatoes.Tag);
            return ToppingPrice;
        }

        float GetSelectedCrustPrice()
        {
            if (rbThick.Checked)
                return Convert.ToSingle(rbThick.Tag);
            else
                return Convert.ToSingle(rbThin.Tag);
        }

        float CalculateTotalPrice()
        {
            return GetSelectedSizePrice() + CalculateToppingsPrice()
                + GetSelectedCrustPrice();
        }

        void UpdateTotalPrice()
        {
            lblTotalPrice.Text = "$" + CalculateTotalPrice().ToString();
        }
        void UpdateSize()
        {
            UpdateTotalPrice();
            if (rbSmall.Checked)
            {
                lblSize.Text = "Small";
                return;
            }

            if (rbMedium.Checked)
            {
                lblSize.Text = "Medium";
                return;
            }
            if (rbLarge.Checked)
            {
                lblSize.Text = "Large";
                return;
            }







        }

        void UpdateToppings()
        {
            UpdateTotalPrice();

            string Toppings = "";


            if (chbExtra.Checked)
            {
                Toppings += "Extra Chees";
            }

            if (chbGreenPepper.Checked)
            {
                Toppings += ",Green Pepper";
            }

            if (chbOnion.Checked)
            {
                Toppings += ",Onion";
            }

            if (chbOlives.Checked)
            {
                Toppings += ", Olives";
            }

            if (chbMushroom.Checked)
            {
                Toppings += ", Mushroom";
            }

            if (chbTomatoes.Checked)
            {
                Toppings += ", Tomatoes";
            }

            if (Toppings == "")
            {
                Toppings = "No Toppings";
            }

            if (Toppings.StartsWith(','))
            {
                Toppings.Substring(1, Toppings.Length - 1).Trim();
            }


            lblToppings.Text = Toppings;

        }

        void UpdateCrust()
        {
            UpdateTotalPrice();
            if (rbThick.Checked)
            {
                lblCrust.Text = "Thick";
                return;
            }
            else
            {
                lblCrust.Text = "Thin";
                return;
            }
        }

        void UpdateWhereToEat()
        {
            if (rbEatIn.Checked)
            {
                lblWhere.Text = "Eat In";
                return;
            }
            if (rbEatOut.Checked)
            {
                lblWhere.Text = "Eat Out";
                return;
            }
        }

        void Reset()
        {
            //grp
            gbSize.Enabled = true;
            gbToppings.Enabled = true;
            gbCrust.Enabled = true;
            gbWhereEat.Enabled = true;

            //reset size
            rbMedium.Checked = true;

            //reset whreToeat
            rbEatIn.Checked = true;

            //reset crust
            rbThin.Checked = true;

            //reset toppings
            chbExtra.Checked = false;
            chbOnion.Checked = false;
            chbOlives.Checked = false;
            chbGreenPepper.Checked = false;
            chbMushroom.Checked = false;
            chbTomatoes.Checked = false;
            //
            btnOrder.Enabled = true;

        }


        void UpdateOrderSummary()
        {
            UpdateSize();
            UpdateToppings();
            UpdateCrust();
            UpdateWhereToEat();
            UpdateTotalPrice();
        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void rbLarge_CheckedChanged(object sender, EventArgs e)
        {
            UpdateSize();
        }

        private void chbExtra_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chbOnion_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chbMushroom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chbOlives_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chbTomatoes_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void chbGreenPepper_CheckedChanged(object sender, EventArgs e)
        {
            UpdateToppings();
        }

        private void rbThin_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbThick_CheckedChanged(object sender, EventArgs e)
        {
            UpdateCrust();
        }

        private void rbEatIn_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbEatOut_CheckedChanged(object sender, EventArgs e)
        {
            UpdateWhereToEat();
        }

        private void rbOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Order", "Confirm",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question)
                == DialogResult.OK)
            {

                MessageBox.Show("Order Placed Successfully", "Success",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnOrder.Enabled = false;
                gbSize.Enabled = false;
                gbToppings.Enabled = false;
                gbCrust.Enabled = false;
                gbWhereEat.Enabled = false;

            }
            else
                MessageBox.Show("Update Your Order", "Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);


        }

        private void rbReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOrderSummary();
        }


    }
}