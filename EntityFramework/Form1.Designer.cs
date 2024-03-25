namespace EntityFramework
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
            this.AddPerson_btn = new System.Windows.Forms.Button();
            this.UpdatePerson_btn = new System.Windows.Forms.Button();
            this.DeletePerson_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeletePerson_btn2 = new System.Windows.Forms.Button();
            this.DisplayPerosn_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddPerson_btn
            // 
            this.AddPerson_btn.Location = new System.Drawing.Point(345, 12);
            this.AddPerson_btn.Name = "AddPerson_btn";
            this.AddPerson_btn.Size = new System.Drawing.Size(107, 49);
            this.AddPerson_btn.TabIndex = 0;
            this.AddPerson_btn.Text = "Add Person";
            this.AddPerson_btn.UseVisualStyleBackColor = true;
            this.AddPerson_btn.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // UpdatePerson_btn
            // 
            this.UpdatePerson_btn.Location = new System.Drawing.Point(345, 67);
            this.UpdatePerson_btn.Name = "UpdatePerson_btn";
            this.UpdatePerson_btn.Size = new System.Drawing.Size(107, 49);
            this.UpdatePerson_btn.TabIndex = 0;
            this.UpdatePerson_btn.Text = "Update Person";
            this.UpdatePerson_btn.UseVisualStyleBackColor = true;
            this.UpdatePerson_btn.Click += new System.EventHandler(this.UpdatePerson_btn_Click);
            // 
            // DeletePerson_btn
            // 
            this.DeletePerson_btn.Location = new System.Drawing.Point(345, 122);
            this.DeletePerson_btn.Name = "DeletePerson_btn";
            this.DeletePerson_btn.Size = new System.Drawing.Size(107, 49);
            this.DeletePerson_btn.TabIndex = 0;
            this.DeletePerson_btn.Text = "Delete Person";
            this.DeletePerson_btn.UseVisualStyleBackColor = true;
            this.DeletePerson_btn.Click += new System.EventHandler(this.DeletePerson_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "With Id :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Without Id : ";
            // 
            // DeletePerson_btn2
            // 
            this.DeletePerson_btn2.Location = new System.Drawing.Point(345, 183);
            this.DeletePerson_btn2.Name = "DeletePerson_btn2";
            this.DeletePerson_btn2.Size = new System.Drawing.Size(107, 49);
            this.DeletePerson_btn2.TabIndex = 0;
            this.DeletePerson_btn2.Text = "Delete Person";
            this.DeletePerson_btn2.UseVisualStyleBackColor = true;
            this.DeletePerson_btn2.Click += new System.EventHandler(this.DeletePerson_btn2_Click);
            // 
            // DisplayPerosn_btn
            // 
            this.DisplayPerosn_btn.Location = new System.Drawing.Point(345, 255);
            this.DisplayPerosn_btn.Name = "DisplayPerosn_btn";
            this.DisplayPerosn_btn.Size = new System.Drawing.Size(107, 49);
            this.DisplayPerosn_btn.TabIndex = 0;
            this.DisplayPerosn_btn.Text = "Display";
            this.DisplayPerosn_btn.UseVisualStyleBackColor = true;
            this.DisplayPerosn_btn.Click += new System.EventHandler(this.DisplayPerosn_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisplayPerosn_btn);
            this.Controls.Add(this.DeletePerson_btn2);
            this.Controls.Add(this.DeletePerson_btn);
            this.Controls.Add(this.UpdatePerson_btn);
            this.Controls.Add(this.AddPerson_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddPerson_btn;
        private System.Windows.Forms.Button UpdatePerson_btn;
        private System.Windows.Forms.Button DeletePerson_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button DeletePerson_btn2;
        private System.Windows.Forms.Button DisplayPerosn_btn;
    }
}

