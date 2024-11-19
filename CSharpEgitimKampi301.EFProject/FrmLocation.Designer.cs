namespace CSharpEgitimKampi301.EFProject
{
	partial class FrmLocation
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
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.txtCountry = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtCity = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnList = new System.Windows.Forms.Button();
			this.txtId = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtPrice = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.txtDayNight = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.nudCapacity = new System.Windows.Forms.NumericUpDown();
			this.cmdGuide = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).BeginInit();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(-136, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 16);
			this.label3.TabIndex = 18;
			this.label3.Text = "Rehber Soyadı:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(-110, 51);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 16);
			this.label2.TabIndex = 16;
			this.label2.Text = "Rehber Adı:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(-100, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 16);
			this.label1.TabIndex = 12;
			this.label1.Text = "Rehber Id:";
			// 
			// btnUpdate
			// 
			this.btnUpdate.BackColor = System.Drawing.Color.Salmon;
			this.btnUpdate.ForeColor = System.Drawing.Color.White;
			this.btnUpdate.Location = new System.Drawing.Point(124, 578);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(228, 38);
			this.btnUpdate.TabIndex = 29;
			this.btnUpdate.Text = "Güncelle";
			this.btnUpdate.UseVisualStyleBackColor = false;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.BackColor = System.Drawing.Color.Salmon;
			this.btnDelete.ForeColor = System.Drawing.Color.White;
			this.btnDelete.Location = new System.Drawing.Point(124, 516);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(228, 38);
			this.btnDelete.TabIndex = 28;
			this.btnDelete.Text = "Sil";
			this.btnDelete.UseVisualStyleBackColor = false;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.BackColor = System.Drawing.Color.Salmon;
			this.btnAdd.ForeColor = System.Drawing.Color.White;
			this.btnAdd.Location = new System.Drawing.Point(124, 452);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(228, 38);
			this.btnAdd.TabIndex = 27;
			this.btnAdd.Text = "Ekle";
			this.btnAdd.UseVisualStyleBackColor = false;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// txtCountry
			// 
			this.txtCountry.Location = new System.Drawing.Point(127, 145);
			this.txtCountry.Name = "txtCountry";
			this.txtCountry.Size = new System.Drawing.Size(228, 22);
			this.txtCountry.TabIndex = 26;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(70, 151);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(43, 16);
			this.label4.TabIndex = 25;
			this.label4.Text = "Ülke:";
			// 
			// txtCity
			// 
			this.txtCity.Location = new System.Drawing.Point(127, 89);
			this.txtCity.Name = "txtCity";
			this.txtCity.Size = new System.Drawing.Size(228, 22);
			this.txtCity.TabIndex = 24;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(66, 89);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(47, 16);
			this.label5.TabIndex = 23;
			this.label5.Text = "Şehir:";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(376, 27);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1067, 611);
			this.dataGridView1.TabIndex = 22;
			// 
			// btnList
			// 
			this.btnList.BackColor = System.Drawing.Color.Salmon;
			this.btnList.ForeColor = System.Drawing.Color.White;
			this.btnList.Location = new System.Drawing.Point(124, 388);
			this.btnList.Name = "btnList";
			this.btnList.Size = new System.Drawing.Size(228, 38);
			this.btnList.TabIndex = 21;
			this.btnList.Text = "Listele";
			this.btnList.UseVisualStyleBackColor = false;
			this.btnList.Click += new System.EventHandler(this.btnList_Click);
			// 
			// txtId
			// 
			this.txtId.Location = new System.Drawing.Point(127, 40);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(228, 22);
			this.txtId.TabIndex = 20;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(19, 43);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(95, 16);
			this.label6.TabIndex = 19;
			this.label6.Text = "Lokasyon Id:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(42, 206);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(72, 16);
			this.label7.TabIndex = 31;
			this.label7.Text = "Kapasite:";
			// 
			// txtPrice
			// 
			this.txtPrice.Location = new System.Drawing.Point(124, 249);
			this.txtPrice.Name = "txtPrice";
			this.txtPrice.Size = new System.Drawing.Size(228, 22);
			this.txtPrice.TabIndex = 34;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(69, 255);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(45, 16);
			this.label8.TabIndex = 33;
			this.label8.Text = "Fiyat:";
			// 
			// txtDayNight
			// 
			this.txtDayNight.Location = new System.Drawing.Point(127, 336);
			this.txtDayNight.Name = "txtDayNight";
			this.txtDayNight.Size = new System.Drawing.Size(228, 22);
			this.txtDayNight.TabIndex = 36;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(34, 342);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(79, 16);
			this.label9.TabIndex = 35;
			this.label9.Text = "Gün Gece:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(48, 294);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(62, 16);
			this.label10.TabIndex = 37;
			this.label10.Text = "Rehber:";
			// 
			// nudCapacity
			// 
			this.nudCapacity.Location = new System.Drawing.Point(127, 199);
			this.nudCapacity.Name = "nudCapacity";
			this.nudCapacity.Size = new System.Drawing.Size(228, 22);
			this.nudCapacity.TabIndex = 39;
			// 
			// cmdGuide
			// 
			this.cmdGuide.FormattingEnabled = true;
			this.cmdGuide.Location = new System.Drawing.Point(124, 294);
			this.cmdGuide.Name = "cmdGuide";
			this.cmdGuide.Size = new System.Drawing.Size(224, 24);
			this.cmdGuide.TabIndex = 40;
			// 
			// FrmLocation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1595, 696);
			this.Controls.Add(this.cmdGuide);
			this.Controls.Add(this.nudCapacity);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.txtDayNight);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.txtPrice);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.txtCountry);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtCity);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnList);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Name = "FrmLocation";
			this.Text = "FrmLocation";
			this.Load += new System.EventHandler(this.FrmLocation_Load);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudCapacity)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.TextBox txtCountry;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtCity;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnList;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtPrice;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtDayNight;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown nudCapacity;
		private System.Windows.Forms.ComboBox cmdGuide;
	}
}