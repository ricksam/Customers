using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DirectShowLib;

namespace ControlePortarias
{
  public partial class frmCamera : lib.Visual.Models.frmBase
  {
    public frmCamera()
    {
      InitializeComponent();
      //camera = new Capture(0, 640, 480, 24, this.imgCamera);
      camera = new lib.Visual.Components.AviCap();
      camera.Control = this.imgCamera;
      camera.Width = 640;
      camera.Height = 480;
      camera.Start();
    }

    lib.Visual.Components.AviCap camera { get; set; }
    //Capture camera { get; set; }
    public Bitmap LastImage { get; set; }
    
    protected override void OnKeyDown(KeyEventArgs e)
    {
      if (e.KeyData == Keys.Enter)
      {
        LastImage = camera.GetCurrentImage();
        this.DialogResult = System.Windows.Forms.DialogResult.OK;
      }
      base.OnKeyDown(e);
    }

    private void frmCamera_FormClosing(object sender, FormClosingEventArgs e)
    {
      //camera.Close();
      camera.Stop();
      camera.Dispose();
    }
  }
}
