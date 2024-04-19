
namespace densing_client_crud.Entities
{
    partial class UpdateClient
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
            this.addbutton = new System.Windows.Forms.Button();
            this.date_val = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.rname_val = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lname_val = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fname_val = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addbutton
            // 
            this.addbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.addbutton.Location = new System.Drawing.Point(129, 264);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 34);
            this.addbutton.TabIndex = 17;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = false;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // date_val
            // 
            this.date_val.Location = new System.Drawing.Point(108, 215);
            this.date_val.Name = "date_val";
            this.date_val.Size = new System.Drawing.Size(200, 20);
            this.date_val.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Birthday";
            // 
            // rname_val
            // 
            this.rname_val.Location = new System.Drawing.Point(108, 153);
            this.rname_val.Name = "rname_val";
            this.rname_val.Size = new System.Drawing.Size(195, 20);
            this.rname_val.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Residency";
            // 
            // lname_val
            // 
            this.lname_val.Location = new System.Drawing.Point(108, 82);
            this.lname_val.Name = "lname_val";
            this.lname_val.Size = new System.Drawing.Size(195, 20);
            this.lname_val.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 11;
            this.label2.Text = "Lastname";
            // 
            // fname_val
            // 
            this.fname_val.Location = new System.Drawing.Point(108, 22);
            this.fname_val.Name = "fname_val";
            this.fname_val.Size = new System.Drawing.Size(195, 20);
            this.fname_val.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calisto MT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Firstname";
            // 
            // UpdateClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 309);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.date_val);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rname_val);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lname_val);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fname_val);
            this.Controls.Add(this.label1);
            this.Name = "UpdateClient";
            this.Text = "UpdateClient";
            this.Load += new System.EventHandler(this.UpdateClient_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.DateTimePicker date_val;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox rname_val;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lname_val;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fname_val;
        private System.Windows.Forms.Label label1;
    }
}