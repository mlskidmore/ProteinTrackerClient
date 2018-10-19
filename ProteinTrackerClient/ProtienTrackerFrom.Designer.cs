namespace ProteinTrackerClient
{
    partial class ProtienTrackerFrom
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
            this.cboSelectUser = new System.Windows.Forms.ComboBox();
            this.lblSelectUser = new System.Windows.Forms.Label();
            this.gbAddNewUser = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUserGoal = new System.Windows.Forms.Label();
            this.txtNewUserName = new System.Windows.Forms.TextBox();
            this.txtNewUserGoal = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddProtein = new System.Windows.Forms.Button();
            this.txtProteinAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblProteinTotal = new System.Windows.Forms.Label();
            this.lblProteinGoal = new System.Windows.Forms.Label();
            this.lblProteinTotalDisplay = new System.Windows.Forms.Label();
            this.lblProteinGoalDisplay = new System.Windows.Forms.Label();
            this.gbAddNewUser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSelectUser
            // 
            this.cboSelectUser.FormattingEnabled = true;
            this.cboSelectUser.Location = new System.Drawing.Point(12, 37);
            this.cboSelectUser.Name = "cboSelectUser";
            this.cboSelectUser.Size = new System.Drawing.Size(121, 21);
            this.cboSelectUser.TabIndex = 0;
            this.cboSelectUser.SelectedIndexChanged += new System.EventHandler(this.OnUserChanged);
            // 
            // lblSelectUser
            // 
            this.lblSelectUser.AutoSize = true;
            this.lblSelectUser.Location = new System.Drawing.Point(13, 13);
            this.lblSelectUser.Name = "lblSelectUser";
            this.lblSelectUser.Size = new System.Drawing.Size(71, 13);
            this.lblSelectUser.TabIndex = 1;
            this.lblSelectUser.Text = "Select a User";
            // 
            // gbAddNewUser
            // 
            this.gbAddNewUser.Controls.Add(this.btnAdd);
            this.gbAddNewUser.Controls.Add(this.txtNewUserGoal);
            this.gbAddNewUser.Controls.Add(this.txtNewUserName);
            this.gbAddNewUser.Controls.Add(this.lblUserGoal);
            this.gbAddNewUser.Controls.Add(this.lblName);
            this.gbAddNewUser.Location = new System.Drawing.Point(12, 74);
            this.gbAddNewUser.Name = "gbAddNewUser";
            this.gbAddNewUser.Size = new System.Drawing.Size(200, 114);
            this.gbAddNewUser.TabIndex = 2;
            this.gbAddNewUser.TabStop = false;
            this.gbAddNewUser.Text = "Add New User";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(7, 20);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblUserGoal
            // 
            this.lblUserGoal.AutoSize = true;
            this.lblUserGoal.Location = new System.Drawing.Point(7, 49);
            this.lblUserGoal.Name = "lblUserGoal";
            this.lblUserGoal.Size = new System.Drawing.Size(29, 13);
            this.lblUserGoal.TabIndex = 1;
            this.lblUserGoal.Text = "Goal";
            // 
            // txtNewUserName
            // 
            this.txtNewUserName.Location = new System.Drawing.Point(49, 20);
            this.txtNewUserName.Name = "txtNewUserName";
            this.txtNewUserName.Size = new System.Drawing.Size(100, 20);
            this.txtNewUserName.TabIndex = 2;
            // 
            // txtNewUserGoal
            // 
            this.txtNewUserGoal.Location = new System.Drawing.Point(49, 46);
            this.txtNewUserGoal.Name = "txtNewUserGoal";
            this.txtNewUserGoal.Size = new System.Drawing.Size(100, 20);
            this.txtNewUserGoal.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(49, 72);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.OnAddNewUser);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblProteinGoalDisplay);
            this.groupBox1.Controls.Add(this.lblProteinTotalDisplay);
            this.groupBox1.Controls.Add(this.lblProteinGoal);
            this.groupBox1.Controls.Add(this.lblProteinTotal);
            this.groupBox1.Controls.Add(this.btnAddProtein);
            this.groupBox1.Controls.Add(this.txtProteinAmount);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Location = new System.Drawing.Point(240, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 151);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Protein";
            // 
            // btnAddProtein
            // 
            this.btnAddProtein.Location = new System.Drawing.Point(49, 50);
            this.btnAddProtein.Name = "btnAddProtein";
            this.btnAddProtein.Size = new System.Drawing.Size(100, 23);
            this.btnAddProtein.TabIndex = 4;
            this.btnAddProtein.Text = "Add";
            this.btnAddProtein.UseVisualStyleBackColor = true;
            this.btnAddProtein.Click += new System.EventHandler(this.OnAddProtein);
            // 
            // txtProteinAmount
            // 
            this.txtProteinAmount.Location = new System.Drawing.Point(49, 20);
            this.txtProteinAmount.Name = "txtProteinAmount";
            this.txtProteinAmount.Size = new System.Drawing.Size(100, 20);
            this.txtProteinAmount.TabIndex = 2;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(7, 20);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount";
            // 
            // lblProteinTotal
            // 
            this.lblProteinTotal.AutoSize = true;
            this.lblProteinTotal.Location = new System.Drawing.Point(46, 86);
            this.lblProteinTotal.Name = "lblProteinTotal";
            this.lblProteinTotal.Size = new System.Drawing.Size(31, 13);
            this.lblProteinTotal.TabIndex = 5;
            this.lblProteinTotal.Text = "Total";
            // 
            // lblProteinGoal
            // 
            this.lblProteinGoal.AutoSize = true;
            this.lblProteinGoal.Location = new System.Drawing.Point(48, 109);
            this.lblProteinGoal.Name = "lblProteinGoal";
            this.lblProteinGoal.Size = new System.Drawing.Size(29, 13);
            this.lblProteinGoal.TabIndex = 6;
            this.lblProteinGoal.Text = "Goal";
            // 
            // lblProteinTotalDisplay
            // 
            this.lblProteinTotalDisplay.AutoSize = true;
            this.lblProteinTotalDisplay.Location = new System.Drawing.Point(118, 86);
            this.lblProteinTotalDisplay.Name = "lblProteinTotalDisplay";
            this.lblProteinTotalDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblProteinTotalDisplay.TabIndex = 7;
            // 
            // lblProteinGoalDisplay
            // 
            this.lblProteinGoalDisplay.AutoSize = true;
            this.lblProteinGoalDisplay.Location = new System.Drawing.Point(118, 109);
            this.lblProteinGoalDisplay.Name = "lblProteinGoalDisplay";
            this.lblProteinGoalDisplay.Size = new System.Drawing.Size(0, 13);
            this.lblProteinGoalDisplay.TabIndex = 8;
            // 
            // ProtienTrackerFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 275);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAddNewUser);
            this.Controls.Add(this.lblSelectUser);
            this.Controls.Add(this.cboSelectUser);
            this.Name = "ProtienTrackerFrom";
            this.Text = "Protein Tracker";
            this.Load += new System.EventHandler(this.OnLoad);
            this.gbAddNewUser.ResumeLayout(false);
            this.gbAddNewUser.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboSelectUser;
        private System.Windows.Forms.Label lblSelectUser;
        private System.Windows.Forms.GroupBox gbAddNewUser;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtNewUserGoal;
        private System.Windows.Forms.TextBox txtNewUserName;
        private System.Windows.Forms.Label lblUserGoal;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblProteinGoal;
        private System.Windows.Forms.Label lblProteinTotal;
        private System.Windows.Forms.Button btnAddProtein;
        private System.Windows.Forms.TextBox txtProteinAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblProteinGoalDisplay;
        private System.Windows.Forms.Label lblProteinTotalDisplay;
    }
}

