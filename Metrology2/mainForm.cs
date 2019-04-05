// Using SQLite https://www.youtube.com/watch?v=8YdjguVZID8
// ----**-----  https://www.youtube.com/watch?v=ayp3tHEkRc0

// Report https://www.youtube.com/watch?v=ek9FAXvTqGs
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Metrology2
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPk_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46) && number != 47 && number != 61)
            {
                e.Handled = true;
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
            InitValue();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Calc();
        }

        private void Calc()
        {
            double Pk, L, Ti, Tm, Gp, Tp, Var_A, Var_B, D1, k, k_Qnpp, Tmin, Tmax;
            int n, Qz, Qnpp;

            ClearResult();

            if (kToolStripMenuItem.Checked == true)
            {
                k_Qnpp = 0.7;
            }
            else
            {
                k_Qnpp = 1;
            }

            try
            {
                Pk = Convert.ToDouble(txtPk.Text);
                L = Convert.ToDouble(txtL.Text);
                n = Convert.ToInt16(txtn.Text);
                Qz = Convert.ToInt16(txtQz.Text);
                Ti = Convert.ToDouble(txtT1.Text);
                Qnpp = Convert.ToInt16(txtQnpp.Text);

                Qz = Qz * 1000;
                Qnpp = Qnpp * 1000;

                Tm = Ti / 60;

                Gp = 4 * Pk * L * n;

                Tp = 3600 * Gp / Qz;

                Var_A = Qz * Tm - 60 * Gp;
                
                //Var_B = 0.7 * Qnpp;
                Var_B = k_Qnpp * Qnpp;

                D1 = Var_A / (Var_B * Tm) * 100;

                k = Tp / Ti;

                Tmin = (6 * 60 * Gp) / (100 * Qz / 1000 - k_Qnpp * Qnpp / 1000);
                Tmax = (6 * 60 * Gp) / (k_Qnpp * Qnpp / 1000 + 100 * Qz / 1000);


                label1.Text = label1.Text + " " + Gp.ToString("0.###") + " кг";
                label4.Text = label4.Text + " " + Tp.ToString("0.###") + " c";

                label5.Text = label5.Text + " " + Tmax.ToString("0.###") + " c";
                label7.Text = label7.Text + " " + Tmin.ToString("0.###") + " c";

                label6.Text = label6.Text + " " + k.ToString("0.###");
                label3.Text = label3.Text + " " + D1.ToString("0.##") + " %";

                

                if (D1 > 1 || D1 < -1)
                {
                    lblError.Visible = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Проверьте введенные данные!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // MessageBox.Show(Pk.ToString("0.##"));
        }

        private void ClearResult()
        {
            lblError.Visible = false;

            label1.Text = "Gp =";
            label4.Text = "Tp =";
            label6.Text = "k =";
            label5.Text = "Tmin =";
            label7.Text = "Tmax =";

            label3.Text = "Расчетная погрешность D1 = ";
        }

        private void InitValue ()
        {
            txtPk.Text = "27,68";
            txtL.Text = "0,0";
            txtn.Text = "1";
            txtQz.Text = "160";
            txtT1.Text = "0,0";
            txtQnpp.Text = "160";
        }

        private void txtT1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Calc();
            }
        }

        private void kToolStripMenuItem_Click(object sender, EventArgs e)
        {
            kToolStripMenuItem.Checked = !kToolStripMenuItem.Checked;
        }
    }
}
