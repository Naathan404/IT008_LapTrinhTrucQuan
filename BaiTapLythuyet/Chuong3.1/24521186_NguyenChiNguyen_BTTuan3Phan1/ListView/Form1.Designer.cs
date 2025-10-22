namespace ListView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Apple",
            "12",
            "Available"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Orange",
            "5",
            "Available"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "Banana",
            "44",
            "Available"}, -1);
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "4",
            "Durian",
            "0",
            "Unvailable"}, -1);
            this.lsVListView = new System.Windows.Forms.ListView();
            this.No = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fruit = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbbListBoxViewSelection = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lsVListView
            // 
            this.lsVListView.BackColor = System.Drawing.Color.Khaki;
            this.lsVListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.No,
            this.Fruit,
            this.Quantity,
            this.Status});
            this.lsVListView.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lsVListView.HideSelection = false;
            this.lsVListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3,
            listViewItem4});
            this.lsVListView.Location = new System.Drawing.Point(238, 120);
            this.lsVListView.Name = "lsVListView";
            this.lsVListView.Size = new System.Drawing.Size(373, 182);
            this.lsVListView.TabIndex = 0;
            this.lsVListView.UseCompatibleStateImageBehavior = false;
            this.lsVListView.View = System.Windows.Forms.View.Details;
            // 
            // No
            // 
            this.No.Text = "No.";
            this.No.Width = 40;
            // 
            // Fruit
            // 
            this.Fruit.Text = "Fruit";
            // 
            // Quantity
            // 
            this.Quantity.Text = "Quantity";
            this.Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Status
            // 
            this.Status.Text = "Status";
            this.Status.Width = 200;
            // 
            // cbbListBoxViewSelection
            // 
            this.cbbListBoxViewSelection.FormattingEnabled = true;
            this.cbbListBoxViewSelection.Items.AddRange(new object[] {
            "LargeIcon",
            "SmallIcon",
            "List",
            "Tile",
            "Details"});
            this.cbbListBoxViewSelection.Location = new System.Drawing.Point(86, 120);
            this.cbbListBoxViewSelection.Name = "cbbListBoxViewSelection";
            this.cbbListBoxViewSelection.Size = new System.Drawing.Size(122, 24);
            this.cbbListBoxViewSelection.TabIndex = 1;
            this.cbbListBoxViewSelection.Text = "Details";
            this.cbbListBoxViewSelection.SelectedIndexChanged += new System.EventHandler(this.cbbListBoxViewSelection_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbbListBoxViewSelection);
            this.Controls.Add(this.lsVListView);
            this.Name = "Form1";
            this.Text = "ListView Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsVListView;
        private System.Windows.Forms.ColumnHeader No;
        private System.Windows.Forms.ColumnHeader Fruit;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.ColumnHeader Status;
        private System.Windows.Forms.ComboBox cbbListBoxViewSelection;
    }
}

