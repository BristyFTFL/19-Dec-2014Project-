namespace Practice5App
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.dequeueButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameEnqueueTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.complainEnqueueTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.serialNoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nameDequeueTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.complainDequeueTextBox = new System.Windows.Forms.TextBox();
            this.waitingQueueListView = new System.Windows.Forms.ListView();
            this.serialNoColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.complainColumnHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.complainEnqueueTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nameEnqueueTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.enqueueButton);
            this.groupBox1.Location = new System.Drawing.Point(27, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 161);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enqueue Customer";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.complainDequeueTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.nameDequeueTextBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.serialNoTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dequeueButton);
            this.groupBox2.Location = new System.Drawing.Point(391, 34);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 161);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dequeue Customer";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.waitingQueueListView);
            this.groupBox3.Location = new System.Drawing.Point(27, 218);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(693, 195);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Waiting Customer";
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(242, 117);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(75, 23);
            this.enqueueButton.TabIndex = 0;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // dequeueButton
            // 
            this.dequeueButton.Location = new System.Drawing.Point(238, 117);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(75, 23);
            this.dequeueButton.TabIndex = 0;
            this.dequeueButton.Text = "Dequeue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // nameEnqueueTextBox
            // 
            this.nameEnqueueTextBox.Location = new System.Drawing.Point(111, 28);
            this.nameEnqueueTextBox.Name = "nameEnqueueTextBox";
            this.nameEnqueueTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameEnqueueTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Complain";
            // 
            // complainEnqueueTextBox
            // 
            this.complainEnqueueTextBox.Location = new System.Drawing.Point(111, 54);
            this.complainEnqueueTextBox.Name = "complainEnqueueTextBox";
            this.complainEnqueueTextBox.Size = new System.Drawing.Size(206, 20);
            this.complainEnqueueTextBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Serial No";
            // 
            // serialNoTextBox
            // 
            this.serialNoTextBox.Location = new System.Drawing.Point(91, 28);
            this.serialNoTextBox.Name = "serialNoTextBox";
            this.serialNoTextBox.Size = new System.Drawing.Size(100, 20);
            this.serialNoTextBox.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Name";
            // 
            // nameDequeueTextBox
            // 
            this.nameDequeueTextBox.Location = new System.Drawing.Point(91, 54);
            this.nameDequeueTextBox.Name = "nameDequeueTextBox";
            this.nameDequeueTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameDequeueTextBox.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Complain";
            // 
            // complainDequeueTextBox
            // 
            this.complainDequeueTextBox.Location = new System.Drawing.Point(91, 80);
            this.complainDequeueTextBox.Name = "complainDequeueTextBox";
            this.complainDequeueTextBox.Size = new System.Drawing.Size(222, 20);
            this.complainDequeueTextBox.TabIndex = 2;
            // 
            // waitingQueueListView
            // 
            this.waitingQueueListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.serialNoColumnHeader,
            this.nameColumnHeader,
            this.complainColumnHeader});
            this.waitingQueueListView.Location = new System.Drawing.Point(22, 19);
            this.waitingQueueListView.Name = "waitingQueueListView";
            this.waitingQueueListView.Size = new System.Drawing.Size(655, 154);
            this.waitingQueueListView.TabIndex = 0;
            this.waitingQueueListView.UseCompatibleStateImageBehavior = false;
            this.waitingQueueListView.View = System.Windows.Forms.View.Details;
            // 
            // serialNoColumnHeader
            // 
            this.serialNoColumnHeader.Text = "Serial No";
            // 
            // nameColumnHeader
            // 
            this.nameColumnHeader.Text = "Name";
            // 
            // complainColumnHeader
            // 
            this.complainColumnHeader.Text = "Complain";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 441);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Customer Queue Management";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox complainEnqueueTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameEnqueueTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox complainDequeueTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nameDequeueTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox serialNoTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView waitingQueueListView;
        private System.Windows.Forms.ColumnHeader serialNoColumnHeader;
        private System.Windows.Forms.ColumnHeader nameColumnHeader;
        private System.Windows.Forms.ColumnHeader complainColumnHeader;
    }
}

