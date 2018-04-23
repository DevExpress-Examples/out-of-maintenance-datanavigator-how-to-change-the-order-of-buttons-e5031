namespace WindowsFormsApplication21 {
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
            this.customDataNavigator1 = new WindowsFormsApplication21.CustomDataNavigator();
            this.SuspendLayout();
            // 
            // customDataNavigator1
            // 
            this.customDataNavigator1.Buttons.CancelEdit.Visible = false;
            this.customDataNavigator1.Buttons.EndEdit.Visible = false;
            this.customDataNavigator1.CustomButtons.AddRange(new DevExpress.XtraEditors.NavigatorCustomButton[] {
            new DevExpress.XtraEditors.NavigatorCustomButton(10),
            new DevExpress.XtraEditors.NavigatorCustomButton(9)});
            this.customDataNavigator1.Location = new System.Drawing.Point(64, 254);
            this.customDataNavigator1.Name = "customDataNavigator1";
            this.customDataNavigator1.Size = new System.Drawing.Size(260, 19);
            this.customDataNavigator1.TabIndex = 21;
            this.customDataNavigator1.Text = "customDataNavigator1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 469);
            this.Controls.Add(this.customDataNavigator1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomDataNavigator customDataNavigator1;

    }
}

