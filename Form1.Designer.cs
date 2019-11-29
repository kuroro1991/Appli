namespace Appli
{
    partial class Appli
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
            this.start_button = new System.Windows.Forms.Button();
            this.foreground_checkBox = new System.Windows.Forms.CheckBox();
            this.setting_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(12, 12);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(179, 73);
            this.start_button.TabIndex = 0;
            this.start_button.Text = "作成&&起動";
            this.start_button.UseVisualStyleBackColor = true;
            this.start_button.Click += new System.EventHandler(this.start_button_Click);
            // 
            // foreground_checkBox
            // 
            this.foreground_checkBox.AutoSize = true;
            this.foreground_checkBox.Location = new System.Drawing.Point(12, 100);
            this.foreground_checkBox.Name = "foreground_checkBox";
            this.foreground_checkBox.Size = new System.Drawing.Size(84, 16);
            this.foreground_checkBox.TabIndex = 1;
            this.foreground_checkBox.Text = "最前面表示";
            this.foreground_checkBox.UseVisualStyleBackColor = true;
            this.foreground_checkBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // setting_button
            // 
            this.setting_button.Location = new System.Drawing.Point(148, 93);
            this.setting_button.Name = "setting_button";
            this.setting_button.Size = new System.Drawing.Size(43, 23);
            this.setting_button.TabIndex = 2;
            this.setting_button.Text = "設定";
            this.setting_button.UseVisualStyleBackColor = true;
            this.setting_button.Click += new System.EventHandler(this.setting_button_Click);
            // 
            // Appli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 131);
            this.Controls.Add(this.setting_button);
            this.Controls.Add(this.foreground_checkBox);
            this.Controls.Add(this.start_button);
            this.Name = "Appli";
            this.Text = "Appli";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.CheckBox foreground_checkBox;
        private System.Windows.Forms.Button setting_button;
    }
}

