﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace RckEventos
{
    public class FastPixel
    {
        private byte[] rgbValues = new byte[] { };

        private System.Drawing.Imaging.BitmapData bmpData;

        private IntPtr bmpPtr;

        private bool locked = false;

        private bool _isAlpha = false;

        private Bitmap _bitmap;

        private int _width;

        private int _height;

        public int Width
        {
            get
            {
                return this._width;
            }
        }

        public int Height
        {
            get
            {
                return this._height;
            }
        }

        public bool IsAlphaBitmap
        {
            get
            {
                return this._isAlpha;
            }
        }

        public Bitmap Bitmap
        {
            get
            {
                return this._bitmap;
            }
        }

        public FastPixel(Bitmap bitmap)
        {
            if ((bitmap.PixelFormat == (bitmap.PixelFormat | System.Drawing.Imaging.PixelFormat.Indexed)))
            {
                throw new Exception("Cannot lock an Indexed image.");
                //return;
            }
            this._bitmap = bitmap;
            this._isAlpha = (this.Bitmap.PixelFormat == (this.Bitmap.PixelFormat | System.Drawing.Imaging.PixelFormat.Alpha));
            this._width = bitmap.Width;
            this._height = bitmap.Height;
        }

        public void Lock()
        {
            if (this.locked)
            {
                throw new Exception("Bitmap already locked.");
                //return;
            }
            if (this.Width * this.Height <= 320 * 240)
            {
                Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);

                this.bmpData = this.Bitmap.LockBits(rect, System.Drawing.Imaging.ImageLockMode.ReadWrite, this.Bitmap.PixelFormat);
                this.bmpPtr = this.bmpData.Scan0;
                int bytes = this.IsAlphaBitmap ? ((this.Width * this.Height) * 4) : ((this.Width * this.Height) * 3);
                this.rgbValues = new byte[bytes];

                System.Runtime.InteropServices.Marshal.Copy(this.bmpPtr, rgbValues, 0, this.rgbValues.Length);

                this.locked = true;
            }
            else
            { this.locked = false; }
        }

        public void Unlock(bool setPixels)
        {
            if (!this.locked)
            {
                //throw new Exception("Bitmap not locked.");
                return;
            }
            //  Copy the RGB values back to the bitmap
            if (setPixels && this.locked)
            {
                System.Runtime.InteropServices.Marshal.Copy(this.rgbValues, 0, this.bmpPtr, this.rgbValues.Length);
            }
            //  Unlock the bits.
            this.Bitmap.UnlockBits(bmpData);
            this.locked = false;
        }

        public void Clear(Color colour)
        {
            if (!this.locked)
            {
                throw new Exception("Bitmap not locked.");
                //return;
            }
            if (this.IsAlphaBitmap)
            {
                for (int index = 0; (index
                            <= (this.rgbValues.Length - 1)); index = (index + 4))
                {
                    this.rgbValues[index] = colour.B;
                    this.rgbValues[(index + 1)] = colour.G;
                    this.rgbValues[(index + 2)] = colour.R;
                    this.rgbValues[(index + 3)] = colour.A;
                }
            }
            else
            {
                for (int index = 0; (index
                            <= (this.rgbValues.Length - 1)); index = (index + 3))
                {
                    this.rgbValues[index] = colour.B;
                    this.rgbValues[(index + 1)] = colour.G;
                    this.rgbValues[(index + 2)] = colour.R;
                }
            }
        }

        public void SetPixel(Point location, Color colour)
        {
            this.SetPixel(location.X, location.Y, colour);
        }

        public void SetPixel(int x, int y, Color colour)
        {
            if (!this.locked)
            {
                Bitmap.SetPixel(x, y, colour);
                //throw new Exception("Bitmap not locked.");
                return;
            }
            if (this.IsAlphaBitmap)
            {
                int index = (((y * this.Width) + x) * 4);
                this.rgbValues[index] = colour.B;
                this.rgbValues[(index + 1)] = colour.G;
                this.rgbValues[(index + 2)] = colour.R;
                this.rgbValues[(index + 3)] = colour.A;
            }
            else
            {
                int index = (((y * this.Width)
                            + x)
                            * 3);
                this.rgbValues[index] = colour.B;
                this.rgbValues[(index + 1)] = colour.G;
                this.rgbValues[(index + 2)] = colour.R;
            }
        }

        public Color GetPixel(Point location)
        {
            return this.GetPixel(location.X, location.Y);
        }

        public Color GetPixel(int x, int y)
        {
            if (!this.locked)
            {
                return Bitmap.GetPixel(x, y);
                //throw new Exception("Bitmap not locked.");
                //return null;
            }
            if (this.IsAlphaBitmap)
            {
                int index = (((y * this.Width) + x) * 4);
                int b = this.rgbValues[index];
                int g = this.rgbValues[(index + 1)];
                int r = this.rgbValues[(index + 2)];
                int a = this.rgbValues[(index + 3)];
                return Color.FromArgb(a, r, g, b);
            }
            else
            {
                int index = (((y * this.Width) + x) * 3);
                int b = this.rgbValues[index];
                int g = this.rgbValues[(index + 1)];
                int r = this.rgbValues[(index + 2)];
                return Color.FromArgb(r, g, b);
            }
        }
    }
}
