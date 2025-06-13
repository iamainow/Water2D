namespace Water2D
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components=null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing&&(components!=null))
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
			this._image=new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this._image)).BeginInit();
			this.SuspendLayout();
			// 
			// _image
			// 
			this._image.BackColor=System.Drawing.Color.White;
			this._image.Dock=System.Windows.Forms.DockStyle.Fill;
			this._image.Location=new System.Drawing.Point(0,0);
			this._image.Name="_image";
			this._image.Size=new System.Drawing.Size(534,412);
			this._image.TabIndex=0;
			this._image.TabStop=false;
			this._image.Click+=new System.EventHandler(this._image_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions=new System.Drawing.SizeF(6F,13F);
			this.AutoScaleMode=System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize=new System.Drawing.Size(534,412);
			this.Controls.Add(this._image);
			this.MaximizeBox=false;
			this.Name="Form1";
			this.Text="Form1";
			this.Shown+=new System.EventHandler(this.DO);
			((System.ComponentModel.ISupportInitialize)(this._image)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox _image;
	}
}

