
namespace _8
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.choose_class_combo = new System.Windows.Forms.ComboBox();
            this.class_list = new System.Windows.Forms.ListBox();
            this.create_butt = new System.Windows.Forms.Button();
            this.constructor_class_table = new System.Windows.Forms.TableLayoutPanel();
            this.ISay_butt = new System.Windows.Forms.Button();
            this.IErase_butt = new System.Windows.Forms.Button();
            this.IMove_butt = new System.Windows.Forms.Button();
            this.IMath_butt = new System.Windows.Forms.Button();
            this.Exception_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // choose_class_combo
            // 
            this.choose_class_combo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choose_class_combo.FormattingEnabled = true;
            this.choose_class_combo.Items.AddRange(new object[] {
            "Product",
            "Milk product",
            "Toy"});
            this.choose_class_combo.Location = new System.Drawing.Point(42, 38);
            this.choose_class_combo.Name = "choose_class_combo";
            this.choose_class_combo.Size = new System.Drawing.Size(151, 28);
            this.choose_class_combo.TabIndex = 0;
            this.choose_class_combo.SelectedIndexChanged += new System.EventHandler(this.choose_class_combo_SelectedIndexChanged);
            // 
            // class_list
            // 
            this.class_list.FormattingEnabled = true;
            this.class_list.ItemHeight = 20;
            this.class_list.Location = new System.Drawing.Point(42, 131);
            this.class_list.Name = "class_list";
            this.class_list.Size = new System.Drawing.Size(150, 104);
            this.class_list.TabIndex = 1;
            this.class_list.SelectedIndexChanged += new System.EventHandler(this.class_list_SelectedIndexChanged);
            // 
            // create_butt
            // 
            this.create_butt.AutoSize = true;
            this.create_butt.Location = new System.Drawing.Point(42, 72);
            this.create_butt.Name = "create_butt";
            this.create_butt.Size = new System.Drawing.Size(97, 30);
            this.create_butt.TabIndex = 2;
            this.create_butt.Text = "Create class";
            this.create_butt.UseVisualStyleBackColor = true;
            this.create_butt.Click += new System.EventHandler(this.create_butt_Click);
            // 
            // constructor_class_table
            // 
            this.constructor_class_table.AutoSize = true;
            this.constructor_class_table.BackColor = System.Drawing.SystemColors.Control;
            this.constructor_class_table.ColumnCount = 4;
            this.constructor_class_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.constructor_class_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.constructor_class_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.constructor_class_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.constructor_class_table.Location = new System.Drawing.Point(312, 38);
            this.constructor_class_table.Name = "constructor_class_table";
            this.constructor_class_table.RowCount = 1;
            this.constructor_class_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.constructor_class_table.Size = new System.Drawing.Size(200, 33);
            this.constructor_class_table.TabIndex = 6;
            // 
            // ISay_butt
            // 
            this.ISay_butt.AutoSize = true;
            this.ISay_butt.Enabled = false;
            this.ISay_butt.Location = new System.Drawing.Point(3, 3);
            this.ISay_butt.Name = "ISay_butt";
            this.ISay_butt.Size = new System.Drawing.Size(114, 30);
            this.ISay_butt.TabIndex = 7;
            this.ISay_butt.Text = "Print class info";
            this.ISay_butt.UseVisualStyleBackColor = true;
            this.ISay_butt.Click += new System.EventHandler(this.ISay_butt_Click);
            // 
            // IErase_butt
            // 
            this.IErase_butt.AutoSize = true;
            this.IErase_butt.Enabled = false;
            this.IErase_butt.Location = new System.Drawing.Point(123, 3);
            this.IErase_butt.Name = "IErase_butt";
            this.IErase_butt.Size = new System.Drawing.Size(97, 30);
            this.IErase_butt.TabIndex = 8;
            this.IErase_butt.Text = "Delete data";
            this.IErase_butt.UseVisualStyleBackColor = true;
            this.IErase_butt.Click += new System.EventHandler(this.IErase_butt_Click);
            // 
            // IMove_butt
            // 
            this.IMove_butt.AutoSize = true;
            this.IMove_butt.Enabled = false;
            this.IMove_butt.Location = new System.Drawing.Point(3, 38);
            this.IMove_butt.Name = "IMove_butt";
            this.IMove_butt.Size = new System.Drawing.Size(102, 30);
            this.IMove_butt.TabIndex = 9;
            this.IMove_butt.Text = "Move object";
            this.IMove_butt.UseVisualStyleBackColor = true;
            this.IMove_butt.Click += new System.EventHandler(this.IMove_butt_Click);
            // 
            // IMath_butt
            // 
            this.IMath_butt.AutoSize = true;
            this.IMath_butt.Enabled = false;
            this.IMath_butt.Location = new System.Drawing.Point(3, 73);
            this.IMath_butt.Name = "IMath_butt";
            this.IMath_butt.Size = new System.Drawing.Size(126, 30);
            this.IMath_butt.TabIndex = 10;
            this.IMath_butt.Text = "Calculate cosine";
            this.IMath_butt.UseVisualStyleBackColor = true;
            this.IMath_butt.Click += new System.EventHandler(this.IMath_butt_Click);
            // 
            // Exception_label
            // 
            this.Exception_label.AutoSize = true;
            this.Exception_label.Enabled = false;
            this.Exception_label.Location = new System.Drawing.Point(42, 385);
            this.Exception_label.Name = "Exception_label";
            this.Exception_label.Size = new System.Drawing.Size(0, 20);
            this.Exception_label.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Class selection";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(312, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Constructor properties";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Created classes list";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.IErase_butt);
            this.panel1.Controls.Add(this.ISay_butt);
            this.panel1.Controls.Add(this.IMove_butt);
            this.panel1.Controls.Add(this.IMath_butt);
            this.panel1.Location = new System.Drawing.Point(35, 280);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 148);
            this.panel1.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Class functions";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exception_label);
            this.Controls.Add(this.constructor_class_table);
            this.Controls.Add(this.create_butt);
            this.Controls.Add(this.class_list);
            this.Controls.Add(this.choose_class_combo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox choose_class_combo;
        private System.Windows.Forms.ListBox class_list;
        private System.Windows.Forms.Button create_butt;
        private System.Windows.Forms.TableLayoutPanel constructor_class_table;
        private System.Windows.Forms.Button ISay_butt;
        private System.Windows.Forms.Button IErase_butt;
        private System.Windows.Forms.Button IMove_butt;
        private System.Windows.Forms.Button IMath_butt;
        private System.Windows.Forms.Label Exception_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
    }
}

