
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
            this.create_butt.Location = new System.Drawing.Point(42, 72);
            this.create_butt.Name = "create_butt";
            this.create_butt.Size = new System.Drawing.Size(94, 29);
            this.create_butt.TabIndex = 2;
            this.create_butt.Text = "Create";
            this.create_butt.UseVisualStyleBackColor = true;
            this.create_butt.Click += new System.EventHandler(this.create_butt_Click);
            // 
            // constructor_class_table
            // 
            this.constructor_class_table.AutoSize = true;
            this.constructor_class_table.BackColor = System.Drawing.SystemColors.Control;
            this.constructor_class_table.ColumnCount = 4;
            this.constructor_class_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.constructor_class_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.constructor_class_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.constructor_class_table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.constructor_class_table.Location = new System.Drawing.Point(288, 38);
            this.constructor_class_table.Name = "constructor_class_table";
            this.constructor_class_table.RowCount = 1;
            this.constructor_class_table.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.constructor_class_table.Size = new System.Drawing.Size(150, 33);
            this.constructor_class_table.TabIndex = 6;
            // 
            // ISay_butt
            // 
            this.ISay_butt.Location = new System.Drawing.Point(42, 267);
            this.ISay_butt.Name = "ISay_butt";
            this.ISay_butt.Size = new System.Drawing.Size(94, 29);
            this.ISay_butt.TabIndex = 7;
            this.ISay_butt.Text = "ISay : Say()";
            this.ISay_butt.UseVisualStyleBackColor = true;
            this.ISay_butt.Visible = false;
            this.ISay_butt.Click += new System.EventHandler(this.ISay_butt_Click);
            // 
            // IErase_butt
            // 
            this.IErase_butt.Location = new System.Drawing.Point(142, 267);
            this.IErase_butt.Name = "IErase_butt";
            this.IErase_butt.Size = new System.Drawing.Size(139, 29);
            this.IErase_butt.TabIndex = 8;
            this.IErase_butt.Text = "IErase : EraseMy()";
            this.IErase_butt.UseVisualStyleBackColor = true;
            this.IErase_butt.Visible = false;
            this.IErase_butt.Click += new System.EventHandler(this.IErase_butt_Click);
            // 
            // IMove_butt
            // 
            this.IMove_butt.Location = new System.Drawing.Point(42, 302);
            this.IMove_butt.Name = "IMove_butt";
            this.IMove_butt.Size = new System.Drawing.Size(126, 29);
            this.IMove_butt.TabIndex = 9;
            this.IMove_butt.Text = "IMove : Move()";
            this.IMove_butt.UseVisualStyleBackColor = true;
            this.IMove_butt.Visible = false;
            this.IMove_butt.Click += new System.EventHandler(this.IMove_butt_Click);
            // 
            // IMath_butt
            // 
            this.IMath_butt.Location = new System.Drawing.Point(42, 337);
            this.IMath_butt.Name = "IMath_butt";
            this.IMath_butt.Size = new System.Drawing.Size(156, 29);
            this.IMath_butt.TabIndex = 10;
            this.IMath_butt.Text = "IMath : GetCosine()";
            this.IMath_butt.UseVisualStyleBackColor = true;
            this.IMath_butt.Visible = false;
            this.IMath_butt.Click += new System.EventHandler(this.IMath_butt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.IMath_butt);
            this.Controls.Add(this.IMove_butt);
            this.Controls.Add(this.IErase_butt);
            this.Controls.Add(this.ISay_butt);
            this.Controls.Add(this.constructor_class_table);
            this.Controls.Add(this.create_butt);
            this.Controls.Add(this.class_list);
            this.Controls.Add(this.choose_class_combo);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

