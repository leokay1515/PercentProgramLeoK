using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PercentProgramLeoK
{
    public partial class frmPercentProgramLeoK : Form
    {
        public frmPercentProgramLeoK()
        {
            InitializeComponent();
        }

        private int ConvertToPercent(String level)
        {
            //variable
            int percent;

            switch (level)
            {
                case "4++":
                    percent = 98;
                    break;
                case "4+":
                    percent = 95;
                    break;
                case "4":
                    percent = 87;
                    break;
                case "4-":
                    percent = 83;
                    break;
                case "3+":
                    percent = 78;
                    break;
                case "3":
                    percent = 75;
                    break;
                case "3-":
                    percent = 72;
                    break;
                case "2+":
                    percent = 68;
                    break;
                case "2":
                    percent = 65;
                    break;
                case "2-":
                    percent = 62;
                    break;
                case "1+":
                    percent = 58;
                    break;
                case "1":
                    percent = 55;
                    break;
                case "1-":
                    percent = 52;
                    break;
                case "0+":
                    percent = 45;
                    break;
                case "0":
                    percent = 40;
                    break;
                case "0-":
                    percent = 35;
                    break;
                case "0--":
                    percent = 30;
                    break;
                case "0---":
                    percent = 20;
                    break;
                case "0----":
                    percent = 10;
                    break;
                default:
                    percent = -1;
                    break;
            }

            return percent;
        }

        private void btnGetPercent_Click(object sender, EventArgs e)
        {
            //variables
            String userLevel;
            int userPercent;

            //get the level from the user
            userLevel = txtLevel.Text;

            //call the function that tells the user their percent
            userPercent = ConvertToPercent(userLevel);

            //display the percent
            MessageBox.Show(userLevel + " is equal to " + userPercent + " percent.", "Level to Percent");
        }
    }
}
