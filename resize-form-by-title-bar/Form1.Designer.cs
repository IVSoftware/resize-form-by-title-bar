namespace resize_form_by_title_bar
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
            titleBarPanel = new System.Windows.Forms.TableLayoutPanel();
            labelTitleBar = new System.Windows.Forms.Label();
            labelResize = new System.Windows.Forms.Label();
            labelMove = new System.Windows.Forms.Label();
            radioButtonMove = new System.Windows.Forms.RadioButton();
            radioButtonResize = new System.Windows.Forms.RadioButton();
            groupBox = new System.Windows.Forms.GroupBox();
            titleBarPanel.SuspendLayout();
            groupBox.SuspendLayout();
            SuspendLayout();
            // 
            // titleBarPanel
            // 
            titleBarPanel.BackColor = System.Drawing.Color.Azure;
            titleBarPanel.ColumnCount = 3;
            titleBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            titleBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            titleBarPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            titleBarPanel.Controls.Add(labelTitleBar, 0, 0);
            titleBarPanel.Controls.Add(labelResize, 1, 0);
            titleBarPanel.Controls.Add(labelMove, 2, 0);
            titleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            titleBarPanel.Location = new System.Drawing.Point(0, 0);
            titleBarPanel.Name = "titleBarPanel";
            titleBarPanel.RowCount = 1;
            titleBarPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            titleBarPanel.Size = new System.Drawing.Size(500, 50);
            titleBarPanel.TabIndex = 0;
            // 
            // labelTitleBar
            // 
            labelTitleBar.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelTitleBar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTitleBar.Location = new System.Drawing.Point(3, 0);
            labelTitleBar.Name = "labelTitleBar";
            labelTitleBar.Size = new System.Drawing.Size(394, 50);
            labelTitleBar.TabIndex = 0;
            labelTitleBar.Text = "Custom Title Bar";
            labelTitleBar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelResize
            // 
            labelResize.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelResize.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelResize.Location = new System.Drawing.Point(403, 0);
            labelResize.Name = "labelResize";
            labelResize.Size = new System.Drawing.Size(44, 50);
            labelResize.TabIndex = 0;
            labelResize.Text = "*";
            labelResize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMove
            // 
            labelMove.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            labelMove.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelMove.Location = new System.Drawing.Point(453, 0);
            labelMove.Name = "labelMove";
            labelMove.Size = new System.Drawing.Size(44, 50);
            labelMove.TabIndex = 0;
            labelMove.Text = "*";
            labelMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioButtonMove
            // 
            radioButtonMove.AutoSize = true;
            radioButtonMove.Checked = true;
            radioButtonMove.Location = new System.Drawing.Point(23, 48);
            radioButtonMove.Name = "radioButtonMove";
            radioButtonMove.Size = new System.Drawing.Size(82, 29);
            radioButtonMove.TabIndex = 1;
            radioButtonMove.TabStop = true;
            radioButtonMove.Text = "Move";
            radioButtonMove.UseVisualStyleBackColor = true;
            // 
            // radioButtonResize
            // 
            radioButtonResize.AutoSize = true;
            radioButtonResize.Location = new System.Drawing.Point(140, 48);
            radioButtonResize.Name = "radioButtonResize";
            radioButtonResize.Size = new System.Drawing.Size(85, 29);
            radioButtonResize.TabIndex = 1;
            radioButtonResize.Text = "Resize";
            radioButtonResize.UseVisualStyleBackColor = true;
            // 
            // groupBox
            // 
            groupBox.Controls.Add(radioButtonMove);
            groupBox.Controls.Add(radioButtonResize);
            groupBox.Location = new System.Drawing.Point(12, 77);
            groupBox.Name = "groupBox";
            groupBox.Size = new System.Drawing.Size(250, 110);
            groupBox.TabIndex = 2;
            groupBox.TabStop = false;
            groupBox.Text = "Default Title Bar Function";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(500, 300);
            Controls.Add(groupBox);
            Controls.Add(titleBarPanel);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MinimumSize = new System.Drawing.Size(50, 50);
            Name = "Form1";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Form1";
            titleBarPanel.ResumeLayout(false);
            groupBox.ResumeLayout(false);
            groupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel titleBarPanel;
        private System.Windows.Forms.Label labelTitleBar;
        private System.Windows.Forms.Label labelResize;
        private System.Windows.Forms.Label labelMove;
        private System.Windows.Forms.RadioButton radioButtonMove;
        private System.Windows.Forms.RadioButton radioButtonResize;
        private System.Windows.Forms.GroupBox groupBox;
    }
}
