namespace Appli
{
    partial class Form2
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.reference_button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.decision_button = new System.Windows.Forms.Button();
            this.close_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.reference_button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reference_button1
            // 
            this.reference_button1.Location = new System.Drawing.Point(318, 9);
            this.reference_button1.Name = "reference_button1";
            this.reference_button1.Size = new System.Drawing.Size(70, 20);
            this.reference_button1.TabIndex = 0;
            this.reference_button1.Text = "参照";
            this.reference_button1.UseVisualStyleBackColor = true;
            this.reference_button1.Click += new System.EventHandler(this.reference_button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "フォルダパス";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(77, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 19);
            this.textBox1.TabIndex = 3;
            // 
            // decision_button
            // 
            this.decision_button.Location = new System.Drawing.Point(221, 95);
            this.decision_button.Name = "decision_button";
            this.decision_button.Size = new System.Drawing.Size(75, 23);
            this.decision_button.TabIndex = 6;
            this.decision_button.Text = "適用";
            this.decision_button.UseVisualStyleBackColor = true;
            this.decision_button.Click += new System.EventHandler(this.decision_button_Click);
            // 
            // close_button
            // 
            this.close_button.Location = new System.Drawing.Point(312, 95);
            this.close_button.Name = "close_button";
            this.close_button.Size = new System.Drawing.Size(75, 23);
            this.close_button.TabIndex = 7;
            this.close_button.Text = "閉じる";
            this.close_button.UseVisualStyleBackColor = true;
            this.close_button.Click += new System.EventHandler(this.close_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "APLパス";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(77, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 19);
            this.textBox2.TabIndex = 9;
            // 
            // reference_button2
            // 
            this.reference_button2.Location = new System.Drawing.Point(318, 47);
            this.reference_button2.Name = "reference_button2";
            this.reference_button2.Size = new System.Drawing.Size(70, 20);
            this.reference_button2.TabIndex = 10;
            this.reference_button2.Text = "参照";
            this.reference_button2.UseVisualStyleBackColor = true;
            this.reference_button2.Click += new System.EventHandler(this.reference_button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 130);
            this.Controls.Add(this.reference_button2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.close_button);
            this.Controls.Add(this.decision_button);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reference_button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button reference_button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button decision_button;
        private System.Windows.Forms.Button close_button;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button reference_button2;
    }
}