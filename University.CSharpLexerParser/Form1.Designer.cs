namespace University.CSharpLexerParser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBoxCode = new TextBox();
            splitContainer1 = new SplitContainer();
            buttonParse = new Button();
            tabControl = new TabControl();
            tabPageTokens = new TabPage();
            dataGridViewTokens = new DataGridView();
            tabPageAST = new TabPage();
            treeViewAST = new TreeView();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageTokens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTokens).BeginInit();
            tabPageAST.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(558, 9);
            label1.Name = "label1";
            label1.Size = new Size(254, 20);
            label1.TabIndex = 0;
            label1.Text = "C# Lexer/Parser - Новое поколение!";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // textBoxCode
            // 
            textBoxCode.Dock = DockStyle.Fill;
            textBoxCode.Location = new Point(0, 0);
            textBoxCode.Multiline = true;
            textBoxCode.Name = "textBoxCode";
            textBoxCode.ScrollBars = ScrollBars.Vertical;
            textBoxCode.Size = new Size(560, 533);
            textBoxCode.TabIndex = 1;
            textBoxCode.TextChanged += codeTb_TextChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(12, 32);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonParse);
            splitContainer1.Panel1.Controls.Add(textBoxCode);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl);
            splitContainer1.Size = new Size(1352, 533);
            splitContainer1.SplitterDistance = 560;
            splitContainer1.TabIndex = 2;
            // 
            // buttonParse
            // 
            buttonParse.Anchor = AnchorStyles.Bottom;
            buttonParse.Location = new Point(204, 481);
            buttonParse.Name = "buttonParse";
            buttonParse.Size = new Size(128, 52);
            buttonParse.TabIndex = 3;
            buttonParse.Text = "Анализ";
            buttonParse.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageTokens);
            tabControl.Controls.Add(tabPageAST);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(788, 533);
            tabControl.TabIndex = 0;
            // 
            // tabPageTokens
            // 
            tabPageTokens.Controls.Add(dataGridViewTokens);
            tabPageTokens.Location = new Point(4, 29);
            tabPageTokens.Name = "tabPageTokens";
            tabPageTokens.Padding = new Padding(3);
            tabPageTokens.Size = new Size(780, 500);
            tabPageTokens.TabIndex = 0;
            tabPageTokens.Text = "Токены";
            tabPageTokens.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTokens
            // 
            dataGridViewTokens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTokens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTokens.Dock = DockStyle.Fill;
            dataGridViewTokens.Location = new Point(3, 3);
            dataGridViewTokens.Name = "dataGridViewTokens";
            dataGridViewTokens.RowHeadersWidth = 51;
            dataGridViewTokens.Size = new Size(774, 494);
            dataGridViewTokens.TabIndex = 0;
            dataGridViewTokens.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tabPageAST
            // 
            tabPageAST.Controls.Add(treeViewAST);
            tabPageAST.Location = new Point(4, 29);
            tabPageAST.Name = "tabPageAST";
            tabPageAST.Padding = new Padding(3);
            tabPageAST.Size = new Size(780, 500);
            tabPageAST.TabIndex = 1;
            tabPageAST.Text = "Дерево";
            tabPageAST.UseVisualStyleBackColor = true;
            // 
            // treeViewAST
            // 
            treeViewAST.Dock = DockStyle.Fill;
            treeViewAST.Location = new Point(3, 3);
            treeViewAST.Name = "treeViewAST";
            treeViewAST.Size = new Size(774, 494);
            treeViewAST.TabIndex = 0;
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.Location = new Point(12, 571);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(1345, 128);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 711);
            Controls.Add(richTextBox1);
            Controls.Add(splitContainer1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "CSharpTranslator";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabPageTokens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTokens).EndInit();
            tabPageAST.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxCode;
        private SplitContainer splitContainer1;
        private TabControl tabControl;
        private TabPage tabPageTokens;
        private TabPage tabPageAST;
        private DataGridView dataGridViewTokens;
        private TreeView treeViewAST;
        private Button buttonParse;
        private RichTextBox richTextBox1;
    }
}
