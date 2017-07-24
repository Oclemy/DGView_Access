namespace DGView_Access
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.nameTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.propellantTxt = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.destinationTxt = new MetroFramework.Controls.MetroTextBox();
            this.addBtn = new MetroFramework.Controls.MetroButton();
            this.retrieveBtn = new MetroFramework.Controls.MetroButton();
            this.updateBtn = new MetroFramework.Controls.MetroButton();
            this.deleteBtn = new MetroFramework.Controls.MetroButton();
            this.clearBtn = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 391);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(-20, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(17, 17);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(0, 0);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(0, 22);
            this.metroTextBox1.TabIndex = 0;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nameTxt
            // 
            // 
            // 
            // 
            this.nameTxt.CustomButton.Image = null;
            this.nameTxt.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.nameTxt.CustomButton.Name = "";
            this.nameTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameTxt.CustomButton.TabIndex = 1;
            this.nameTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTxt.CustomButton.UseSelectable = true;
            this.nameTxt.CustomButton.Visible = false;
            this.nameTxt.Lines = new string[0];
            this.nameTxt.Location = new System.Drawing.Point(675, 101);
            this.nameTxt.MaxLength = 32767;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.PasswordChar = '\0';
            this.nameTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTxt.SelectedText = "";
            this.nameTxt.SelectionLength = 0;
            this.nameTxt.SelectionStart = 0;
            this.nameTxt.ShortcutsEnabled = true;
            this.nameTxt.Size = new System.Drawing.Size(120, 23);
            this.nameTxt.TabIndex = 1;
            this.nameTxt.UseSelectable = true;
            this.nameTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(574, 101);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(45, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Name";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(574, 170);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(69, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Propellant";
            // 
            // propellantTxt
            // 
            // 
            // 
            // 
            this.propellantTxt.CustomButton.Image = null;
            this.propellantTxt.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.propellantTxt.CustomButton.Name = "";
            this.propellantTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.propellantTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.propellantTxt.CustomButton.TabIndex = 1;
            this.propellantTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.propellantTxt.CustomButton.UseSelectable = true;
            this.propellantTxt.CustomButton.Visible = false;
            this.propellantTxt.Lines = new string[0];
            this.propellantTxt.Location = new System.Drawing.Point(675, 170);
            this.propellantTxt.MaxLength = 32767;
            this.propellantTxt.Name = "propellantTxt";
            this.propellantTxt.PasswordChar = '\0';
            this.propellantTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.propellantTxt.SelectedText = "";
            this.propellantTxt.SelectionLength = 0;
            this.propellantTxt.SelectionStart = 0;
            this.propellantTxt.ShortcutsEnabled = true;
            this.propellantTxt.Size = new System.Drawing.Size(120, 23);
            this.propellantTxt.TabIndex = 3;
            this.propellantTxt.UseSelectable = true;
            this.propellantTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.propellantTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(574, 233);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(73, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Destination";
            // 
            // destinationTxt
            // 
            // 
            // 
            // 
            this.destinationTxt.CustomButton.Image = null;
            this.destinationTxt.CustomButton.Location = new System.Drawing.Point(98, 1);
            this.destinationTxt.CustomButton.Name = "";
            this.destinationTxt.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.destinationTxt.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.destinationTxt.CustomButton.TabIndex = 1;
            this.destinationTxt.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.destinationTxt.CustomButton.UseSelectable = true;
            this.destinationTxt.CustomButton.Visible = false;
            this.destinationTxt.Lines = new string[0];
            this.destinationTxt.Location = new System.Drawing.Point(675, 233);
            this.destinationTxt.MaxLength = 32767;
            this.destinationTxt.Name = "destinationTxt";
            this.destinationTxt.PasswordChar = '\0';
            this.destinationTxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.destinationTxt.SelectedText = "";
            this.destinationTxt.SelectionLength = 0;
            this.destinationTxt.SelectionStart = 0;
            this.destinationTxt.ShortcutsEnabled = true;
            this.destinationTxt.Size = new System.Drawing.Size(120, 23);
            this.destinationTxt.TabIndex = 5;
            this.destinationTxt.UseSelectable = true;
            this.destinationTxt.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.destinationTxt.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(574, 301);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 7;
            this.addBtn.Text = "Add";
            this.addBtn.UseSelectable = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // retrieveBtn
            // 
            this.retrieveBtn.Location = new System.Drawing.Point(689, 301);
            this.retrieveBtn.Name = "retrieveBtn";
            this.retrieveBtn.Size = new System.Drawing.Size(75, 23);
            this.retrieveBtn.TabIndex = 8;
            this.retrieveBtn.Text = "Retrieve";
            this.retrieveBtn.UseSelectable = true;
            this.retrieveBtn.Click += new System.EventHandler(this.retrieveBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(574, 356);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 9;
            this.updateBtn.Text = "Update";
            this.updateBtn.UseSelectable = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(689, 356);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 10;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseSelectable = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Location = new System.Drawing.Point(628, 411);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(75, 23);
            this.clearBtn.TabIndex = 11;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseSelectable = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 475);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.retrieveBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.destinationTxt);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.propellantTxt);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "DataGridView Access CRUD";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroTextBox nameTxt;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox propellantTxt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox destinationTxt;
        private MetroFramework.Controls.MetroButton addBtn;
        private MetroFramework.Controls.MetroButton retrieveBtn;
        private MetroFramework.Controls.MetroButton updateBtn;
        private MetroFramework.Controls.MetroButton deleteBtn;
        private MetroFramework.Controls.MetroButton clearBtn;
    }
}

