namespace SolidWinforms
{
    partial class frmSolidWinforms
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGenerateArea = new System.Windows.Forms.Button();
            this.txtShapeName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 238);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGenerateArea
            // 
            this.btnGenerateArea.Location = new System.Drawing.Point(174, 238);
            this.btnGenerateArea.Name = "btnGenerateArea";
            this.btnGenerateArea.Size = new System.Drawing.Size(106, 23);
            this.btnGenerateArea.TabIndex = 1;
            this.btnGenerateArea.Text = "Generate Area";
            this.btnGenerateArea.UseVisualStyleBackColor = true;
            this.btnGenerateArea.Click += new System.EventHandler(this.btnGenerateArea_Click);
            // 
            // txtShapeName
            // 
            this.txtShapeName.Location = new System.Drawing.Point(12, 12);
            this.txtShapeName.Name = "txtShapeName";
            this.txtShapeName.Size = new System.Drawing.Size(100, 20);
            this.txtShapeName.TabIndex = 2;
            // 
            // frmSolidWinforms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.txtShapeName);
            this.Controls.Add(this.btnGenerateArea);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmSolidWinforms";
            this.Text = "Solid Practice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGenerateArea;
        private System.Windows.Forms.TextBox txtShapeName;
    }
}

