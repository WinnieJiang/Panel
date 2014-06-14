namespace Panel
{
    partial class controlPanel
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(controlPanel));
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.motorBox = new System.Windows.Forms.CheckBox();
            this.motorControl = new System.Windows.Forms.GroupBox();
            this.motorCondition = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.diagButton = new System.Windows.Forms.ToolStripButton();
            this.exitButton = new System.Windows.Forms.ToolStripButton();
            this.tabControl1.SuspendLayout();
            this.motorControl.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLabel.Location = new System.Drawing.Point(458, 510);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(141, 17);
            this.copyrightLabel.TabIndex = 0;
            this.copyrightLabel.Text = "Copyright ©2014 XJTLU";
            this.copyrightLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(37, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 23);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 73);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 23);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 73);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // motorBox
            // 
            this.motorBox.AutoSize = true;
            this.motorBox.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorBox.Location = new System.Drawing.Point(20, 60);
            this.motorBox.Name = "motorBox";
            this.motorBox.Size = new System.Drawing.Size(103, 21);
            this.motorBox.TabIndex = 2;
            this.motorBox.Text = "Motor Power";
            this.motorBox.UseVisualStyleBackColor = true;
            this.motorBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // motorControl
            // 
            this.motorControl.Controls.Add(this.motorCondition);
            this.motorControl.Controls.Add(this.motorBox);
            this.motorControl.Location = new System.Drawing.Point(816, 26);
            this.motorControl.Name = "motorControl";
            this.motorControl.Size = new System.Drawing.Size(200, 100);
            this.motorControl.TabIndex = 3;
            this.motorControl.TabStop = false;
            this.motorControl.Text = "Motor Control";
            // 
            // motorCondition
            // 
            this.motorCondition.AutoSize = true;
            this.motorCondition.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motorCondition.Location = new System.Drawing.Point(17, 29);
            this.motorCondition.Name = "motorCondition";
            this.motorCondition.Size = new System.Drawing.Size(156, 17);
            this.motorCondition.TabIndex = 3;
            this.motorCondition.Text = "Motor condition: Not Run";
            this.motorCondition.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagButton,
            this.exitButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1038, 25);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // diagButton
            // 
            this.diagButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.diagButton.Image = ((System.Drawing.Image)(resources.GetObject("diagButton.Image")));
            this.diagButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.diagButton.Name = "diagButton";
            this.diagButton.Size = new System.Drawing.Size(23, 22);
            this.diagButton.Text = "Open Communication Dialog";
            this.diagButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.diagButton.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // exitButton
            // 
            this.exitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.exitButton.Image = ((System.Drawing.Image)(resources.GetObject("exitButton.Image")));
            this.exitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(23, 22);
            this.exitButton.Text = "Exit";
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // controlPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 536);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.motorControl);
            this.Controls.Add(this.copyrightLabel);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Charlemagne Std", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "controlPanel";
            this.Text = "Wireless Control Panel";
            this.Load += new System.EventHandler(this.controlPanel_Load);
            this.tabControl1.ResumeLayout(false);
            this.motorControl.ResumeLayout(false);
            this.motorControl.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox motorBox;
        private System.Windows.Forms.GroupBox motorControl;
        private System.Windows.Forms.Label motorCondition;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton diagButton;
        private System.Windows.Forms.ToolStripButton exitButton;
    }
}

