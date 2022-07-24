﻿namespace GILoader
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.btnLaunch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxGenshin = new System.Windows.Forms.ComboBox();
            this.lnchGC = new System.Windows.Forms.CheckBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nochange = new System.Windows.Forms.RadioButton();
            this.mitmcheck = new System.Windows.Forms.RadioButton();
            this.fdlcheck = new System.Windows.Forms.RadioButton();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.btnAddGrass = new System.Windows.Forms.Button();
            this.UpdaterTimer = new System.Windows.Forms.Timer(this.components);
            this.ConsoleOutputRichBox = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnOpenServer = new System.Windows.Forms.Button();
            this.btnopenGenshin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLaunch
            // 
            this.btnLaunch.Location = new System.Drawing.Point(12, 261);
            this.btnLaunch.Name = "btnLaunch";
            this.btnLaunch.Size = new System.Drawing.Size(318, 23);
            this.btnLaunch.TabIndex = 0;
            this.btnLaunch.Text = "Launch";
            this.btnLaunch.UseVisualStyleBackColor = true;
            this.btnLaunch.Click += new System.EventHandler(this.btnLaunch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 235);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(205, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "localhost";
            // 
            // comboBoxGenshin
            // 
            this.comboBoxGenshin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenshin.FormattingEnabled = true;
            this.comboBoxGenshin.Location = new System.Drawing.Point(12, 208);
            this.comboBoxGenshin.Name = "comboBoxGenshin";
            this.comboBoxGenshin.Size = new System.Drawing.Size(205, 21);
            this.comboBoxGenshin.TabIndex = 3;
            // 
            // lnchGC
            // 
            this.lnchGC.AutoSize = true;
            this.lnchGC.Location = new System.Drawing.Point(13, 183);
            this.lnchGC.Name = "lnchGC";
            this.lnchGC.Size = new System.Drawing.Size(102, 17);
            this.lnchGC.TabIndex = 4;
            this.lnchGC.Text = "Launch with GC";
            this.lnchGC.UseVisualStyleBackColor = true;
            this.lnchGC.CheckedChanged += new System.EventHandler(this.lnchGC_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(114, 181);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(102, 21);
            this.comboBox2.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nochange);
            this.groupBox1.Controls.Add(this.mitmcheck);
            this.groupBox1.Controls.Add(this.fdlcheck);
            this.groupBox1.Location = new System.Drawing.Point(13, 290);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proxy Method";
            // 
            // nochange
            // 
            this.nochange.AutoSize = true;
            this.nochange.Location = new System.Drawing.Point(12, 68);
            this.nochange.Name = "nochange";
            this.nochange.Size = new System.Drawing.Size(68, 17);
            this.nochange.TabIndex = 2;
            this.nochange.Text = "No Proxy";
            this.nochange.UseVisualStyleBackColor = true;
            // 
            // mitmcheck
            // 
            this.mitmcheck.AutoSize = true;
            this.mitmcheck.Location = new System.Drawing.Point(12, 45);
            this.mitmcheck.Name = "mitmcheck";
            this.mitmcheck.Size = new System.Drawing.Size(73, 17);
            this.mitmcheck.TabIndex = 1;
            this.mitmcheck.Text = "MitmProxy";
            this.mitmcheck.UseVisualStyleBackColor = true;
            // 
            // fdlcheck
            // 
            this.fdlcheck.AutoSize = true;
            this.fdlcheck.Checked = true;
            this.fdlcheck.Location = new System.Drawing.Point(12, 22);
            this.fdlcheck.Name = "fdlcheck";
            this.fdlcheck.Size = new System.Drawing.Size(95, 17);
            this.fdlcheck.TabIndex = 0;
            this.fdlcheck.TabStop = true;
            this.fdlcheck.Text = "Fiddler Method";
            this.fdlcheck.UseVisualStyleBackColor = true;
            // 
            // btnAddClient
            // 
            this.btnAddClient.Location = new System.Drawing.Point(246, 209);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(21, 21);
            this.btnAddClient.TabIndex = 8;
            this.btnAddClient.Text = "+";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // btnAddGrass
            // 
            this.btnAddGrass.Location = new System.Drawing.Point(246, 181);
            this.btnAddGrass.Name = "btnAddGrass";
            this.btnAddGrass.Size = new System.Drawing.Size(21, 21);
            this.btnAddGrass.TabIndex = 9;
            this.btnAddGrass.Text = "+";
            this.btnAddGrass.UseVisualStyleBackColor = true;
            this.btnAddGrass.Click += new System.EventHandler(this.btnAddGrass_Click);
            // 
            // UpdaterTimer
            // 
            this.UpdaterTimer.Enabled = true;
            this.UpdaterTimer.Tick += new System.EventHandler(this.UpdaterTimer_Tick);
            // 
            // ConsoleOutputRichBox
            // 
            this.ConsoleOutputRichBox.BackColor = System.Drawing.SystemColors.InfoText;
            this.ConsoleOutputRichBox.ForeColor = System.Drawing.SystemColors.Info;
            this.ConsoleOutputRichBox.Location = new System.Drawing.Point(13, 16);
            this.ConsoleOutputRichBox.Name = "ConsoleOutputRichBox";
            this.ConsoleOutputRichBox.ReadOnly = true;
            this.ConsoleOutputRichBox.Size = new System.Drawing.Size(317, 159);
            this.ConsoleOutputRichBox.TabIndex = 10;
            this.ConsoleOutputRichBox.Text = "";
            this.ConsoleOutputRichBox.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 49);
            this.button1.TabIndex = 11;
            this.button1.Text = "KillGrass";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.GrassStopProc);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(223, 235);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.Text = "443";
            // 
            // btnOpenServer
            // 
            this.btnOpenServer.Location = new System.Drawing.Point(223, 181);
            this.btnOpenServer.Name = "btnOpenServer";
            this.btnOpenServer.Size = new System.Drawing.Size(21, 21);
            this.btnOpenServer.TabIndex = 14;
            this.btnOpenServer.Text = "Folder";
            this.btnOpenServer.UseVisualStyleBackColor = true;
            this.btnOpenServer.Click += new System.EventHandler(this.btnOpenServer_Click);
            // 
            // btnopenGenshin
            // 
            this.btnopenGenshin.Location = new System.Drawing.Point(223, 209);
            this.btnopenGenshin.Name = "btnopenGenshin";
            this.btnopenGenshin.Size = new System.Drawing.Size(21, 21);
            this.btnopenGenshin.TabIndex = 13;
            this.btnopenGenshin.Text = "Folder";
            this.btnopenGenshin.UseVisualStyleBackColor = true;
            this.btnopenGenshin.Click += new System.EventHandler(this.btnopenGenshin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(344, 404);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnOpenServer);
            this.Controls.Add(this.btnopenGenshin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ConsoleOutputRichBox);
            this.Controls.Add(this.btnAddGrass);
            this.Controls.Add(this.btnAddClient);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lnchGC);
            this.Controls.Add(this.comboBoxGenshin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLaunch);
            this.MaximumSize = new System.Drawing.Size(360, 443);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 443);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "GILauncher";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLaunch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBoxGenshin;
        private System.Windows.Forms.CheckBox lnchGC;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnAddGrass;
        private System.Windows.Forms.RadioButton nochange;
        private System.Windows.Forms.RadioButton mitmcheck;
        private System.Windows.Forms.RadioButton fdlcheck;
        private System.Windows.Forms.Timer UpdaterTimer;
        private System.Windows.Forms.RichTextBox ConsoleOutputRichBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnOpenServer;
        private System.Windows.Forms.Button btnopenGenshin;
    }
}

