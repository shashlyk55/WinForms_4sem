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
            this.textBox_SearchLector = new System.Windows.Forms.TextBox();
            this.SearchParm_label = new System.Windows.Forms.Label();
            this.checkedListBox_SearchParams = new System.Windows.Forms.CheckedListBox();
            this.button_Search = new System.Windows.Forms.Button();
            this.checkBox_UseRegex = new System.Windows.Forms.CheckBox();
            this.textBox_SearchTerm = new System.Windows.Forms.TextBox();
            this.textBox_SearchCourse = new System.Windows.Forms.TextBox();
            this.labelSearch_Lektor = new System.Windows.Forms.Label();
            this.labelSearch_Term = new System.Windows.Forms.Label();
            this.labelSearch_Course = new System.Windows.Forms.Label();
            this.listBox_SearchResults = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBox_SearchLector
            // 
            this.textBox_SearchLector.Location = new System.Drawing.Point(222, 33);
            this.textBox_SearchLector.Name = "textBox_SearchLector";
            this.textBox_SearchLector.Size = new System.Drawing.Size(189, 20);
            this.textBox_SearchLector.TabIndex = 1;
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
            this.button_Search.Location = new System.Drawing.Point(12, 123);
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
            this.checkBox_UseRegex.Size = new System.Drawing.Size(115, 17);
            this.checkBox_UseRegex.TabIndex = 5;
            this.checkBox_UseRegex.Text = "Частичный поиск";
            this.checkBox_UseRegex.UseVisualStyleBackColor = true;
            // 
            // textBox_SearchTerm
            // 
            this.textBox_SearchTerm.Location = new System.Drawing.Point(222, 85);
            this.textBox_SearchTerm.Name = "textBox_SearchTerm";
            this.textBox_SearchTerm.Size = new System.Drawing.Size(189, 20);
            this.textBox_SearchTerm.TabIndex = 6;
            // 
            // textBox_SearchCourse
            // 
            this.textBox_SearchCourse.Location = new System.Drawing.Point(222, 139);
            this.textBox_SearchCourse.Name = "textBox_SearchCourse";
            this.textBox_SearchCourse.Size = new System.Drawing.Size(189, 20);
            this.textBox_SearchCourse.TabIndex = 7;
            // 
            // labelSearch_Lektor
            // 
            this.labelSearch_Lektor.AutoSize = true;
            this.labelSearch_Lektor.Location = new System.Drawing.Point(222, 13);
            this.labelSearch_Lektor.Name = "labelSearch_Lektor";
            this.labelSearch_Lektor.Size = new System.Drawing.Size(44, 13);
            this.labelSearch_Lektor.TabIndex = 8;
            this.labelSearch_Lektor.Text = "Лектор";
            // 
            // labelSearch_Term
            // 
            this.labelSearch_Term.AutoSize = true;
            this.labelSearch_Term.Location = new System.Drawing.Point(222, 69);
            this.labelSearch_Term.Name = "labelSearch_Term";
            this.labelSearch_Term.Size = new System.Drawing.Size(51, 13);
            this.labelSearch_Term.TabIndex = 9;
            this.labelSearch_Term.Text = "Семестр";
            // 
            // labelSearch_Course
            // 
            this.labelSearch_Course.AutoSize = true;
            this.labelSearch_Course.Location = new System.Drawing.Point(222, 123);
            this.labelSearch_Course.Name = "labelSearch_Course";
            this.labelSearch_Course.Size = new System.Drawing.Size(31, 13);
            this.labelSearch_Course.TabIndex = 10;
            this.labelSearch_Course.Text = "Курс";
            // 
            // listBox_SearchResults
            // 
            this.listBox_SearchResults.FormattingEnabled = true;
            this.listBox_SearchResults.Location = new System.Drawing.Point(12, 227);
            this.listBox_SearchResults.Name = "listBox_SearchResults";
            this.listBox_SearchResults.Size = new System.Drawing.Size(833, 199);
            this.listBox_SearchResults.TabIndex = 11;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 443);
            this.Controls.Add(this.listBox_SearchResults);
            this.Controls.Add(this.labelSearch_Course);
            this.Controls.Add(this.labelSearch_Term);
            this.Controls.Add(this.labelSearch_Lektor);
            this.Controls.Add(this.textBox_SearchCourse);
            this.Controls.Add(this.textBox_SearchTerm);
            this.Controls.Add(this.checkBox_UseRegex);
            this.Controls.Add(this.button_Search);
            this.Controls.Add(this.checkedListBox_SearchParams);
            this.Controls.Add(this.SearchParm_label);
            this.Controls.Add(this.textBox_SearchLector);
            this.Name = "SearchForm";
            this.Text = "Поиск";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_SearchLector;
        private System.Windows.Forms.Label SearchParm_label;
        private System.Windows.Forms.CheckedListBox checkedListBox_SearchParams;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.CheckBox checkBox_UseRegex;
        private System.Windows.Forms.TextBox textBox_SearchTerm;
        private System.Windows.Forms.TextBox textBox_SearchCourse;
        private System.Windows.Forms.Label labelSearch_Lektor;
        private System.Windows.Forms.Label labelSearch_Term;
        private System.Windows.Forms.Label labelSearch_Course;
        private System.Windows.Forms.ListBox listBox_SearchResults;
    }
}