namespace CheckTestKankyo
{
	partial class MainForm
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows フォーム デザイナーで生成されたコード

		/// <summary>
		/// デザイナー サポートに必要なメソッドです。このメソッドの内容を
		/// コード エディターで変更しないでください。
		/// </summary>
		private void InitializeComponent()
		{
			this.FilePathtextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.Openbutton = new System.Windows.Forms.Button();
			this.Closebutton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// FilePathtextBox
			// 
			this.FilePathtextBox.Location = new System.Drawing.Point(71, 12);
			this.FilePathtextBox.Name = "FilePathtextBox";
			this.FilePathtextBox.Size = new System.Drawing.Size(360, 19);
			this.FilePathtextBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 12);
			this.label1.TabIndex = 1;
			this.label1.Text = "ファイルパス";
			// 
			// Openbutton
			// 
			this.Openbutton.Location = new System.Drawing.Point(437, 10);
			this.Openbutton.Name = "Openbutton";
			this.Openbutton.Size = new System.Drawing.Size(75, 23);
			this.Openbutton.TabIndex = 2;
			this.Openbutton.Text = "開く";
			this.Openbutton.UseVisualStyleBackColor = true;
			this.Openbutton.Click += new System.EventHandler(this.Openbutton_Click);
			// 
			// Closebutton
			// 
			this.Closebutton.Location = new System.Drawing.Point(541, 8);
			this.Closebutton.Name = "Closebutton";
			this.Closebutton.Size = new System.Drawing.Size(75, 23);
			this.Closebutton.TabIndex = 3;
			this.Closebutton.Text = "閉じる";
			this.Closebutton.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(629, 44);
			this.Controls.Add(this.Closebutton);
			this.Controls.Add(this.Openbutton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.FilePathtextBox);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox FilePathtextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button Openbutton;
		private System.Windows.Forms.Button Closebutton;
	}
}

