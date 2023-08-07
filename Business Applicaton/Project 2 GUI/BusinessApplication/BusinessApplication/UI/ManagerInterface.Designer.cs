
namespace BusinessApplication.UI
{
    partial class ManagerInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagerInterface));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.radProducts = new System.Windows.Forms.RadioButton();
            this.radEmployee = new System.Windows.Forms.RadioButton();
            this.btnLogout = new System.Windows.Forms.Button();
            this.radMoney = new System.Windows.Forms.RadioButton();
            this.radSalary = new System.Windows.Forms.RadioButton();
            this.piclogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(12, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(118, 50);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "AUTOMOTIVE MANAGEMENT SYSTEM";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHeading
            // 
            this.txtHeading.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtHeading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHeading.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeading.ForeColor = System.Drawing.Color.Yellow;
            this.txtHeading.Location = new System.Drawing.Point(261, 30);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.ReadOnly = true;
            this.txtHeading.Size = new System.Drawing.Size(277, 41);
            this.txtHeading.TabIndex = 25;
            this.txtHeading.Text = "Manager Menu";
            this.txtHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radProducts
            // 
            this.radProducts.AutoSize = true;
            this.radProducts.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radProducts.Location = new System.Drawing.Point(261, 139);
            this.radProducts.Name = "radProducts";
            this.radProducts.Size = new System.Drawing.Size(158, 27);
            this.radProducts.TabIndex = 27;
            this.radProducts.TabStop = true;
            this.radProducts.Text = "View Products ";
            this.radProducts.UseVisualStyleBackColor = true;
            this.radProducts.CheckedChanged += new System.EventHandler(this.radProducts_CheckedChanged);
            // 
            // radEmployee
            // 
            this.radEmployee.AutoSize = true;
            this.radEmployee.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radEmployee.Location = new System.Drawing.Point(261, 220);
            this.radEmployee.Name = "radEmployee";
            this.radEmployee.Size = new System.Drawing.Size(119, 27);
            this.radEmployee.TabIndex = 28;
            this.radEmployee.TabStop = true;
            this.radEmployee.Text = "Employee ";
            this.radEmployee.UseVisualStyleBackColor = true;
            this.radEmployee.CheckedChanged += new System.EventHandler(this.radEmployee_CheckedChanged);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Yellow;
            this.btnLogout.Location = new System.Drawing.Point(592, 375);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 44);
            this.btnLogout.TabIndex = 29;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // radMoney
            // 
            this.radMoney.AutoSize = true;
            this.radMoney.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMoney.Location = new System.Drawing.Point(261, 298);
            this.radMoney.Name = "radMoney";
            this.radMoney.Size = new System.Drawing.Size(94, 27);
            this.radMoney.TabIndex = 30;
            this.radMoney.TabStop = true;
            this.radMoney.Text = "Money ";
            this.radMoney.UseVisualStyleBackColor = true;
            this.radMoney.CheckedChanged += new System.EventHandler(this.radMoney_CheckedChanged);
            // 
            // radSalary
            // 
            this.radSalary.AutoSize = true;
            this.radSalary.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radSalary.Location = new System.Drawing.Point(261, 382);
            this.radSalary.Name = "radSalary";
            this.radSalary.Size = new System.Drawing.Size(82, 27);
            this.radSalary.TabIndex = 31;
            this.radSalary.TabStop = true;
            this.radSalary.Text = "Salary";
            this.radSalary.UseVisualStyleBackColor = true;
            this.radSalary.CheckedChanged += new System.EventHandler(this.radSalary_CheckedChanged);
            // 
            // piclogo
            // 
            this.piclogo.Image = ((System.Drawing.Image)(resources.GetObject("piclogo.Image")));
            this.piclogo.Location = new System.Drawing.Point(27, 12);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(62, 59);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 23;
            this.piclogo.TabStop = false;
            // 
            // ManagerInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radSalary);
            this.Controls.Add(this.radMoney);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.radEmployee);
            this.Controls.Add(this.radProducts);
            this.Controls.Add(this.txtHeading);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.piclogo);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.MaximizeBox = false;
            this.Name = "ManagerInterface";
            this.Text = "ManagerInterface";
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox piclogo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.RadioButton radProducts;
        private System.Windows.Forms.RadioButton radEmployee;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.RadioButton radMoney;
        private System.Windows.Forms.RadioButton radSalary;
    }
}