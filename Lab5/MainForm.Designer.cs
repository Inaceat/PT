namespace Lab5
{
    internal partial class MainForm
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
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.nameStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.gradeStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.perfomanceStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.menuMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBar = new System.Windows.Forms.ToolStrip();
            this.loadToolButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addToolButton = new System.Windows.Forms.ToolStripButton();
            this.updateToolButton = new System.Windows.Forms.ToolStripButton();
            this.deleteToolButton = new System.Windows.Forms.ToolStripButton();
            this.formattedOutputListBox = new System.Windows.Forms.ListBox();
            this.gradeNumberInput = new System.Windows.Forms.NumericUpDown();
            this.gradeIndexInput = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            this.statusStrip.SuspendLayout();
            this.mainMenuStrip.SuspendLayout();
            this.toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeNumberInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(557, 60);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(52, 17);
            label2.TabIndex = 16;
            label2.Text = "Grade:";
            // 
            // outputListBox
            // 
            this.outputListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.outputListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.IntegralHeight = false;
            this.outputListBox.ItemHeight = 16;
            this.outputListBox.Location = new System.Drawing.Point(0, 52);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.outputListBox.Size = new System.Drawing.Size(286, 436);
            this.outputListBox.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(292, 371);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(79, 35);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.OnAddClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.Location = new System.Drawing.Point(292, 453);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(79, 35);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.OnDeleteClick);
            // 
            // updateButton
            // 
            this.updateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updateButton.Location = new System.Drawing.Point(292, 412);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(79, 35);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.OnUpdateClick);
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.Location = new System.Drawing.Point(292, 52);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(79, 35);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(292, 93);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(79, 35);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameStatusLabel,
            this.gradeStatusLabel,
            this.perfomanceStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 492);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(816, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "statusStrip";
            // 
            // nameStatusLabel
            // 
            this.nameStatusLabel.Name = "nameStatusLabel";
            this.nameStatusLabel.Size = new System.Drawing.Size(267, 17);
            this.nameStatusLabel.Spring = true;
            // 
            // gradeStatusLabel
            // 
            this.gradeStatusLabel.Name = "gradeStatusLabel";
            this.gradeStatusLabel.Size = new System.Drawing.Size(267, 17);
            this.gradeStatusLabel.Spring = true;
            // 
            // perfomanceStatusLabel
            // 
            this.perfomanceStatusLabel.Name = "perfomanceStatusLabel";
            this.perfomanceStatusLabel.Size = new System.Drawing.Size(267, 17);
            this.perfomanceStatusLabel.Spring = true;
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Size = new System.Drawing.Size(816, 24);
            this.mainMenuStrip.TabIndex = 7;
            this.mainMenuStrip.Text = "MainMenu";
            // 
            // menuMenuItem
            // 
            this.menuMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadMenuItem,
            this.saveMenuItem,
            this.toolStripSeparator1,
            this.addMenuItem,
            this.updateMenuItem,
            this.deleteMenuItem});
            this.menuMenuItem.Name = "menuMenuItem";
            this.menuMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuMenuItem.Text = "Menu";
            // 
            // loadMenuItem
            // 
            this.loadMenuItem.Name = "loadMenuItem";
            this.loadMenuItem.Size = new System.Drawing.Size(112, 22);
            this.loadMenuItem.Text = "Load";
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveMenuItem.Text = "Save";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(109, 6);
            // 
            // addMenuItem
            // 
            this.addMenuItem.Name = "addMenuItem";
            this.addMenuItem.Size = new System.Drawing.Size(112, 22);
            this.addMenuItem.Text = "Add";
            // 
            // updateMenuItem
            // 
            this.updateMenuItem.Name = "updateMenuItem";
            this.updateMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateMenuItem.Text = "Update";
            // 
            // deleteMenuItem
            // 
            this.deleteMenuItem.Name = "deleteMenuItem";
            this.deleteMenuItem.Size = new System.Drawing.Size(112, 22);
            this.deleteMenuItem.Text = "Delete";
            // 
            // toolBar
            // 
            this.toolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolButton,
            this.saveToolButton,
            this.toolStripSeparator2,
            this.addToolButton,
            this.updateToolButton,
            this.deleteToolButton});
            this.toolBar.Location = new System.Drawing.Point(0, 24);
            this.toolBar.Name = "toolBar";
            this.toolBar.Padding = new System.Windows.Forms.Padding(12, 0, 1, 0);
            this.toolBar.Size = new System.Drawing.Size(816, 25);
            this.toolBar.TabIndex = 8;
            // 
            // loadToolButton
            // 
            this.loadToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.loadToolButton.Image = ((System.Drawing.Image)(resources.GetObject("loadToolButton.Image")));
            this.loadToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.loadToolButton.Name = "loadToolButton";
            this.loadToolButton.Size = new System.Drawing.Size(23, 22);
            this.loadToolButton.ToolTipText = "Load from file";
            // 
            // saveToolButton
            // 
            this.saveToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolButton.Image")));
            this.saveToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolButton.Name = "saveToolButton";
            this.saveToolButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolButton.ToolTipText = "Save to file";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // addToolButton
            // 
            this.addToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.addToolButton.Image = ((System.Drawing.Image)(resources.GetObject("addToolButton.Image")));
            this.addToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addToolButton.Name = "addToolButton";
            this.addToolButton.Size = new System.Drawing.Size(23, 22);
            this.addToolButton.ToolTipText = "Add new item";
            // 
            // updateToolButton
            // 
            this.updateToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.updateToolButton.Image = ((System.Drawing.Image)(resources.GetObject("updateToolButton.Image")));
            this.updateToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.updateToolButton.Name = "updateToolButton";
            this.updateToolButton.Size = new System.Drawing.Size(23, 22);
            this.updateToolButton.ToolTipText = "Update selected item";
            // 
            // deleteToolButton
            // 
            this.deleteToolButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteToolButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolButton.Image")));
            this.deleteToolButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolButton.Name = "deleteToolButton";
            this.deleteToolButton.Size = new System.Drawing.Size(23, 22);
            this.deleteToolButton.ToolTipText = "Delete selected items";
            // 
            // formattedOutputListBox
            // 
            this.formattedOutputListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formattedOutputListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formattedOutputListBox.FormattingEnabled = true;
            this.formattedOutputListBox.IntegralHeight = false;
            this.formattedOutputListBox.ItemHeight = 16;
            this.formattedOutputListBox.Location = new System.Drawing.Point(452, 93);
            this.formattedOutputListBox.Name = "formattedOutputListBox";
            this.formattedOutputListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.formattedOutputListBox.Size = new System.Drawing.Size(352, 395);
            this.formattedOutputListBox.TabIndex = 9;
            // 
            // gradeNumberInput
            // 
            this.gradeNumberInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gradeNumberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gradeNumberInput.Location = new System.Drawing.Point(615, 58);
            this.gradeNumberInput.Maximum = new decimal(new int[] {
            11,
            0,
            0,
            0});
            this.gradeNumberInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gradeNumberInput.Name = "gradeNumberInput";
            this.gradeNumberInput.ReadOnly = true;
            this.gradeNumberInput.Size = new System.Drawing.Size(92, 23);
            this.gradeNumberInput.TabIndex = 14;
            this.gradeNumberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gradeNumberInput.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // gradeIndexInput
            // 
            this.gradeIndexInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gradeIndexInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gradeIndexInput.Location = new System.Drawing.Point(713, 58);
            this.gradeIndexInput.Name = "gradeIndexInput";
            this.gradeIndexInput.Size = new System.Drawing.Size(91, 23);
            this.gradeIndexInput.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 514);
            this.Controls.Add(this.gradeNumberInput);
            this.Controls.Add(this.gradeIndexInput);
            this.Controls.Add(label2);
            this.Controls.Add(this.formattedOutputListBox);
            this.Controls.Add(this.toolBar);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainMenuStrip);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.outputListBox);
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab 5";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.toolBar.ResumeLayout(false);
            this.toolBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gradeNumberInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel nameStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel gradeStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel perfomanceStatusLabel;
        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem addMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteMenuItem;
        private System.Windows.Forms.ToolStrip toolBar;
        private System.Windows.Forms.ToolStripButton loadToolButton;
        private System.Windows.Forms.ToolStripButton saveToolButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton addToolButton;
        private System.Windows.Forms.ToolStripButton updateToolButton;
        private System.Windows.Forms.ToolStripButton deleteToolButton;
        private System.Windows.Forms.ListBox formattedOutputListBox;
        private System.Windows.Forms.NumericUpDown gradeNumberInput;
        private System.Windows.Forms.TextBox gradeIndexInput;
    }
}

