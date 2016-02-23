﻿/// Description: Program containing generic DrawStar and FillStar methods which could then
/// be used in any other program
/// Author: Mr. T.
/// Date: February 2014

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawingStarMethod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// Gathers information from the input boxes and then sends values
        /// to the DrawStar method to draw the star in the location and the 
        /// size that the user indicated.
        private void drawButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black);

            float xValue, yValue, size;

            xValue = Convert.ToSingle(xInput.Text);
            yValue = Convert.ToSingle(yInput.Text);
            size = Convert.ToSingle(sizeInput.Text);

            formGraphics.Clear(Color.DarkKhaki);
            DrawStar(drawPen, xValue, yValue, size);
        }

        /// <summary>
        /// Draws an unfilled star on the screen
        /// </summary>
        /// <param name="starPen">The pen that will be used to draw the star</param>
        /// <param name="x">X value of the top left corner of the square within which the star is drawn</param>
        /// <param name="y">Y value of the top left corner of the square within which the star is drawn</param>
        /// <param name="pixels">Side lengths of the square within which the star is drawn</param>
        public void DrawStar(Pen starPen, float x, float y, float pixels)
        {
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black);
            SolidBrush drawBrush = new SolidBrush(Color.Red);

            // base star is 207 pixels wide.  A scale is created based on this value to determine how long
            // to draw each side so that it will end up being the number of pixels wide that the user desires.
            float scale = pixels / 207;
            PointF[] points = new PointF[10];
            points[0] = new PointF(80 * scale + x, 77 * scale + y);
            points[1] = new PointF(103 * scale + x, 4 * scale + y);
            points[2] = new PointF(126 * scale + x, 78 * scale + y);
            points[3] = new PointF(207 * scale + x, 78 * scale + y);
            points[4] = new PointF(143 * scale + x, 125 * scale + y);
            points[5] = new PointF(167 * scale + x, 197 * scale + y);
            points[6] = new PointF(103 * scale + x, 152 * scale + y);
            points[7] = new PointF(40 * scale + x, 196 * scale + y);
            points[8] = new PointF(63 * scale + x, 123 * scale + y);
            points[9] = new PointF(0 * scale + x, 77 * scale + y);
            
            formGraphics.DrawPolygon(drawPen, points);
            
        }

        /// Gathers information from the input boxes and then sends values
        /// to the FillStar method to draw the filled star in the location and the 
        /// size that the user indicated.
        private void fillButton_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Black);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            float xValue, yValue, size;

            xValue = Convert.ToSingle(xInput.Text);
            yValue = Convert.ToSingle(yInput.Text);
            size = Convert.ToSingle(sizeInput.Text);

            formGraphics.Clear(Color.DarkKhaki);
            FillStar(drawBrush, xValue, yValue, size);
        }

        /// <summary>
        /// Draws a filled star on the screen
        /// </summary>
        /// <param name="drawBrush">The brush that will be used to draw and fill the star</param>
        /// <param name="x">X value of the top left corner of the square within which the filled star is drawn</param>
        /// <param name="y">Y value of the top left corner of the square within which the filled star is drawn</param>
        /// <param name="pixels">Side lengths of the square within which the star is drawn</param>
        public void FillStar(SolidBrush drawBrush, float x, float y, float pixels)
        {
            Graphics formGraphics = this.CreateGraphics();
            float scale = pixels / 207;
            PointF[] points = new PointF[10];
            points[0] = new PointF(80 * scale + x, 77 * scale + y);
            points[1] = new PointF(103 * scale + x, 4 * scale + y);
            points[2] = new PointF(126 * scale + x, 78 * scale + y);
            points[3] = new PointF(207 * scale + x, 78 * scale + y);
            points[4] = new PointF(143 * scale + x, 125 * scale + y);
            points[5] = new PointF(167 * scale + x, 197 * scale + y);
            points[6] = new PointF(103 * scale + x, 152 * scale + y);
            points[7] = new PointF(40 * scale + x, 196 * scale + y);
            points[8] = new PointF(63 * scale + x, 123 * scale + y);
            points[9] = new PointF(0 * scale + x, 77 * scale + y);

            formGraphics.FillPolygon(drawBrush, points);
        }
    }
}
