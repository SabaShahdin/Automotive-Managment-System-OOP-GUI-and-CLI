
namespace BusinessApplication.UI
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.chkLogin = new System.Windows.Forms.CheckBox();
            this.chkExit = new System.Windows.Forms.CheckBox();
            this.txtMain = new System.Windows.Forms.TextBox();
            this.pictureMain = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).BeginInit();
            this.SuspendLayout();
            // 
            // chkLogin
            // 
            this.chkLogin.AutoSize = true;
            this.chkLogin.BackColor = System.Drawing.Color.Black;
            this.chkLogin.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLogin.ForeColor = System.Drawing.Color.Yellow;
            this.chkLogin.Location = new System.Drawing.Point(165, 286);
            this.chkLogin.Name = "chkLogin";
            this.chkLogin.Size = new System.Drawing.Size(88, 29);
            this.chkLogin.TabIndex = 1;
            this.chkLogin.Text = "Login";
            this.chkLogin.UseVisualStyleBackColor = false;
            this.chkLogin.CheckedChanged += new System.EventHandler(this.chkLogin_CheckedChanged);
            // 
            // chkExit
            // 
            this.chkExit.AutoSize = true;
            this.chkExit.BackColor = System.Drawing.Color.Black;
            this.chkExit.Font = new System.Drawing.Font("Mongolian Baiti", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkExit.ForeColor = System.Drawing.Color.Yellow;
            this.chkExit.Location = new System.Drawing.Point(548, 297);
            this.chkExit.Name = "chkExit";
            this.chkExit.Size = new System.Drawing.Size(71, 29);
            this.chkExit.TabIndex = 2;
            this.chkExit.Text = "Exit";
            this.chkExit.UseVisualStyleBackColor = false;
            this.chkExit.CheckedChanged += new System.EventHandler(this.chkExit_CheckedChanged);
            // 
            // txtMain
            // 
            this.txtMain.BackColor = System.Drawing.Color.Black;
            this.txtMain.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMain.Font = new System.Drawing.Font("Mongolian Baiti", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMain.ForeColor = System.Drawing.Color.Yellow;
            this.txtMain.Location = new System.Drawing.Point(78, 170);
            this.txtMain.Name = "txtMain";
            this.txtMain.Size = new System.Drawing.Size(674, 43);
            this.txtMain.TabIndex = 4;
            this.txtMain.Text = "AUTOMOTIVE MANAGMENT SYSTEM";
            // 
            // pictureMain
            // 
            this.pictureMain.Image = ((System.Drawing.Image)(resources.GetObject("pictureMain.Image")));
            this.pictureMain.Location = new System.Drawing.Point(30, 69);
            this.pictureMain.Name = "pictureMain";
            this.pictureMain.Size = new System.Drawing.Size(104, 95);
            this.pictureMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureMain.TabIndex = 5;
            this.pictureMain.TabStop = false;
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::BusinessApplication.Properties.Resources._1303513f_8ec1_48a6_a93a_0d6e4cd8bb1b;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureMain);
            this.Controls.Add(this.txtMain);
            this.Controls.Add(this.chkExit);
            this.Controls.Add(this.chkLogin);
            this.MaximizeBox = false;
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkLogin;
        private System.Windows.Forms.CheckBox chkExit;
        private System.Windows.Forms.TextBox txtMain;
        private System.Windows.Forms.PictureBox pictureMain;
    }
}