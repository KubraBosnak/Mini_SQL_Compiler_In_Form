
namespace Mini_SQL_Compiler_In_Form
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
            this.btnNewQuery = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnCRUD = new System.Windows.Forms.Button();
            this.btnHelper = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageResults = new System.Windows.Forms.TabPage();
            this.tabPageMessages = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richMessage = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageResults.SuspendLayout();
            this.tabPageMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 211);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SQL QUERY";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHelper);
            this.groupBox2.Controls.Add(this.btnCRUD);
            this.groupBox2.Controls.Add(this.btnExecute);
            this.groupBox2.Controls.Add(this.btnNewQuery);
            this.groupBox2.Location = new System.Drawing.Point(566, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(230, 211);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "OPERATION";
            // 
            // btnNewQuery
            // 
            this.btnNewQuery.BackColor = System.Drawing.Color.HotPink;
            this.btnNewQuery.Location = new System.Drawing.Point(6, 59);
            this.btnNewQuery.Name = "btnNewQuery";
            this.btnNewQuery.Size = new System.Drawing.Size(218, 31);
            this.btnNewQuery.TabIndex = 0;
            this.btnNewQuery.Text = "NEW QUERY";
            this.btnNewQuery.UseVisualStyleBackColor = false;
            this.btnNewQuery.Click += new System.EventHandler(this.btnNewQuery_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.BackColor = System.Drawing.Color.HotPink;
            this.btnExecute.Location = new System.Drawing.Point(6, 22);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(218, 31);
            this.btnExecute.TabIndex = 1;
            this.btnExecute.Text = "EXECUTE";
            this.btnExecute.UseVisualStyleBackColor = false;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnCRUD
            // 
            this.btnCRUD.BackColor = System.Drawing.Color.HotPink;
            this.btnCRUD.Location = new System.Drawing.Point(6, 96);
            this.btnCRUD.Name = "btnCRUD";
            this.btnCRUD.Size = new System.Drawing.Size(218, 31);
            this.btnCRUD.TabIndex = 2;
            this.btnCRUD.Text = "INSERT - UPDATE - DELETE";
            this.btnCRUD.UseVisualStyleBackColor = false;
            this.btnCRUD.Click += new System.EventHandler(this.btnCRUD_Click);
            // 
            // btnHelper
            // 
            this.btnHelper.BackColor = System.Drawing.Color.HotPink;
            this.btnHelper.Location = new System.Drawing.Point(6, 133);
            this.btnHelper.Name = "btnHelper";
            this.btnHelper.Size = new System.Drawing.Size(218, 31);
            this.btnHelper.TabIndex = 3;
            this.btnHelper.Text = "SQL HELPER";
            this.btnHelper.UseVisualStyleBackColor = false;
            this.btnHelper.Click += new System.EventHandler(this.btnHelper_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageResults);
            this.tabControl1.Controls.Add(this.tabPageMessages);
            this.tabControl1.Location = new System.Drawing.Point(13, 231);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(777, 207);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPageResults
            // 
            this.tabPageResults.Controls.Add(this.dataGridView1);
            this.tabPageResults.Location = new System.Drawing.Point(4, 25);
            this.tabPageResults.Name = "tabPageResults";
            this.tabPageResults.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageResults.Size = new System.Drawing.Size(769, 178);
            this.tabPageResults.TabIndex = 0;
            this.tabPageResults.Text = "Results";
            this.tabPageResults.UseVisualStyleBackColor = true;
            // 
            // tabPageMessages
            // 
            this.tabPageMessages.Controls.Add(this.richMessage);
            this.tabPageMessages.Location = new System.Drawing.Point(4, 25);
            this.tabPageMessages.Name = "tabPageMessages";
            this.tabPageMessages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMessages.Size = new System.Drawing.Size(769, 178);
            this.tabPageMessages.TabIndex = 1;
            this.tabPageMessages.Text = "Messages";
            this.tabPageMessages.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(763, 172);
            this.dataGridView1.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(3, 18);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(541, 190);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // richMessage
            // 
            this.richMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richMessage.Location = new System.Drawing.Point(3, 3);
            this.richMessage.Name = "richMessage";
            this.richMessage.Size = new System.Drawing.Size(763, 172);
            this.richMessage.TabIndex = 0;
            this.richMessage.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "SQL";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageResults.ResumeLayout(false);
            this.tabPageMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnHelper;
        private System.Windows.Forms.Button btnCRUD;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnNewQuery;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageResults;
        private System.Windows.Forms.TabPage tabPageMessages;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richMessage;
    }
}

