namespace Lab02
{
    partial class Error_Form
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
            this.label_Error = new System.Windows.Forms.Label();
            this.button_OK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Error
            // 
            this.label_Error.Location = new System.Drawing.Point(12, 38);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(305, 38);
            this.label_Error.TabIndex = 0;
            this.label_Error.Text = "Error occured";
            this.label_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(131, 79);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(68, 22);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Error_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 173);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.label_Error);
            this.Name = "Error_Form";
            this.Text = "Error";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.Button button_OK;
    }
}