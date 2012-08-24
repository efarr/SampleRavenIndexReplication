namespace SampleRavenIndexReplication
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
            this._ravenUrlTextBox = new System.Windows.Forms.TextBox();
            this._sqlConnectionStringTextBox = new System.Windows.Forms.TextBox();
            this._createTableButton = new System.Windows.Forms.Button();
            this._createIndexButton = new System.Windows.Forms.Button();
            this._configureReplicationButton = new System.Windows.Forms.Button();
            this._resetIndexButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._dogNameTextBox = new System.Windows.Forms.TextBox();
            this._dogBreedTextBox = new System.Windows.Forms.TextBox();
            this._addDogButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _ravenUrlTextBox
            // 
            this._ravenUrlTextBox.Location = new System.Drawing.Point(12, 12);
            this._ravenUrlTextBox.Name = "_ravenUrlTextBox";
            this._ravenUrlTextBox.Size = new System.Drawing.Size(364, 20);
            this._ravenUrlTextBox.TabIndex = 0;
            // 
            // _sqlConnectionStringTextBox
            // 
            this._sqlConnectionStringTextBox.Location = new System.Drawing.Point(12, 38);
            this._sqlConnectionStringTextBox.Name = "_sqlConnectionStringTextBox";
            this._sqlConnectionStringTextBox.Size = new System.Drawing.Size(364, 20);
            this._sqlConnectionStringTextBox.TabIndex = 1;
            // 
            // _createTableButton
            // 
            this._createTableButton.Location = new System.Drawing.Point(13, 78);
            this._createTableButton.Name = "_createTableButton";
            this._createTableButton.Size = new System.Drawing.Size(136, 23);
            this._createTableButton.TabIndex = 2;
            this._createTableButton.Text = "Create Table";
            this._createTableButton.UseVisualStyleBackColor = true;
            this._createTableButton.Click += new System.EventHandler(this.createTableButtonClick);
            // 
            // _createIndexButton
            // 
            this._createIndexButton.Location = new System.Drawing.Point(206, 78);
            this._createIndexButton.Name = "_createIndexButton";
            this._createIndexButton.Size = new System.Drawing.Size(147, 23);
            this._createIndexButton.TabIndex = 3;
            this._createIndexButton.Text = "Create Index";
            this._createIndexButton.UseVisualStyleBackColor = true;
            this._createIndexButton.Click += new System.EventHandler(this.createIndexButtonClick);
            // 
            // _configureReplicationButton
            // 
            this._configureReplicationButton.Location = new System.Drawing.Point(13, 107);
            this._configureReplicationButton.Name = "_configureReplicationButton";
            this._configureReplicationButton.Size = new System.Drawing.Size(136, 23);
            this._configureReplicationButton.TabIndex = 4;
            this._configureReplicationButton.Text = "Configure Replication";
            this._configureReplicationButton.UseVisualStyleBackColor = true;
            this._configureReplicationButton.Click += new System.EventHandler(this._configureReplicationButton_Click);
            // 
            // _resetIndexButton
            // 
            this._resetIndexButton.Location = new System.Drawing.Point(206, 107);
            this._resetIndexButton.Name = "_resetIndexButton";
            this._resetIndexButton.Size = new System.Drawing.Size(147, 23);
            this._resetIndexButton.TabIndex = 5;
            this._resetIndexButton.Text = "Reset Index";
            this._resetIndexButton.UseVisualStyleBackColor = true;
            this._resetIndexButton.Click += new System.EventHandler(this._resetIndexButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Breed:";
            // 
            // _dogNameTextBox
            // 
            this._dogNameTextBox.Location = new System.Drawing.Point(56, 155);
            this._dogNameTextBox.Name = "_dogNameTextBox";
            this._dogNameTextBox.Size = new System.Drawing.Size(210, 20);
            this._dogNameTextBox.TabIndex = 8;
            this._dogNameTextBox.Text = "Lassie";
            // 
            // _dogBreedTextBox
            // 
            this._dogBreedTextBox.Location = new System.Drawing.Point(56, 183);
            this._dogBreedTextBox.Name = "_dogBreedTextBox";
            this._dogBreedTextBox.Size = new System.Drawing.Size(210, 20);
            this._dogBreedTextBox.TabIndex = 9;
            this._dogBreedTextBox.Text = "Collie";
            // 
            // _addDogButton
            // 
            this._addDogButton.Location = new System.Drawing.Point(279, 158);
            this._addDogButton.Name = "_addDogButton";
            this._addDogButton.Size = new System.Drawing.Size(97, 45);
            this._addDogButton.TabIndex = 10;
            this._addDogButton.Text = "Add";
            this._addDogButton.UseVisualStyleBackColor = true;
            this._addDogButton.Click += new System.EventHandler(this._addDogButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 262);
            this.Controls.Add(this._addDogButton);
            this.Controls.Add(this._dogBreedTextBox);
            this.Controls.Add(this._dogNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._resetIndexButton);
            this.Controls.Add(this._configureReplicationButton);
            this.Controls.Add(this._createIndexButton);
            this.Controls.Add(this._createTableButton);
            this.Controls.Add(this._sqlConnectionStringTextBox);
            this.Controls.Add(this._ravenUrlTextBox);
            this.Name = "MainForm";
            this.Text = "RavenDB Index Replication Sample";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _ravenUrlTextBox;
        private System.Windows.Forms.TextBox _sqlConnectionStringTextBox;
        private System.Windows.Forms.Button _createTableButton;
        private System.Windows.Forms.Button _createIndexButton;
        private System.Windows.Forms.Button _configureReplicationButton;
        private System.Windows.Forms.Button _resetIndexButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _dogNameTextBox;
        private System.Windows.Forms.TextBox _dogBreedTextBox;
        private System.Windows.Forms.Button _addDogButton;
    }
}

