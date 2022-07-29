namespace SurplusTool
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_flex = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.cbox_type = new System.Windows.Forms.ComboBox();
            this.tbox_serial = new System.Windows.Forms.TextBox();
            this.lbl_serial = new System.Windows.Forms.Label();
            this.tbox_model = new System.Windows.Forms.TextBox();
            this.lbl_model = new System.Windows.Forms.Label();
            this.lbl_make = new System.Windows.Forms.Label();
            this.tbox_make = new System.Windows.Forms.TextBox();
            this.cbox_hdStatus = new System.Windows.Forms.ComboBox();
            this.tbox_specify = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_add);
            this.splitContainer1.Panel1.Controls.Add(this.btn_clear);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listBox1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 466;
            this.splitContainer1.TabIndex = 1;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(387, 411);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(63, 27);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.SystemColors.Control;
            this.btn_clear.Location = new System.Drawing.Point(11, 411);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(73, 27);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Clear Form";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_flex);
            this.panel1.Controls.Add(this.lbl_type);
            this.panel1.Controls.Add(this.cbox_type);
            this.panel1.Controls.Add(this.tbox_serial);
            this.panel1.Controls.Add(this.lbl_serial);
            this.panel1.Controls.Add(this.tbox_model);
            this.panel1.Controls.Add(this.lbl_model);
            this.panel1.Controls.Add(this.lbl_make);
            this.panel1.Controls.Add(this.tbox_make);
            this.panel1.Controls.Add(this.cbox_hdStatus);
            this.panel1.Controls.Add(this.tbox_specify);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 188);
            this.panel1.TabIndex = 0;
            // 
            // lbl_flex
            // 
            this.lbl_flex.AutoSize = true;
            this.lbl_flex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_flex.Location = new System.Drawing.Point(239, 136);
            this.lbl_flex.Name = "lbl_flex";
            this.lbl_flex.Size = new System.Drawing.Size(105, 15);
            this.lbl_flex.TabIndex = 8;
            this.lbl_flex.Text = "Hard Drive Status:";
            this.lbl_flex.Visible = false;
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_type.Location = new System.Drawing.Point(11, 136);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(112, 15);
            this.lbl_type.TabIndex = 7;
            this.lbl_type.Text = "Type of Equipment:";
            // 
            // cbox_type
            // 
            this.cbox_type.FormattingEnabled = true;
            this.cbox_type.Items.AddRange(new object[] {
            "Desktop computer",
            "Laptop",
            "Tablet",
            "Printer/Fax/Scanner/Copier",
            "Other (Please Specify)"});
            this.cbox_type.Location = new System.Drawing.Point(14, 154);
            this.cbox_type.Name = "cbox_type";
            this.cbox_type.Size = new System.Drawing.Size(208, 21);
            this.cbox_type.TabIndex = 6;
            this.cbox_type.SelectedIndexChanged += new System.EventHandler(this.cbox_type_SelectedIndexChanged);
            // 
            // tbox_serial
            // 
            this.tbox_serial.Location = new System.Drawing.Point(14, 92);
            this.tbox_serial.Name = "tbox_serial";
            this.tbox_serial.Size = new System.Drawing.Size(436, 20);
            this.tbox_serial.TabIndex = 5;
            // 
            // lbl_serial
            // 
            this.lbl_serial.AutoSize = true;
            this.lbl_serial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_serial.Location = new System.Drawing.Point(11, 74);
            this.lbl_serial.Name = "lbl_serial";
            this.lbl_serial.Size = new System.Drawing.Size(90, 15);
            this.lbl_serial.TabIndex = 4;
            this.lbl_serial.Text = "Serial Number:";
            // 
            // tbox_model
            // 
            this.tbox_model.Location = new System.Drawing.Point(242, 27);
            this.tbox_model.Name = "tbox_model";
            this.tbox_model.Size = new System.Drawing.Size(208, 20);
            this.tbox_model.TabIndex = 3;
            // 
            // lbl_model
            // 
            this.lbl_model.AutoSize = true;
            this.lbl_model.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_model.Location = new System.Drawing.Point(239, 9);
            this.lbl_model.Name = "lbl_model";
            this.lbl_model.Size = new System.Drawing.Size(45, 15);
            this.lbl_model.TabIndex = 2;
            this.lbl_model.Text = "Model:";
            // 
            // lbl_make
            // 
            this.lbl_make.AutoSize = true;
            this.lbl_make.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_make.Location = new System.Drawing.Point(11, 9);
            this.lbl_make.Name = "lbl_make";
            this.lbl_make.Size = new System.Drawing.Size(41, 15);
            this.lbl_make.TabIndex = 1;
            this.lbl_make.Text = "Make:";
            this.lbl_make.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbox_make
            // 
            this.tbox_make.Location = new System.Drawing.Point(14, 27);
            this.tbox_make.Name = "tbox_make";
            this.tbox_make.Size = new System.Drawing.Size(208, 20);
            this.tbox_make.TabIndex = 0;
            // 
            // cbox_hdStatus
            // 
            this.cbox_hdStatus.DropDownWidth = 300;
            this.cbox_hdStatus.FormattingEnabled = true;
            this.cbox_hdStatus.Items.AddRange(new object[] {
            "Destroyed / Will be destroyed (Recommended)",
            "Sanitized & Reinstalled (Interdepartmental Transfer Only)",
            "Removed & Held by Dept."});
            this.cbox_hdStatus.Location = new System.Drawing.Point(242, 153);
            this.cbox_hdStatus.Name = "cbox_hdStatus";
            this.cbox_hdStatus.Size = new System.Drawing.Size(208, 21);
            this.cbox_hdStatus.TabIndex = 10;
            this.cbox_hdStatus.Visible = false;
            // 
            // tbox_specify
            // 
            this.tbox_specify.Location = new System.Drawing.Point(242, 154);
            this.tbox_specify.Name = "tbox_specify";
            this.tbox_specify.Size = new System.Drawing.Size(208, 20);
            this.tbox_specify.TabIndex = 9;
            this.tbox_specify.Visible = false;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(0, 0);
            this.listBox1.Name = "listBox1";
            this.listBox1.ScrollAlwaysVisible = true;
            this.listBox1.Size = new System.Drawing.Size(330, 450);
            this.listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "OSU Surplus Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_make;
        private System.Windows.Forms.TextBox tbox_make;
        private System.Windows.Forms.TextBox tbox_serial;
        private System.Windows.Forms.Label lbl_serial;
        private System.Windows.Forms.TextBox tbox_model;
        private System.Windows.Forms.Label lbl_model;
        private System.Windows.Forms.Label lbl_type;
        private System.Windows.Forms.ComboBox cbox_type;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox tbox_specify;
        private System.Windows.Forms.Label lbl_flex;
        private System.Windows.Forms.ComboBox cbox_hdStatus;
    }
}

