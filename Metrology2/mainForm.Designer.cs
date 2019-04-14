namespace Metrology2
{
    partial class mainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblPk = new System.Windows.Forms.Label();
            this.txtPk = new System.Windows.Forms.TextBox();
            this.lblPkNote = new System.Windows.Forms.Label();
            this.lblLNote = new System.Windows.Forms.Label();
            this.txtL = new System.Windows.Forms.TextBox();
            this.lblL = new System.Windows.Forms.Label();
            this.lblnNote = new System.Windows.Forms.Label();
            this.txtn = new System.Windows.Forms.TextBox();
            this.lbln = new System.Windows.Forms.Label();
            this.lblQzNote = new System.Windows.Forms.Label();
            this.txtQz = new System.Windows.Forms.TextBox();
            this.lblQz = new System.Windows.Forms.Label();
            this.lblT1Note = new System.Windows.Forms.Label();
            this.txtT1 = new System.Windows.Forms.TextBox();
            this.lblT1 = new System.Windows.Forms.Label();
            this.lblQnppNote = new System.Windows.Forms.Label();
            this.txtQnpp = new System.Windows.Forms.TextBox();
            this.lblQnpp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_Diameter = new System.Windows.Forms.Label();
            this.txt_d = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Encoder = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_N = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.настройкиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(708, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kToolStripMenuItem});
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.настройкиToolStripMenuItem.Text = "Настройки";
            // 
            // kToolStripMenuItem
            // 
            this.kToolStripMenuItem.Checked = true;
            this.kToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kToolStripMenuItem.Name = "kToolStripMenuItem";
            this.kToolStripMenuItem.Size = new System.Drawing.Size(81, 22);
            this.kToolStripMenuItem.Text = "K";
            this.kToolStripMenuItem.Click += new System.EventHandler(this.kToolStripMenuItem_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 348);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(82, 26);
            this.btnCalc.TabIndex = 20;
            this.btnCalc.Text = "Расчет";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblPk
            // 
            this.lblPk.AutoSize = true;
            this.lblPk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPk.Location = new System.Drawing.Point(27, 33);
            this.lblPk.Name = "lblPk";
            this.lblPk.Size = new System.Drawing.Size(23, 15);
            this.lblPk.TabIndex = 2;
            this.lblPk.Text = "Pk";
            // 
            // txtPk
            // 
            this.txtPk.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtPk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPk.Location = new System.Drawing.Point(56, 30);
            this.txtPk.Name = "txtPk";
            this.txtPk.Size = new System.Drawing.Size(75, 21);
            this.txtPk.TabIndex = 1;
            this.txtPk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtT1_KeyDown);
            this.txtPk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPk_KeyPress);
            // 
            // lblPkNote
            // 
            this.lblPkNote.AutoSize = true;
            this.lblPkNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPkNote.Location = new System.Drawing.Point(137, 33);
            this.lblPkNote.Name = "lblPkNote";
            this.lblPkNote.Size = new System.Drawing.Size(88, 15);
            this.lblPkNote.TabIndex = 4;
            this.lblPkNote.Text = "масса гирь, кг";
            // 
            // lblLNote
            // 
            this.lblLNote.AutoSize = true;
            this.lblLNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLNote.Location = new System.Drawing.Point(137, 60);
            this.lblLNote.Name = "lblLNote";
            this.lblLNote.Size = new System.Drawing.Size(104, 15);
            this.lblLNote.TabIndex = 7;
            this.lblLNote.Text = "длинна ленты, м";
            // 
            // txtL
            // 
            this.txtL.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtL.Location = new System.Drawing.Point(56, 57);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(75, 21);
            this.txtL.TabIndex = 2;
            this.txtL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtT1_KeyDown);
            this.txtL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPk_KeyPress);
            // 
            // lblL
            // 
            this.lblL.AutoSize = true;
            this.lblL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblL.Location = new System.Drawing.Point(35, 60);
            this.lblL.Name = "lblL";
            this.lblL.Size = new System.Drawing.Size(15, 15);
            this.lblL.TabIndex = 5;
            this.lblL.Text = "L";
            // 
            // lblnNote
            // 
            this.lblnNote.AutoSize = true;
            this.lblnNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblnNote.Location = new System.Drawing.Point(137, 87);
            this.lblnNote.Name = "lblnNote";
            this.lblnNote.Size = new System.Drawing.Size(99, 15);
            this.lblnNote.TabIndex = 10;
            this.lblnNote.Text = "число оборотов";
            // 
            // txtn
            // 
            this.txtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtn.Location = new System.Drawing.Point(56, 84);
            this.txtn.Name = "txtn";
            this.txtn.Size = new System.Drawing.Size(75, 21);
            this.txtn.TabIndex = 3;
            this.txtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtT1_KeyDown);
            this.txtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPk_KeyPress);
            // 
            // lbln
            // 
            this.lbln.AutoSize = true;
            this.lbln.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbln.Location = new System.Drawing.Point(35, 87);
            this.lbln.Name = "lbln";
            this.lbln.Size = new System.Drawing.Size(15, 15);
            this.lbln.TabIndex = 8;
            this.lbln.Text = "n";
            // 
            // lblQzNote
            // 
            this.lblQzNote.AutoSize = true;
            this.lblQzNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQzNote.Location = new System.Drawing.Point(149, 233);
            this.lblQzNote.Name = "lblQzNote";
            this.lblQzNote.Size = new System.Drawing.Size(68, 15);
            this.lblQzNote.TabIndex = 13;
            this.lblQzNote.Text = "задание, т";
            // 
            // txtQz
            // 
            this.txtQz.BackColor = System.Drawing.SystemColors.Info;
            this.txtQz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQz.Location = new System.Drawing.Point(68, 230);
            this.txtQz.Name = "txtQz";
            this.txtQz.Size = new System.Drawing.Size(75, 21);
            this.txtQz.TabIndex = 5;
            this.txtQz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQz.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtT1_KeyDown);
            this.txtQz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPk_KeyPress);
            // 
            // lblQz
            // 
            this.lblQz.AutoSize = true;
            this.lblQz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQz.Location = new System.Drawing.Point(38, 233);
            this.lblQz.Name = "lblQz";
            this.lblQz.Size = new System.Drawing.Size(24, 15);
            this.lblQz.TabIndex = 11;
            this.lblQz.Text = "Qз";
            // 
            // lblT1Note
            // 
            this.lblT1Note.AutoSize = true;
            this.lblT1Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblT1Note.Location = new System.Drawing.Point(149, 260);
            this.lblT1Note.Name = "lblT1Note";
            this.lblT1Note.Size = new System.Drawing.Size(108, 15);
            this.lblT1Note.TabIndex = 16;
            this.lblT1Note.Text = "время оборота, с";
            // 
            // txtT1
            // 
            this.txtT1.BackColor = System.Drawing.SystemColors.Info;
            this.txtT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtT1.Location = new System.Drawing.Point(68, 257);
            this.txtT1.Name = "txtT1";
            this.txtT1.Size = new System.Drawing.Size(75, 21);
            this.txtT1.TabIndex = 6;
            this.txtT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtT1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtT1_KeyDown);
            this.txtT1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPk_KeyPress);
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblT1.Location = new System.Drawing.Point(39, 260);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(19, 15);
            this.lblT1.TabIndex = 14;
            this.lblT1.Text = "Ti";
            // 
            // lblQnppNote
            // 
            this.lblQnppNote.AutoSize = true;
            this.lblQnppNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQnppNote.Location = new System.Drawing.Point(137, 117);
            this.lblQnppNote.Name = "lblQnppNote";
            this.lblQnppNote.Size = new System.Drawing.Size(97, 15);
            this.lblQnppNote.TabIndex = 19;
            this.lblQnppNote.Text = "max нагрузка, т";
            // 
            // txtQnpp
            // 
            this.txtQnpp.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txtQnpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtQnpp.Location = new System.Drawing.Point(56, 114);
            this.txtQnpp.Name = "txtQnpp";
            this.txtQnpp.Size = new System.Drawing.Size(75, 21);
            this.txtQnpp.TabIndex = 4;
            this.txtQnpp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQnpp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtT1_KeyDown);
            this.txtQnpp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPk_KeyPress);
            // 
            // lblQnpp
            // 
            this.lblQnpp.AutoSize = true;
            this.lblQnpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblQnpp.Location = new System.Drawing.Point(9, 117);
            this.lblQnpp.Name = "lblQnpp";
            this.lblQnpp.Size = new System.Drawing.Size(41, 15);
            this.lblQnpp.TabIndex = 17;
            this.lblQnpp.Text = "Qнпп";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Fuchsia;
            this.label3.Location = new System.Drawing.Point(149, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 17);
            this.label3.TabIndex = 20;
            this.label3.Text = "Расчетная погрешность D1 = ";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(127, 312);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(423, 25);
            this.lblError.TabIndex = 21;
            this.lblError.Text = "ПОГРЕШНОСТЬ БОЛЬШЕ ДОПУСТИМОЙ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(481, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Допустимая погрешность = +/- 1,0%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(570, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Gp =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(572, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tp =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(581, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 15);
            this.label6.TabIndex = 26;
            this.label6.Text = "k =";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Location = new System.Drawing.Point(556, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tmin =";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(553, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Tmax =";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusDate,
            this.toolStripStatusTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 387);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(708, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(628, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusDate
            // 
            this.toolStripStatusDate.Name = "toolStripStatusDate";
            this.toolStripStatusDate.Size = new System.Drawing.Size(31, 17);
            this.toolStripStatusDate.Text = "Date";
            // 
            // toolStripStatusTime
            // 
            this.toolStripStatusTime.Name = "toolStripStatusTime";
            this.toolStripStatusTime.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusTime.Text = "Time";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txt_Encoder);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txt_Diameter);
            this.groupBox1.Controls.Add(this.txt_d);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblQnppNote);
            this.groupBox1.Controls.Add(this.lblPk);
            this.groupBox1.Controls.Add(this.txtPk);
            this.groupBox1.Controls.Add(this.lblPkNote);
            this.groupBox1.Controls.Add(this.lblL);
            this.groupBox1.Controls.Add(this.txtL);
            this.groupBox1.Controls.Add(this.lblLNote);
            this.groupBox1.Controls.Add(this.lbln);
            this.groupBox1.Controls.Add(this.txtn);
            this.groupBox1.Controls.Add(this.lblnNote);
            this.groupBox1.Controls.Add(this.lblQnpp);
            this.groupBox1.Controls.Add(this.txtQnpp);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 158);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка параметров";
            // 
            // txt_Diameter
            // 
            this.txt_Diameter.AutoSize = true;
            this.txt_Diameter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Diameter.Location = new System.Drawing.Point(276, 33);
            this.txt_Diameter.Name = "txt_Diameter";
            this.txt_Diameter.Size = new System.Drawing.Size(15, 15);
            this.txt_Diameter.TabIndex = 21;
            this.txt_Diameter.Text = "d";
            // 
            // txt_d
            // 
            this.txt_d.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_d.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_d.Location = new System.Drawing.Point(295, 30);
            this.txt_d.Name = "txt_d";
            this.txt_d.Size = new System.Drawing.Size(75, 21);
            this.txt_d.TabIndex = 20;
            this.txt_d.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_d.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtT1_KeyDown);
            this.txt_d.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPk_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(376, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "диаметр вала, м";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(261, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Npr";
            // 
            // txt_Encoder
            // 
            this.txt_Encoder.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.txt_Encoder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_Encoder.Location = new System.Drawing.Point(295, 60);
            this.txt_Encoder.Name = "txt_Encoder";
            this.txt_Encoder.Size = new System.Drawing.Size(75, 21);
            this.txt_Encoder.TabIndex = 23;
            this.txt_Encoder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Encoder.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtT1_KeyDown);
            this.txt_Encoder.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPk_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(376, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 15);
            this.label10.TabIndex = 25;
            this.label10.Text = "разрешение энкодера";
            // 
            // lbl_N
            // 
            this.lbl_N.AutoSize = true;
            this.lbl_N.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_N.Location = new System.Drawing.Point(581, 230);
            this.lbl_N.Name = "lbl_N";
            this.lbl_N.Size = new System.Drawing.Size(29, 15);
            this.lbl_N.TabIndex = 31;
            this.lbl_N.Text = "N =";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 409);
            this.Controls.Add(this.lbl_N);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblT1Note);
            this.Controls.Add(this.txtT1);
            this.Controls.Add(this.lblT1);
            this.Controls.Add(this.lblQzNote);
            this.Controls.Add(this.txtQz);
            this.Controls.Add(this.lblQz);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Метрология 2";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label lblPk;
        private System.Windows.Forms.TextBox txtPk;
        private System.Windows.Forms.Label lblPkNote;
        private System.Windows.Forms.Label lblLNote;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.Label lblL;
        private System.Windows.Forms.Label lblnNote;
        private System.Windows.Forms.TextBox txtn;
        private System.Windows.Forms.Label lbln;
        private System.Windows.Forms.Label lblQzNote;
        private System.Windows.Forms.TextBox txtQz;
        private System.Windows.Forms.Label lblQz;
        private System.Windows.Forms.Label lblT1Note;
        private System.Windows.Forms.TextBox txtT1;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.Label lblQnppNote;
        private System.Windows.Forms.TextBox txtQnpp;
        private System.Windows.Forms.Label lblQnpp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusDate;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label txt_Diameter;
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Encoder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_N;
    }
}

