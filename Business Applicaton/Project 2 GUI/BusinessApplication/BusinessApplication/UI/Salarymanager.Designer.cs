
namespace BusinessApplication.UI
{
    partial class Salarymanager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salarymanager));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnPic = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tXTIDS = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lBLID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(25, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.Black;
            this.txtResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtResult.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.ForeColor = System.Drawing.Color.Yellow;
            this.txtResult.Location = new System.Drawing.Point(448, 330);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(318, 19);
            this.txtResult.TabIndex = 50;
            this.txtResult.Visible = false;
            // 
            // btnPic
            // 
            this.btnPic.BackColor = System.Drawing.Color.Black;
            this.btnPic.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPic.ForeColor = System.Drawing.Color.Yellow;
            this.btnPic.Location = new System.Drawing.Point(178, 376);
            this.btnPic.Name = "btnPic";
            this.btnPic.Size = new System.Drawing.Size(90, 39);
            this.btnPic.TabIndex = 49;
            this.btnPic.Text = "Back";
            this.btnPic.UseVisualStyleBackColor = false;
            this.btnPic.Click += new System.EventHandler(this.btnPic_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Black;
            this.btnAddProduct.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.Yellow;
            this.btnAddProduct.Location = new System.Drawing.Point(565, 376);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(90, 39);
            this.btnAddProduct.TabIndex = 48;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tXTIDS
            // 
            this.tXTIDS.BackColor = System.Drawing.Color.Black;
            this.tXTIDS.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tXTIDS.ForeColor = System.Drawing.Color.Yellow;
            this.tXTIDS.Location = new System.Drawing.Point(448, 262);
            this.tXTIDS.Name = "tXTIDS";
            this.tXTIDS.Size = new System.Drawing.Size(175, 29);
            this.tXTIDS.TabIndex = 47;
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.Color.Black;
            this.txtProductName.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.Yellow;
            this.txtProductName.Location = new System.Drawing.Point(448, 167);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(175, 29);
            this.txtProductName.TabIndex = 46;
            // 
            // lBLID
            // 
            this.lBLID.AutoSize = true;
            this.lBLID.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBLID.ForeColor = System.Drawing.Color.Yellow;
            this.lBLID.Location = new System.Drawing.Point(183, 271);
            this.lBLID.Name = "lBLID";
            this.lBLID.Size = new System.Drawing.Size(85, 20);
            this.lBLID.TabIndex = 45;
            this.lBLID.Text = "Enter ID :";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Yellow;
            this.lblName.Location = new System.Drawing.Point(174, 167);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(157, 20);
            this.lblName.TabIndex = 44;
            this.lblName.Text = "Enter work Hours :";
            // 
            // txtHeading
            // 
            this.txtHeading.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtHeading.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtHeading.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeading.ForeColor = System.Drawing.Color.Yellow;
            this.txtHeading.Location = new System.Drawing.Point(260, 44);
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.ReadOnly = true;
            this.txtHeading.Size = new System.Drawing.Size(277, 41);
            this.txtHeading.TabIndex = 43;
            this.txtHeading.Text = "Add Salary ";
            this.txtHeading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.HideSelection = false;
            this.textBox1.Location = new System.Drawing.Point(12, 91);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(118, 50);
            this.textBox1.TabIndex = 42;
            this.textBox1.Text = "AUTOMOTIVE MANAGEMENT SYSTEM";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Salarymanager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnPic);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.tXTIDS);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lBLID);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtHeading);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Yellow;
            this.MinimizeBox = false;
            this.Name = "Salarymanager";
            this.Text = "Salarymanager";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnPic;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox tXTIDS;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lBLID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.TextBox textBox1;
    }
}