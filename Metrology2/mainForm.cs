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
        public const double PI = 3.14159;

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
            toolStripStatusDate.Text = DateTime.Now.ToLongDateString();
            toolStripStatusTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblError.Visible = false;
            InitValue();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Calc();
        }

        private void Calc()
        {
            double Pk, L, Ti, Tm, Gp, Tp, Var_A, Var_B, D1, k, k_Qnpp, Tmin, Tmax, N, d, Qz;
            int n, Qnpp, Npr;

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
                Pk = Convert.ToDouble(txtPk.Text);              // Масса контрольного груза
                L = Convert.ToDouble(txtL.Text);
                n = Convert.ToInt16(txtn.Text);
                Qz = Convert.ToDouble(txtQz.Text);
                Ti = Convert.ToDouble(txtT1.Text);              // Измеренное время
                Qnpp = Convert.ToInt16(txtQnpp.Text);
                Npr = Convert.ToInt16(txt_Encoder.Text);        // Частота энкодера
                d = Convert.ToDouble(txt_d.Text);               // Диаметр барабана

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

                N = ((L / Ti) * Npr) / (PI * d);

                label1.Text = label1.Text + " " + Gp.ToString("0.###") + " кг";
                label4.Text = label4.Text + " " + Tp.ToString("0.###") + " c";

                label5.Text = label5.Text + " " + Tmax.ToString("0.###") + " c";
                label7.Text = label7.Text + " " + Tmin.ToString("0.###") + " c";

                label6.Text = label6.Text + " " + k.ToString("0.###");
                label3.Text = label3.Text + " " + D1.ToString("0.##") + " %";
                lbl_N.Text = lbl_N.Text + " " + N.ToString("0") + " имп.";

                

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
            lbl_N.Text = "N =";
            label5.Text = "Tmin =";
            label7.Text = "Tmax =";

            label3.Text = "Расчетная погрешность D1 = ";
        }

        private void InitValue ()
        {
            txtPk.Text = "27,68";
            txtL.Text = "0,0";
            txtn.Text = "1";
            txt_d.Text = "0,25";
            txt_Encoder.Text = "1800";
            txtQz.Text = "160,00";
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
            Calc();
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            toolStripStatusTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
