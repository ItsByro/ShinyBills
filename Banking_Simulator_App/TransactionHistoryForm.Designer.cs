/*
 * Created by SharpDevelop.
 * User: ItsByro
 * Date: 24/6/2026
 * Time: 12:49 pm
 */
namespace Banking_Simulator_App
{
	partial class TransactionHistoryForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dgvHistory = new System.Windows.Forms.DataGridView();
			this.btnExit = new System.Windows.Forms.Button();
			this.lblTitle = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvHistory
			// 
			this.dgvHistory.AllowUserToAddRows = false;
			this.dgvHistory.AllowUserToDeleteRows = false;
			this.dgvHistory.AllowUserToResizeColumns = false;
			this.dgvHistory.AllowUserToResizeRows = false;
			this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHistory.Location = new System.Drawing.Point(12, 25);
			this.dgvHistory.Name = "dgvHistory";
			this.dgvHistory.ReadOnly = true;
			this.dgvHistory.RowTemplate.Height = 28;
			this.dgvHistory.Size = new System.Drawing.Size(800, 325);
			this.dgvHistory.TabIndex = 0;
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(12, 375);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(109, 47);
			this.btnExit.TabIndex = 1;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
			// 
			// lblTitle
			// 
			this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTitle.Location = new System.Drawing.Point(307, 375);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(314, 47);
			this.lblTitle.TabIndex = 2;
			this.lblTitle.Text = "Transaction History";
			this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// TransactionHistoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(831, 434);
			this.Controls.Add(this.lblTitle);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.dgvHistory);
			this.Cursor = System.Windows.Forms.Cursors.PanNW;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "TransactionHistoryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Transaction History";
			this.Load += new System.EventHandler(this.TransactionHistoryFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.DataGridView dgvHistory;
	}
}
