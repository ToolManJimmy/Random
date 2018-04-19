namespace RandomNum
{
    partial class RandomProject
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.RandomBtn = new System.Windows.Forms.Button();
            this.RandomLabel = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.RandomClearBtn = new System.Windows.Forms.Button();
            this.TextLable = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RandomBtn
            // 
            this.RandomBtn.Location = new System.Drawing.Point(236, 276);
            this.RandomBtn.Name = "RandomBtn";
            this.RandomBtn.Size = new System.Drawing.Size(75, 23);
            this.RandomBtn.TabIndex = 0;
            this.RandomBtn.Text = "Button";
            this.RandomBtn.UseVisualStyleBackColor = true;
            this.RandomBtn.Click += new System.EventHandler(this.RandomBtn_Click);
            // 
            // RandomLabel
            // 
            this.RandomLabel.AutoSize = true;
            this.RandomLabel.Font = new System.Drawing.Font("新細明體", 30F);
            this.RandomLabel.Location = new System.Drawing.Point(253, 92);
            this.RandomLabel.Name = "RandomLabel";
            this.RandomLabel.Size = new System.Drawing.Size(37, 40);
            this.RandomLabel.TabIndex = 1;
            this.RandomLabel.Text = "  ";
            this.RandomLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(411, 118);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(100, 22);
            this.TextBox.TabIndex = 3;
            this.TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBox_KeyPress);
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(425, 146);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(75, 23);
            this.EnterBtn.TabIndex = 4;
            this.EnterBtn.Text = "新增";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(425, 241);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "刪除";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(425, 270);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 6;
            this.ClearBtn.Text = "清除所有";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // RandomClearBtn
            // 
            this.RandomClearBtn.Location = new System.Drawing.Point(236, 305);
            this.RandomClearBtn.Name = "RandomClearBtn";
            this.RandomClearBtn.Size = new System.Drawing.Size(75, 23);
            this.RandomClearBtn.TabIndex = 7;
            this.RandomClearBtn.Text = "Clear";
            this.RandomClearBtn.UseVisualStyleBackColor = true;
            this.RandomClearBtn.Click += new System.EventHandler(this.RandomBtnClear_Click);
            // 
            // TextLable
            // 
            this.TextLable.AutoSize = true;
            this.TextLable.Location = new System.Drawing.Point(13, 11);
            this.TextLable.Name = "TextLable";
            this.TextLable.Size = new System.Drawing.Size(0, 12);
            this.TextLable.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.TextLable);
            this.panel1.Location = new System.Drawing.Point(27, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 389);
            this.panel1.TabIndex = 10;
            // 
            // DeleteTextBox
            // 
            this.DeleteTextBox.Location = new System.Drawing.Point(411, 213);
            this.DeleteTextBox.Name = "DeleteTextBox";
            this.DeleteTextBox.Size = new System.Drawing.Size(100, 22);
            this.DeleteTextBox.TabIndex = 11;
            this.DeleteTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeleteTextBox_KeyPress);
            // 
            // RandomProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 450);
            this.Controls.Add(this.DeleteTextBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RandomClearBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EnterBtn);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.RandomLabel);
            this.Controls.Add(this.RandomBtn);
            this.Name = "RandomProject";
            this.Text = "Random";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RandomBtn;
        private System.Windows.Forms.Label RandomLabel;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button RandomClearBtn;
        private System.Windows.Forms.Label TextLable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox DeleteTextBox;
    }
}

