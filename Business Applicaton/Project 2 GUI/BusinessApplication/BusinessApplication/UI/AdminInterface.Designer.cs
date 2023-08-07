
namespace BusinessApplication.UI
{
    partial class AdminInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminInterface));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.radbtnSelling = new System.Windows.Forms.RadioButton();
            this.radbtnRepairing = new System.Windows.Forms.RadioButton();
            this.radbtnMoney = new System.Windows.Forms.RadioButton();
            this.radbtnManager = new System.Windows.Forms.RadioButton();
            this.btnLogout = new System.Windows.Forms.Button();
            this.piclogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(6, 77);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(118, 50);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "AUTOMOTIVE MANAGEMENT SYSTEM";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHeading
            // 
            this.txtHeading.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtHeading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHeading.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeading.ForeColor = System.Drawing.Color.Yellow;
            this.txtHeading.Location = new System.Drawing.Point(250, 21);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.ReadOnly = true;
            this.txtHeading.Size = new System.Drawing.Size(277, 41);
            this.txtHeading.TabIndex = 13;
            this.txtHeading.Text = "Admin Menu";
            this.txtHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radbtnSelling
            // 
            this.radbtnSelling.AutoSize = true;
            this.radbtnSelling.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnSelling.ForeColor = System.Drawing.Color.Yellow;
            this.radbtnSelling.Location = new System.Drawing.Point(260, 119);
            this.radbtnSelling.Name = "radbtnSelling";
            this.radbtnSelling.Size = new System.Drawing.Size(169, 27);
            this.radbtnSelling.TabIndex = 14;
            this.radbtnSelling.TabStop = true;
            this.radbtnSelling.Text = "Selling Products";
            this.radbtnSelling.UseVisualStyleBackColor = true;
            this.radbtnSelling.CheckedChanged += new System.EventHandler(this.radbtnSelling_CheckedChanged);
            // 
            // radbtnRepairing
            // 
            this.radbtnRepairing.AutoSize = true;
            this.radbtnRepairing.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnRepairing.ForeColor = System.Drawing.Color.Yellow;
            this.radbtnRepairing.Location = new System.Drawing.Point(260, 180);
            this.radbtnRepairing.Name = "radbtnRepairing";
            this.radbtnRepairing.Size = new System.Drawing.Size(192, 27);
            this.radbtnRepairing.TabIndex = 15;
            this.radbtnRepairing.TabStop = true;
            this.radbtnRepairing.Text = "Repairing Products";
            this.radbtnRepairing.UseVisualStyleBackColor = true;
            this.radbtnRepairing.CheckedChanged += new System.EventHandler(this.radbtnRepairing_CheckedChanged);
            // 
            // radbtnMoney
            // 
            this.radbtnMoney.AutoSize = true;
            this.radbtnMoney.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnMoney.ForeColor = System.Drawing.Color.Yellow;
            this.radbtnMoney.Location = new System.Drawing.Point(260, 245);
            this.radbtnMoney.Name = "radbtnMoney";
            this.radbtnMoney.Size = new System.Drawing.Size(148, 27);
            this.radbtnMoney.TabIndex = 16;
            this.radbtnMoney.TabStop = true;
            this.radbtnMoney.Text = "Check Record";
            this.radbtnMoney.UseVisualStyleBackColor = true;
            this.radbtnMoney.CheckedChanged += new System.EventHandler(this.radbtnMoney_CheckedChanged);
            // 
            // radbtnManager
            // 
            this.radbtnManager.AutoSize = true;
            this.radbtnManager.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radbtnManager.ForeColor = System.Drawing.Color.Yellow;
            this.radbtnManager.Location = new System.Drawing.Point(260, 320);
            this.radbtnManager.Name = "radbtnManager";
            this.radbtnManager.Size = new System.Drawing.Size(103, 27);
            this.radbtnManager.TabIndex = 17;
            this.radbtnManager.TabStop = true;
            this.radbtnManager.Text = "Manager";
            this.radbtnManager.UseVisualStyleBackColor = true;
            this.radbtnManager.CheckedChanged += new System.EventHandler(this.radbtnManager_CheckedChanged);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.Yellow;
            this.btnLogout.Location = new System.Drawing.Point(544, 377);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 44);
            this.btnLogout.TabIndex = 20;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // piclogo
            // 
            this.piclogo.Image = ((System.Drawing.Image)(resources.GetObject("piclogo.Image")));
            this.piclogo.Location = new System.Drawing.Point(28, 12);
            this.piclogo.Name = "piclogo";
            this.piclogo.Size = new System.Drawing.Size(62, 59);
            this.piclogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.piclogo.TabIndex = 22;
            this.piclogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // AdminInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.piclogo);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.radbtnManager);
            this.Controls.Add(this.radbtnMoney);
            this.Controls.Add(this.radbtnRepairing);
            this.Controls.Add(this.radbtnSelling);
            this.Controls.Add(this.txtHeading);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.MinimizeBox = false;
            this.Name = "AdminInterface";
            this.Text = "AdminInterface";
            this.Load += new System.EventHandler(this.AdminInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.piclogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.RadioButton radbtnSelling;
        private System.Windows.Forms.RadioButton radbtnRepairing;
        private System.Windows.Forms.RadioButton radbtnMoney;
        private System.Windows.Forms.RadioButton radbtnManager;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox piclogo;
    }
}