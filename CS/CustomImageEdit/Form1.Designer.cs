namespace CustomImageEdit_NS
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
            this.customImageEdit2 = new MyCustomEdit.CustomImageEdit();
            this.customImageEdit1 = new MyCustomEdit.CustomImageEdit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // customImageEdit2
            // 
            this.customImageEdit2.Location = new System.Drawing.Point(12, 38);
            this.customImageEdit2.Name = "customImageEdit2";
            this.customImageEdit2.Properties.ActionButtonIndex = 1;
            this.customImageEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customImageEdit2.Size = new System.Drawing.Size(100, 20);
            this.customImageEdit2.TabIndex = 1;
            // 
            // customImageEdit1
            // 
            this.customImageEdit1.Location = new System.Drawing.Point(12, 12);
            this.customImageEdit1.Name = "customImageEdit1";
            this.customImageEdit1.Properties.ActionButtonIndex = 1;
            this.customImageEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customImageEdit1.Size = new System.Drawing.Size(100, 20);
            this.customImageEdit1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.customImageEdit2);
            this.Controls.Add(this.customImageEdit1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customImageEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customImageEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MyCustomEdit.CustomImageEdit customImageEdit1;
        private MyCustomEdit.CustomImageEdit customImageEdit2;

    }
}

