namespace Banka
{
    partial class Capcha
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
            this.CapchaPB = new System.Windows.Forms.PictureBox();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CapchaPB)).BeginInit();
            this.SuspendLayout();
            // 
            // CapchaPB
            // 
            this.CapchaPB.Location = new System.Drawing.Point(12, 12);
            this.CapchaPB.Name = "CapchaPB";
            this.CapchaPB.Size = new System.Drawing.Size(246, 123);
            this.CapchaPB.TabIndex = 0;
            this.CapchaPB.TabStop = false;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(12, 156);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(246, 23);
            this.TextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите тескт с картинки";
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(12, 194);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 3;
            this.UpdateButton.Text = "Обновить";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AcceptButton.Location = new System.Drawing.Point(158, 194);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(86, 23);
            this.AcceptButton.TabIndex = 4;
            this.AcceptButton.Text = "Подтвердить";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Capcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 225);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.CapchaPB);
            this.Name = "Capcha";
            this.Text = "Capcha";
            this.Load += new System.EventHandler(this.Capcha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CapchaPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox CapchaPB;
        private TextBox TextBox;
        private Label label1;
        private Button UpdateButton;
        private Button AcceptButton;
    }
}