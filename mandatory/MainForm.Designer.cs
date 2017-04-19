namespace mandatory
{
    partial class MainForm
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
            this.accessLabel = new System.Windows.Forms.Label();
            this.allObjectsDGV = new System.Windows.Forms.DataGridView();
            this.objectName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessibility = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessibleObjectsDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.allObjectsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessibleObjectsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // accessLabel
            // 
            this.accessLabel.AutoSize = true;
            this.accessLabel.Location = new System.Drawing.Point(13, 13);
            this.accessLabel.Name = "accessLabel";
            this.accessLabel.Size = new System.Drawing.Size(97, 13);
            this.accessLabel.TabIndex = 0;
            this.accessLabel.Text = "Your access level: ";
            // 
            // allObjectsDGV
            // 
            this.allObjectsDGV.AllowUserToAddRows = false;
            this.allObjectsDGV.AllowUserToDeleteRows = false;
            this.allObjectsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.allObjectsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.objectName,
            this.accessibility});
            this.allObjectsDGV.Location = new System.Drawing.Point(16, 69);
            this.allObjectsDGV.Name = "allObjectsDGV";
            this.allObjectsDGV.ReadOnly = true;
            this.allObjectsDGV.Size = new System.Drawing.Size(243, 304);
            this.allObjectsDGV.TabIndex = 1;
            // 
            // objectName
            // 
            this.objectName.HeaderText = "Object name";
            this.objectName.Name = "objectName";
            this.objectName.ReadOnly = true;
            // 
            // accessibility
            // 
            this.accessibility.HeaderText = "Accessibility";
            this.accessibility.Name = "accessibility";
            this.accessibility.ReadOnly = true;
            // 
            // accessibleObjectsDGV
            // 
            this.accessibleObjectsDGV.AllowUserToAddRows = false;
            this.accessibleObjectsDGV.AllowUserToDeleteRows = false;
            this.accessibleObjectsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accessibleObjectsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.accessibleObjectsDGV.Location = new System.Drawing.Point(279, 69);
            this.accessibleObjectsDGV.Name = "accessibleObjectsDGV";
            this.accessibleObjectsDGV.ReadOnly = true;
            this.accessibleObjectsDGV.Size = new System.Drawing.Size(243, 304);
            this.accessibleObjectsDGV.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Object name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Accessibility";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "All objects:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Accessible objects:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 390);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accessibleObjectsDGV);
            this.Controls.Add(this.allObjectsDGV);
            this.Controls.Add(this.accessLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Mandatory Secure Policy";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.allObjectsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accessibleObjectsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label accessLabel;
        private System.Windows.Forms.DataGridView allObjectsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn objectName;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessibility;
        private System.Windows.Forms.DataGridView accessibleObjectsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}