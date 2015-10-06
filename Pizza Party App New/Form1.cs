using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pizza_Party_App_New
{
    public partial class frmPizzaParty : Form
    {
        public frmPizzaParty()
        {
            InitializeComponent();
        }

        private void frmPizzaParty_Load(object sender, EventArgs e)
        {

        }

        //CLEAR BUTTON
        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear toppings check boxes
            cbxBlackOlive.Checked = false;
            cbxGreenPepper.Checked = false;
            cbxPepperoni.Checked = false;
            cbxSausage.Checked = false;

            //clear toppings pics back to cheese only
            picCheese.Visible = true;
            picGP.Visible = false;
            picOlive.Visible = false;
            picOliveGP.Visible = false;
            picPepAndOlive.Visible = false;
            picPepGP.Visible = false;
            picPepOliveGP.Visible = false;
            picPeppAndSaus.Visible = false;
            picPepperoni.Visible = false;
            picPepSausOlive.Visible = false;
            picPepSausOliveGP.Visible = false;
            picSausage.Visible = false;
            picSausGP.Visible = false;
            picSausOlive.Visible = false;
            picSausOliveGP.Visible = false;

            //clear pizza crust radio buttons
            rdoDeepDish.Checked = false;
            rdoRegular.Checked = false;
            rdoThinCrust.Checked = false;

            //clear pizza size radio buttons
            rdoSmall.Checked = false;
            rdoMedium.Checked = false;
            rdoLarge.Checked = false;

            //clear total charge box
            txtTotal.Text = "";
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxPepperoni_CheckedChanged(object sender, EventArgs e)
        {
            this.PizzaToppingsPicCheck(); 
            
        }

//**********Method to check the checkbox selection logic to find which picture to display***//

        private void PizzaToppingsPicCheck()
        {
            //CHEESE
            if (cbxPepperoni.Checked == false && cbxSausage.Checked == false && cbxBlackOlive.Checked == false && cbxGreenPepper.Checked == false)
            {
                picCheese.Visible = true;
                picGP.Visible = false;
                picOlive.Visible = false;
                picOliveGP.Visible = false;
                picPepAndOlive.Visible = false;
                picPepGP.Visible = false;
                picPepOliveGP.Visible = false;
                picPeppAndSaus.Visible = false;
                picPepperoni.Visible = false;
                picPepSausOlive.Visible = false;
                picPepSausOliveGP.Visible = false;
                picSausage.Visible = false;
                picSausGP.Visible = false;
                picSausOlive.Visible = false;
                picSausOliveGP.Visible = false;
            }

            //*****all pepperoni combinations

            //PEPPERONI
            else if (cbxPepperoni.Checked == true && cbxSausage.Checked == false && cbxBlackOlive.Checked == false && cbxGreenPepper.Checked == false)
            {
                picCheese.Visible = false;
                picGP.Visible = false;
                picOlive.Visible = false;
                picOliveGP.Visible = false;
                picPepAndOlive.Visible = false;
                picPepGP.Visible = false;
                picPepOliveGP.Visible = false;
                picPeppAndSaus.Visible = false;
                picPepperoni.Visible = true;
                picPepSausOlive.Visible = false;
                picPepSausOliveGP.Visible = false;
                picSausage.Visible = false;
                picSausGP.Visible = false;
                picSausOlive.Visible = false;
                picSausOliveGP.Visible = false;

            }
            //PEPPERONI & SAUSAGE
            else if (cbxPepperoni.Checked == true && cbxSausage.Checked == true && cbxBlackOlive.Checked == false && cbxGreenPepper.Checked == false)
            {
                picCheese.Visible = false;
                picGP.Visible = false;
                picOlive.Visible = false;
                picOliveGP.Visible = false;
                picPepAndOlive.Visible = false;
                picPepGP.Visible = false;
                picPepOliveGP.Visible = false;
                picPeppAndSaus.Visible = true;
                picPepperoni.Visible = false;
                picPepSausOlive.Visible = false;
                picPepSausOliveGP.Visible = false;
                picSausage.Visible = false;
                picSausGP.Visible = false;
                picSausOlive.Visible = false;
                picSausOliveGP.Visible = false;
            }
            //PEPPERONI, SAUSAGE & BLACK OLIVE
            else if (cbxPepperoni.Checked == true && cbxSausage.Checked == true && cbxBlackOlive.Checked == true && cbxGreenPepper.Checked == false)
            {
                picCheese.Visible = false;
                picGP.Visible = false;
                picOlive.Visible = false;
                picOliveGP.Visible = false;
                picPepAndOlive.Visible = false;
                picPepGP.Visible = false;
                picPepOliveGP.Visible = false;
                picPeppAndSaus.Visible = false;
                picPepperoni.Visible = false;
                picPepSausOlive.Visible = true;
                picPepSausOliveGP.Visible = false;
                picSausage.Visible = false;
                picSausGP.Visible = false;
                picSausOlive.Visible = false;
                picSausOliveGP.Visible = false;
            }
            //PEPPERONI, SAUSAGE, BLACK OLIVE & GREEN PEPPER
            else if (cbxPepperoni.Checked == true && cbxSausage.Checked == true && cbxBlackOlive.Checked == true && cbxGreenPepper.Checked == true)
            {
                picCheese.Visible = false;
                picGP.Visible = false;
                picOlive.Visible = false;
                picOliveGP.Visible = false;
                picPepAndOlive.Visible = false;
                picPepGP.Visible = false;
                picPepOliveGP.Visible = false;
                picPeppAndSaus.Visible = false;
                picPepperoni.Visible = false;
                picPepSausOlive.Visible = false;
                picPepSausOliveGP.Visible = true;
                picSausage.Visible = false;
                picSausGP.Visible = false;
                picSausOlive.Visible = false;
                picSausOliveGP.Visible = false;
            }

            //*****remaining sausage combinations
                //SAUSAGE
            else if (cbxPepperoni.Checked == false && cbxSausage.Checked == true && cbxBlackOlive.Checked == false && cbxGreenPepper.Checked == false)
            {
                picCheese.Visible = false;
                picGP.Visible = false;
                picOlive.Visible = false;
                picOliveGP.Visible = false;
                picPepAndOlive.Visible = false;
                picPepGP.Visible = false;
                picPepOliveGP.Visible = false;
                picPeppAndSaus.Visible = false;
                picPepperoni.Visible = false;
                picPepSausOlive.Visible = false;
                picPepSausOliveGP.Visible = false;
                picSausage.Visible = true;
                picSausGP.Visible = false;
                picSausOlive.Visible = false;
                picSausOliveGP.Visible = false;
            }
            //SAUSAGE AND BLACK OLIVE
            else if (cbxPepperoni.Checked == false && cbxSausage.Checked == true && cbxBlackOlive.Checked == true && cbxGreenPepper.Checked == false)
            {
                picCheese.Visible = false;
                picGP.Visible = false;
                picOlive.Visible = false;
                picOliveGP.Visible = false;
                picPepAndOlive.Visible = false;
                picPepGP.Visible = false;
                picPepOliveGP.Visible = false;
                picPeppAndSaus.Visible = false;
                picPepperoni.Visible = false;
                picPepSausOlive.Visible = false;
                picPepSausOliveGP.Visible = false;
                picSausage.Visible = false;
                picSausGP.Visible = false;
                picSausOlive.Visible = true;
                picSausOliveGP.Visible = false;
            }
            //SAUSAGE BLACK OLIVE AND GREEN PEPPER
            else if (cbxPepperoni.Checked == false && cbxSausage.Checked == true && cbxBlackOlive.Checked == true && cbxGreenPepper.Checked == true)
            {
                picCheese.Visible = false;
                picGP.Visible = false;
                picOlive.Visible = false;
                picOliveGP.Visible = false;
                picPepAndOlive.Visible = false;
                picPepGP.Visible = false;
                picPepOliveGP.Visible = false;
                picPeppAndSaus.Visible = false;
                picPepperoni.Visible = false;
                picPepSausOlive.Visible = false;
                picPepSausOliveGP.Visible = false;
                picSausage.Visible = false;
                picSausGP.Visible = false;
                picSausOlive.Visible = false;
                picSausOliveGP.Visible = true;
            }
            //SAUSAGE AND GREEN PEPPER
            else if (cbxPepperoni.Checked == false && cbxSausage.Checked == true && cbxBlackOlive.Checked == false && cbxGreenPepper.Checked == true)
            {
                picCheese.Visible = false;
                picGP.Visible = false;
                picOlive.Visible = false;
                picOliveGP.Visible = false;
                picPepAndOlive.Visible = false;
                picPepGP.Visible = false;
                picPepOliveGP.Visible = false;
                picPeppAndSaus.Visible = false;
                picPepperoni.Visible = false;
                picPepSausOlive.Visible = false;
                picPepSausOliveGP.Visible = false;
                picSausage.Visible = false;
                picSausGP.Visible = true;
                picSausOlive.Visible = false;
                picSausOliveGP.Visible = false;
            }
            //******remaining olive combinations
            //BLACK OLIVE
            else if (cbxPepperoni.Checked == false && cbxSausage.Checked == false && cbxBlackOlive.Checked == true && cbxGreenPepper.Checked == false)
            {
                picCheese.Visible = false;
                picGP.Visible = false;
                picOlive.Visible = true;
                picOliveGP.Visible = false;
                picPepAndOlive.Visible = false;
                picPepGP.Visible = false;
                picPepOliveGP.Visible = false;
                picPeppAndSaus.Visible = false;
                picPepperoni.Visible = false;
                picPepSausOlive.Visible = false;
                picPepSausOliveGP.Visible = false;
                picSausage.Visible = false;
                picSausGP.Visible = false;
                picSausOlive.Visible = false;
                picSausOliveGP.Visible = false;
            }
            //BLACK OLIVE AND GREEN PEPPER
            else if (cbxPepperoni.Checked == false && cbxSausage.Checked == false && cbxBlackOlive.Checked == true && cbxGreenPepper.Checked == true)
            {
                picCheese.Visible = false;
                picGP.Visible = false;
                picOlive.Visible = false;
                picOliveGP.Visible = true;
                picPepAndOlive.Visible = false;
                picPepGP.Visible = false;
                picPepOliveGP.Visible = false;
                picPeppAndSaus.Visible = false;
                picPepperoni.Visible = false;
                picPepSausOlive.Visible = false;
                picPepSausOliveGP.Visible = false;
                picSausage.Visible = false;
                picSausGP.Visible = false;
                picSausOlive.Visible = false;
                picSausOliveGP.Visible = false;
            }
            //******remaining green pepper
            //GREEN PEPPER
            else if (cbxPepperoni.Checked == false && cbxSausage.Checked == false && cbxBlackOlive.Checked == false && cbxGreenPepper.Checked == true)
            {
                picCheese.Visible = false;
                picGP.Visible = true;
                picOlive.Visible = false;
                picOliveGP.Visible = false;
                picPepAndOlive.Visible = false;
                picPepGP.Visible = false;
                picPepOliveGP.Visible = false;
                picPeppAndSaus.Visible = false;
                picPepperoni.Visible = false;
                picPepSausOlive.Visible = false;
                picPepSausOliveGP.Visible = false;
                picSausage.Visible = false;
                picSausGP.Visible = false;
                picSausOlive.Visible = false;
                picSausOliveGP.Visible = false;
            }



        }
    

        private void btnCalculateTotal_Click(object sender, EventArgs e)
        {
            

        }

        private void cbxSausage_CheckedChanged(object sender, EventArgs e)
        {
            this.PizzaToppingsPicCheck();
        }

        private void cbxBlackOlive_CheckedChanged(object sender, EventArgs e)
        {
            this.PizzaToppingsPicCheck();
        }

        private void cbxGreenPepper_CheckedChanged(object sender, EventArgs e)
        {
            this.PizzaToppingsPicCheck();
        }

                  

    }
}
