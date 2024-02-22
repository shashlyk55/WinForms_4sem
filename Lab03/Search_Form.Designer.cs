namespace Lab03
{
    partial class SearchForm
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
            this.textBox_InputSearch = new System.Windows.Forms.TextBox();
            this.SearchParm_label = new System.Windows.Forms.Label();
            this.checkedListBox_SearchParams = new System.Windows.Forms.CheckedListBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.checkBox_UseRegex = new System.Windows.Forms.CheckBox();
            this.listBox_ShowResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox_InputSearch
            // 
            this.textBox_InputSearch.Location = new System.Drawing.Point(12, 123);
            this.textBox_InputSearch.Name = "textBox_InputSearch";
            this.textBox_InputSearch.Size = new System.Drawing.Size(143, 20);
            this.textBox_InputSearch.TabIndex = 1;
            // 
            // SearchParm_label
            // 
            this.SearchParm_label.AutoSize = true;
            this.SearchParm_label.Location = new System.Drawing.Point(9, 16);
            this.SearchParm_label.Name = "SearchParm_label";
            this.SearchParm_label.Size = new System.Drawing.Size(100, 13);
            this.SearchParm_label.TabIndex = 2;
            this.SearchParm_label.Text = "Параметр поиска:";
            // 
            // checkedListBox_SearchParams
            // 
            this.checkedListBox_SearchParams.FormattingEnabled = true;
            this.checkedListBox_SearchParams.Items.AddRange(new object[] {
            "Лектор",
            "Семестр",
            "Курс"});
            this.checkedListBox_SearchParams.Location = new System.Drawing.Point(12, 33);
            this.checkedListBox_SearchParams.Name = "checkedListBox_SearchParams";
            this.checkedListBox_SearchParams.Size = new System.Drawing.Size(106, 49);
            this.checkedListBox_SearchParams.TabIndex = 3;
            // 
            // button_Search
            // 
            this.button_Search.Location = new System.Drawing.Point(12, 149);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(75, 23);
            this.button_Search.TabIndex = 4;
            this.button_Search.Text = "Поиск";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // checkBox_UseRegex
            // 
            this.checkBox_UseRegex.AutoSize = true;
            this.checkBox_UseRegex.Location = new System.Drawing.Point(12, 88);
            this.checkBox_UseRegex.Name = "checkBox_UseRegex";
            this.checkBox_UseRegex.Size = new System.Drawing.Size(189, 17);
            this.checkBox_UseRegex.TabIndex = 5;
            this.checkBox_UseRegex.Text = "Использовать рег. выражения?";
            this.checkBox_UseRegex.UseVisualStyleBackColor = true;
            // 
            // listBox_ShowResults
            // 
            this.listBox_ShowResults.FormattingEnabled = true;
            this.listBox_ShowResults.Location = new System.Drawing.Point(12, 200);
            this.listBox_ShowResults.Name = "listBox_ShowResults";
            this.listBox_ShowResults.Size = new System.Drawing.Size(671, 225);
            this.listBox_ShowResults.TabIndex = 6;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 438);
            this.Controls.Add(this.listBox_ShowResults);
            this.Controls.Add(this.checkBox_UseRegex);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.checkedListBox_SearchParams);
            this.Controls.Add(this.SearchParm_label);
            this.Controls.Add(this.textBox_InputSearch);
            this.Name = "SearchForm";
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_InputSearch;
        private System.Windows.Forms.Label SearchParm_label;
        private System.Windows.Forms.CheckedListBox checkedListBox_SearchParams;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.CheckBox checkBox_UseRegex;
        private System.Windows.Forms.ListBox listBox_ShowResults;
    }
}