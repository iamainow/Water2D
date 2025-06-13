using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace Water2D
{
	public partial class Form1:Form
	{
		Point prev;
		static float ddump=0.01F;
		static float dumping=1+ddump;
		int FPS=0;
		DateTime FPSTime=DateTime.Now;
		public static int N=400;
		float[] source=new float[N];
		float[] dest=new float[N];
		public Form1()
		{
			InitializeComponent();
		}
		private void DO(object sender,EventArgs e)
		{
			while(true)
			{
				var P=_image.PointToClient(Cursor.Position);
				if(prev!=new Point(0,0))
				{
					int dx=Math.Abs(P.X-prev.X);
					var R=new Random();
					Wave(P.X*N/550,(int)(N*0.05F),dx*(P.Y-200)*ddump*0.1F);
				}
				prev=P;
				//
				FPS++;
				if((DateTime.Now-FPSTime).TotalSeconds>=1)
				{
					this.Text=FPS.ToString();
					FPS=0;
					FPSTime=DateTime.Now;
				}
				float[] dest_new=new float[N];
				dest[0]=2*(source[1])-dest[0];
				dest[0]/=dumping;
				dest[N-1]=2*(source[N-2])-dest[N-1];
				dest[N-1]/=dumping;
				for(int i=1;i<N-1;i++)
				{
					dest[i]=(source[i-1]+source[i+1])-dest[i];
				}
				for(int i=1;i<N-1;i++)
				{
					dest[i]=(dest[i-1]+dest[i+1])/2;
				}
				for(int i=1;i<N-1;i++)
				{
					dest[i]=dest[i]/dumping;
				}
				Bitmap BM=new Bitmap(_image.Size.Width,_image.Size.Height);
				float ds=550F/N;
				using(Graphics G=Graphics.FromImage(BM))
				{
					for(int i1=1;i1<N;i1++)
					{
						G.DrawLine(Pens.Black,(int)((i1-1)*ds),200+dest[i1-1],(int)((i1)*ds),200+dest[i1]);
					}
				}
				if(_image.BackgroundImage!=null)
				{
					_image.BackgroundImage.Dispose();
				}
				_image.BackgroundImage=BM;
				var R2=source;
				source=dest;
				dest=R2;
				Application.DoEvents();
				System.Threading.Thread.Sleep(0);
			}
		}
		private void _image_Click(object sender,EventArgs e)
		{
			var P=_image.PointToClient(Cursor.Position);
			var R=new Random();
			Wave(P.X*N/550,(int)(N*1F),(P.Y-200)/5);
		}
		private void Wave(int C,int DR,float H)
		{
			if(H!=0)
			{
				for(int i1=0;i1<N;i1++)
				{
					if(Math.Abs(C-i1)<=DR)
					{
						source[i1]+=(float)(H*Math.Cos(((1.5708F*Math.Abs(C-i1))/DR)));
					}
				}
			}
		}
	}
}