namespace Q140416 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.myListBoxControl1 = new DXSample.MyListBoxControl();
            ((System.ComponentModel.ISupportInitialize)(this.myListBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // myListBoxControl1
            // 
            this.myListBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myListBoxControl1.Items.AddRange(new object[] {
            "Item 1",
            "Item 2",
            "Item 3",
            "Item 4",
            "Item 5"});
            this.myListBoxControl1.Location = new System.Drawing.Point(0, 0);
            this.myListBoxControl1.Name = "myListBoxControl1";
            this.myListBoxControl1.Size = new System.Drawing.Size(284, 264);
            this.myListBoxControl1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.myListBoxControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.myListBoxControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DXSample.MyListBoxControl myListBoxControl1;

    }
}

