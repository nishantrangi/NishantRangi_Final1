namespace NishantRangi_Final1
{
    partial class AddOrUpdateUserForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FisrtNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Middle Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Name:";
            // 
            // FisrtNameTextBox
            // 
            this.FisrtNameTextBox.Location = new System.Drawing.Point(168, 50);
            this.FisrtNameTextBox.Name = "FisrtNameTextBox";
            this.FisrtNameTextBox.Size = new System.Drawing.Size(260, 22);
            this.FisrtNameTextBox.TabIndex = 4;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(167, 106);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(260, 22);
            this.LastNameTextBox.TabIndex = 5;
            // 
            // MiddleNameTextBox
            // 
            this.MiddleNameTextBox.Location = new System.Drawing.Point(167, 167);
            this.MiddleNameTextBox.Name = "MiddleNameTextBox";
            this.MiddleNameTextBox.Size = new System.Drawing.Size(260, 22);
            this.MiddleNameTextBox.TabIndex = 6;
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(167, 231);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(260, 22);
            this.UserNameTextBox.TabIndex = 7;
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(352, 286);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(168, 286);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AddOrUpdateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CancelButton;
            this.ClientSize = new System.Drawing.Size(532, 353);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.UserNameTextBox);
            this.Controls.Add(this.MiddleNameTextBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FisrtNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(550, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(550, 400);
            this.Name = "AddOrUpdateUserForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Update User Detail";
            this.Load += new System.EventHandler(this.AddOrUpdateUserForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FisrtNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.TextBox MiddleNameTextBox;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SaveButton;
    }
}